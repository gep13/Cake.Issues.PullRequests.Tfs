﻿namespace Cake.Issues.PullRequests.Tfs
{
    using System;
    using Cake.Tfs.Authentication;
    using Cake.Tfs.PullRequest;

    /// <summary>
    /// Settings for <see cref="TfsPullRequestSystemAliases"/>.
    /// </summary>
    public class TfsPullRequestSystemSettings : TfsPullRequestSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsPullRequestSystemSettings"/> class.
        /// </summary>
        /// <param name="repositoryUrl">Full URL of the Git repository,
        /// eg. <code>http://myserver:8080/tfs/defaultcollection/myproject/_git/myrepository</code>.
        /// Supported URL schemes are HTTP, HTTPS and SSH.
        /// URLs using SSH scheme are converted to HTTPS.</param>
        /// <param name="sourceBranch">Branch for which the pull request is made.</param>
        /// <param name="credentials">Credentials to use to authenticate against Team Foundation Server or
        /// Azure DevOps.</param>
        public TfsPullRequestSystemSettings(Uri repositoryUrl, string sourceBranch, ITfsCredentials credentials)
            : base(repositoryUrl, sourceBranch, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsPullRequestSystemSettings"/> class.
        /// </summary>
        /// <param name="repositoryUrl">Full URL of the Git repository,
        /// eg. <code>http://myserver:8080/tfs/defaultcollection/myproject/_git/myrepository</code>.
        /// Supported URL schemes are HTTP, HTTPS and SSH.
        /// URLs using SSH scheme are converted to HTTPS.</param>
        /// <param name="pullRequestId">ID of the pull request.</param>
        /// <param name="credentials">Credentials to use to authenticate against Team Foundation Server or
        /// Azure DevOps.</param>
        public TfsPullRequestSystemSettings(Uri repositoryUrl, int pullRequestId, ITfsCredentials credentials)
            : base(repositoryUrl, pullRequestId, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsPullRequestSystemSettings"/> class
        /// based on the instance of a <see cref="TfsPullRequestSettings"/> class.
        /// </summary>
        /// <param name="settings">Settings containing the parameters.</param>
        public TfsPullRequestSystemSettings(TfsPullRequestSettings settings)
            : base(settings)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsPullRequestSystemSettings"/> class
        /// based on the environment variables set by the Azure Pipelines / TFS build.
        /// </summary>
        /// <param name="credentials">Credentials to use to authenticate against Team Foundation Server or
        /// Azure DevOps.</param>
        public TfsPullRequestSystemSettings(ITfsCredentials credentials)
            : base(credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsPullRequestSystemSettings"/> class
        /// based on the environment variables set by the Azure Pipelines / TFS build
        /// using the build authentication token.
        /// </summary>
        public TfsPullRequestSystemSettings()
            : base(UsingTfsBuildOAuthToken())
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether pull request system should check if commit Id
        /// is still up to date before posting comments.
        /// Default value is <c>true</c>.
        /// </summary>
        public bool CheckCommitId { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether discussion threads should automatically be
        /// resolved oder reopened.
        /// Default value is <c>true</c>.
        /// </summary>
        public bool ManageDiscussionThreadStatus { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether issues not related to a file should be posted
        /// as comments or not.
        /// Default value is <c>false</c>.
        /// </summary>
        public bool ReportIssuesNotRelatedToAFile { get; set; } = false;
    }
}
