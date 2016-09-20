﻿/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');


var config = {
    //Include all js files but exclude any min.js files
    src: ['App/**/*.js', '!App/**/*.min.js']
}

gulp.task("concat", function () {
    return gulp.src(config.src)
    // .pipe(uglify())
     .pipe(concat('app.min.js'))
     .pipe(gulp.dest('wwwroot/'));
});

gulp.task("watch", function () {
    return gulp.watch(config.src, ["concat"]); 
}); 

gulp.task("default", ["watch"]); 