/*
//define([], function () {
define(['./template.js'], function (template) {
    var blogPostUrl = '/Home/LatestBlogPosts/';
    function loadLatestBlogPosts() {
        fetch(blogPostUrl)
            .then(function (response) {
                return response.json();
            }).then(function (data) {
                //console.log(data);
                template.appendBlogList(data);
            });
    }
    return {
        loadLatestBlogPosts:
            loadLatestBlogPosts
    }
});
*/

define(['./template.js'], function (template) {
    var blogPostUrl = '/Home/LatestBlogPosts/';
    function loadLatestBlogPosts() {
        fetch(blogPostUrl)
            .then(function (response) {
                return response.json();
            }).then(function (data) {
                template.appendBlogList(data);
            });
    }
    return {
        loadLatestBlogPosts: loadLatestBlogPosts
    };
});
