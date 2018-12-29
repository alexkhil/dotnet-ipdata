#addin Cake.Coveralls
#tool coveralls.io

#load Utils/paths.cake

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument<string>("Target", "Default");
var configuration = Argument<string>("Configuration", "Release");
var packageOutputPath = Argument<DirectoryPath>("PackageOutputPath", "packages");
var CoverallsToken = Argument<string>("Coveralls", "REPO_TOKEN");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

#load Tasks/clean.cake
#load Tasks/restore-nuget-packages.cake
#load Tasks/build.cake
#load Tasks/run-unit-tests.cake
#load Tasks/publish-coverage.cake
#load Tasks/default.cake

///////////////////////////////////////////////////////////////////////////////
// SETUP
///////////////////////////////////////////////////////////////////////////////

// Setup(ctx =>
// {
//    Information("Executed BEFORE the first task.");
// });

///////////////////////////////////////////////////////////////////////////////
// TEARDOWN
///////////////////////////////////////////////////////////////////////////////

// Teardown(ctx =>
// {
//   Information("Executed AFTER the last task.");
// });

RunTarget(target);