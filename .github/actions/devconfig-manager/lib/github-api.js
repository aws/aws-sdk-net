const core = require('@actions/core');
const github = require('@actions/github');

class GitHubApi {
  constructor(token) {
    this.octokit = github.getOctokit(token);
    this.context = github.context;
  }

  /**
   * Post DevConfig preview comment to PR
   * @param {string} prNumber - Pull request number
   * @param {string} devConfigContent - Generated DevConfig JSON content
   */
  async postDevConfigPreviewComment(prNumber, devConfigContent) {
    core.info(`Posting DevConfig preview comment to PR #${prNumber}`);

    const commentBody = `## DevConfig File Needed

This PR requires a DevConfig file. Here's the suggested DevConfig:

\`\`\`json
${devConfigContent}
\`\`\`

**To add this DevConfig:**

1. Create the file \`./generator/.DevConfigs/pr-${prNumber}.json\`
2. Copy the JSON above into the file
3. Commit and push the file to your PR

For more information about DevConfig files, see the [CONTRIBUTING.md](https://github.com/aws/aws-sdk-net/blob/main/CONTRIBUTING.md),`;

    try {
      await this.octokit.rest.issues.createComment({
        owner: this.context.repo.owner,
        repo: this.context.repo.repo,
        issue_number: parseInt(prNumber),
        body: commentBody
      });

      core.info('DevConfig preview comment posted successfully');
    } catch (error) {
      core.error(`Failed to post preview comment: ${error.message}`);
      throw new Error(`GitHub API error: ${error.message}`);
    }
  }

  /**
   * Post DevConfig validation error comment to PR
   * @param {string} prNumber - Pull request number
   * @param {Object} validation - Validation result object
   * @param {string} correctedDevConfig - Corrected DevConfig JSON content
   */
  async postDevConfigValidationError(prNumber, validation, correctedDevConfig) {
    core.info(`Posting DevConfig validation error comment to PR #${prNumber}`);

    let errorDetails = '';
    
    if (validation.missingServices.length > 0) {
      errorDetails += `**Missing Services:** ${validation.missingServices.join(', ')}\n`;
    }
    
    if (validation.missingCore) {
      errorDetails += `**Missing Core Section:** Core changes detected but no core section in DevConfig\n`;
    }

    if (validation.error) {
      errorDetails += `**Error:** ${validation.error}\n`;
    }

    const commentBody = `## DevConfig Validation Failed ❌

Your PR includes a DevConfig file, but it doesn't cover all the changes in this PR.

${errorDetails}
${validation.configuredServices.length > 0 ? `**Currently Configured Services:** ${validation.configuredServices.join(', ')}\n` : ''}

**Corrected DevConfig:**

\`\`\`json
${correctedDevConfig}
\`\`\`

**To fix this:**

1. Update your DevConfig file with the corrected content above
2. Make sure all changed services and core components are included
3. Commit and push the updated file

For more information about DevConfig files, see the [DevConfig Files](https://github.com/aws/aws-sdk-net/blob/main/README.md#devconfig-files) section in the README.md.`;

    try {
      await this.octokit.rest.issues.createComment({
        owner: this.context.repo.owner,
        repo: this.context.repo.repo,
        issue_number: parseInt(prNumber),
        body: commentBody
      });

      core.info('DevConfig validation error comment posted successfully');
    } catch (error) {
      core.error(`Failed to post validation error comment: ${error.message}`);
      throw new Error(`GitHub API error: ${error.message}`);
    }
  }

  /**
   * Get current repository information
   * @returns {Object} - Repository information
   */
  getRepoInfo() {
    return {
      owner: this.context.repo.owner,
      repo: this.context.repo.repo,
      fullName: `${this.context.repo.owner}/${this.context.repo.repo}`
    };
  }
}

module.exports = GitHubApi;
