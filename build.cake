Task("Build").Does(() => {
    MSBuild("src/HiSharper");
});

var target = Argument("target", "Build");
RunTarget(target);