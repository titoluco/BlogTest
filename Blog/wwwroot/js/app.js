﻿var blogService = require('./blogService.js');
var serviceWorker = require('./swRegister.js');

//window events
let defferedPrompt;
window.addEventListener('beforeinstallprompt', (e) => {
    e.preventDefault();
    defferedPrompt = e;
    //atualizar a tela para notificar o usuario
    // que ele pode adicionar à tela de home
    $('#install-container').show();
});

window.addEventListener('appinstalled', (evt) => {
    console.log('app foi adicionada na home screen! Yuhuu!');
});

window.pageEvents = {
    addFavourite: function (id) {
        blogService.addFavourite(id);
    },
    loadBlogPost: function (link) {
        blogService.loadBlogPost(link);
    },
    loadFavouritePost: function () {
        blogService.loadFavouritePost();
    },
    loadMoreBlogPosts: function () {
        blogService.loadMoreBlogPosts();
    },
    ExitBlogPost: function () {
        blogService.ExitBlogPost();
    },
    tryAddHomeScreen: function () {
        defferedPrompt.prompt();
        defferedPrompt.userChoice.then((choiceResult) => {
            if (choiceResult.outcome === 'accepted') {
                console.log('Usuário aceitou o A2HS prompt');
                $('#install-container').hide();
            }
            defferedPrompt = null;
        });
    }
};

if ($("#blog-title").html()) {
    blogService.loadLatestBlogPosts();
}
else {
    blogService.loadFavouritePost();
}

