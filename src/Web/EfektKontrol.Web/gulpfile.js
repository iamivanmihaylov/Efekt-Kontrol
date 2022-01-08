/// <binding AfterBuild='sass-compile' />
var gulp = require('gulp');
var sass = require('gulp-sass')(require('sass'));

gulp.task('sass-compile', async function () {
    gulp.src('./wwwroot/styles/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('watch-sass', async function () {
    gulp.watch('./wwwroot/styles/*.scss', gulp.series('sass-compile'));
});