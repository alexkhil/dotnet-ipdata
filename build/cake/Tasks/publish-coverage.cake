Task("Publish-Coverage")
    .IsDependentOn("Run-Unit-Tests")
    .Does(() =>
    {
        Information($"CommitId: {CommitId}");
        Information($"Branch: {CommitBranch}");
        Information($"Message: {CommitMessage}");
        CoverallsNet(CoverallsPath, CoverallsNetReportType.OpenCover, new CoverallsNetSettings
        {
            CommitId = CommitId,
            CommitAuthor = "test",
            CommitEmail = "test@test.com",
            CommitBranch = CommitBranch,
            CommitMessage = CommitMessage,
            RepoToken = CoverallsToken
        });
    });