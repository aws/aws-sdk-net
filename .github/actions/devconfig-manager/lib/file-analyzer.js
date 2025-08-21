const core = require('@actions/core');
const simpleGit = require('simple-git');
const path = require('path');

class FileAnalyzer {
  constructor() {
    this.git = simpleGit();
  }

  /**
   * Analyze all changes in the current PR against main branch
   * @returns {Object} - Object with coreChanges count and serviceChanges array
   */
  async analyzeChanges() {
    core.info('Analyzing changes against main branch...');

    try {
      // Get list of changed files compared to origin/main
      const diffResult = await this.git.diff(['--name-only', 'origin/main...']);
      const changedFiles = diffResult.split('\n').filter(file => file.trim() !== '');

      core.info(`Found ${changedFiles.length} changed files`);
      core.debug(`Changed files: ${changedFiles.join(', ')}`);

      // Analyze core vs service changes
      const coreChanges = this.getCoreChanges(changedFiles);
      const serviceChanges = this.getServiceChanges(changedFiles);

      const result = {
        coreChanges: coreChanges.length,
        serviceChanges: serviceChanges,
        allChangedFiles: changedFiles
      };

      core.info(`Analysis complete - Core changes: ${result.coreChanges}, Service changes: ${result.serviceChanges.length}`);
      
      return result;
    } catch (error) {
      core.error(`Failed to analyze changes: ${error.message}`);
      throw new Error(`Git analysis failed: ${error.message}`);
    }
  }

  /**
   * Get files that are core changes (not in Services directory)
   * @param {string[]} changedFiles - Array of changed file paths
   * @returns {string[]} - Array of core change files
   */
  getCoreChanges(changedFiles) {
    const coreFiles = changedFiles.filter(file => {
      // Exclude service files
      if (file.startsWith('sdk/src/Services/')) return false;
      
      // Exclude DevConfig files - they shouldn't trigger DevConfig requirements
      if (file.startsWith('generator/.DevConfigs/')) return false;
      
      // Everything else is considered a core change
      return true;
    });

    core.debug(`Core files: ${coreFiles.join(', ')}`);
    return coreFiles;
  }

  /**
   * Get unique service names from changed service files
   * @param {string[]} changedFiles - Array of changed file paths
   * @returns {string[]} - Array of unique service names
   */
  getServiceChanges(changedFiles) {
    const serviceFiles = changedFiles.filter(file => {
      // Service changes are files in sdk/src/Services/
      return file.startsWith('sdk/src/Services/');
    });

    // Extract service names from paths like: sdk/src/Services/S3/...
    const serviceNames = serviceFiles
      .map(file => {
        const parts = file.split('/');
        // Path structure: sdk/src/Services/ServiceName/...
        if (parts.length >= 4 && parts[0] === 'sdk' && parts[1] === 'src' && parts[2] === 'Services') {
          return parts[3]; // Service name is the 4th part
        }
        return null;
      })
      .filter(service => service !== null)
      .filter((service, index, array) => array.indexOf(service) === index) // Remove duplicates
      .sort(); // Sort alphabetically

    core.debug(`Service names: ${serviceNames.join(', ')}`);
    return serviceNames;
  }

  /**
   * Check if there are any changes that require DevConfig
   * @returns {boolean} - True if DevConfig is needed
   */
  async needsDevConfig() {
    const changes = await this.analyzeChanges();
    return changes.coreChanges > 0 || changes.serviceChanges.length > 0;
  }

  /**
   * Get detailed change information for a specific service
   * @param {string} serviceName - Name of the service to analyze
   * @returns {Object} - Detailed change information for the service
   */
  async getServiceDetails(serviceName) {
    core.info(`Getting details for service: ${serviceName}`);

    try {
      const diffResult = await this.git.diff(['--name-only', 'origin/main...']);
      const changedFiles = diffResult.split('\n').filter(file => file.trim() !== '');

      const serviceFiles = changedFiles.filter(file => {
        return file.startsWith(`sdk/src/Services/${serviceName}/`);
      });

      return {
        serviceName: serviceName,
        changedFiles: serviceFiles,
        fileCount: serviceFiles.length
      };
    } catch (error) {
      core.error(`Failed to get service details for ${serviceName}: ${error.message}`);
      throw new Error(`Service analysis failed: ${error.message}`);
    }
  }

  /**
   * Get the current branch name
   * @returns {string} - Current branch name
   */
  async getCurrentBranch() {
    try {
      const branchResult = await this.git.revparse(['--abbrev-ref', 'HEAD']);
      return branchResult.trim();
    } catch (error) {
      core.warning(`Failed to get current branch: ${error.message}`);
      return 'unknown';
    }
  }

  /**
   * Check if current branch should be excluded from DevConfig validation
   * @returns {boolean} - True if branch should be excluded
   */
  async shouldExcludeBranch() {
    const excludedBranches = [
      'main',
      'development', 
      'aws-sdk-net-v3.7',
      'aws-sdk-net-v3.7-development'
    ];

    const currentBranch = await this.getCurrentBranch();
    const shouldExclude = excludedBranches.includes(currentBranch);

    if (shouldExclude) {
      core.info(`Branch ${currentBranch} is excluded from DevConfig validation`);
    }

    return shouldExclude;
  }
}

module.exports = FileAnalyzer;
