const core = require('@actions/core');
const fs = require('fs').promises;
const path = require('path');
const simpleGit = require('simple-git');

class FileOperations {
  constructor() {
    this.devConfigDir = './generator/.DevConfigs';
    this.git = simpleGit();
  }

  /**
   * Check if DevConfig files were added/modified in this PR
   * @returns {boolean} - True if DevConfig files were changed in this PR
   */
  async hasExistingDevConfig() {
    core.info('Checking if DevConfig files were added/modified in this PR...');

    try {
      // Get list of changed files compared to origin/main
      const diffResult = await this.git.diff(['--name-only', 'origin/main...']);
      const changedFiles = diffResult.split('\n').filter(file => file.trim() !== '');

      // Filter for DevConfig files that were added/modified in this PR
      const devConfigChanges = changedFiles.filter(file => 
        file.startsWith('generator/.DevConfigs/') && file.endsWith('.json')
      );

      const hasDevConfigChanges = devConfigChanges.length > 0;
      
      if (hasDevConfigChanges) {
        core.info(`Found ${devConfigChanges.length} DevConfig files changed in this PR: ${devConfigChanges.join(', ')}`);
      } else {
        core.info('No DevConfig files were added/modified in this PR');
      }
      
      return hasDevConfigChanges;
    } catch (error) {
      core.warning(`Error checking for DevConfig changes: ${error.message}`);
      return false;
    }
  }

  /**
   * Get DevConfig files that were added/modified in this PR
   * @returns {string[]} - Array of DevConfig file paths in this PR
   */
  async getDevConfigFilesInPR() {
    try {
      const diffResult = await this.git.diff(['--name-only', 'origin/main...']);
      const changedFiles = diffResult.split('\n').filter(file => file.trim() !== '');
      
      const devConfigFiles = changedFiles.filter(file => 
        file.startsWith('generator/.DevConfigs/') && file.endsWith('.json')
      );
      
      return devConfigFiles;
    } catch (error) {
      core.warning(`Error getting DevConfig files: ${error.message}`);
      return [];
    }
  }

  /**
   * Read and parse DevConfig file contents
   * @param {string} filePath - Path to DevConfig file
   * @returns {Object|null} - Parsed DevConfig content or null if invalid
   */
  async readDevConfigFile(filePath) {
    try {
      const content = await fs.readFile(filePath, 'utf8');
      return JSON.parse(content);
    } catch (error) {
      core.warning(`Error reading DevConfig file ${filePath}: ${error.message}`);
      return null;
    }
  }

  /**
   * Validate that DevConfig contains all required services
   * @param {Object} changes - Changes detected by file analyzer
   * @returns {Object} - Validation result with isValid and missing services
   */
  async validateDevConfigContents(changes) {
    core.info('Validating DevConfig contents against detected changes...');
    
    try {
      // Get DevConfig files in this PR
      const devConfigFiles = await this.getDevConfigFilesInPR();
      
      if (devConfigFiles.length === 0) {
        return {
          isValid: false,
          missingServices: changes.serviceChanges,
          missingCore: changes.coreChanges > 0,
          error: 'No DevConfig files found in PR'
        };
      }

      // Parse all DevConfig files in PR
      const parsedConfigs = [];
      for (const filePath of devConfigFiles) {
        const config = await this.readDevConfigFile(filePath);
        if (config) {
          parsedConfigs.push(config);
        }
      }

      if (parsedConfigs.length === 0) {
        return {
          isValid: false,
          missingServices: changes.serviceChanges,
          missingCore: changes.coreChanges > 0,
          error: 'Could not parse any DevConfig files in PR'
        };
      }

      // Collect all services mentioned in DevConfig files
      const configuredServices = new Set();
      let hasCore = false;

      for (const config of parsedConfigs) {
        // Check for core section
        if (config.core) {
          hasCore = true;
        }

        // Check for services
        if (config.services && Array.isArray(config.services)) {
          for (const service of config.services) {
            if (service.serviceName) {
              configuredServices.add(service.serviceName);
            }
          }
        }
      }

      // Check what's missing
      const missingServices = changes.serviceChanges.filter(
        service => !configuredServices.has(service)
      );
      const missingCore = changes.coreChanges > 0 && !hasCore;

      const isValid = missingServices.length === 0 && !missingCore;

      core.info(`Validation result: ${isValid ? 'VALID' : 'INVALID'}`);
      if (!isValid) {
        core.info(`Missing services: ${missingServices.join(', ')}`);
        if (missingCore) core.info('Missing core section');
      }

      return {
        isValid,
        missingServices,
        missingCore,
        configuredServices: Array.from(configuredServices),
        error: null
      };

    } catch (error) {
      core.error(`DevConfig validation failed: ${error.message}`);
      return {
        isValid: false,
        missingServices: changes.serviceChanges,
        missingCore: changes.coreChanges > 0,
        error: error.message
      };
    }
  }

  /**
   * Check if a directory exists
   * @param {string} dirPath - Directory path to check
   * @returns {boolean} - True if directory exists
   */
  async directoryExists(dirPath) {
    try {
      const stats = await fs.stat(dirPath);
      return stats.isDirectory();
    } catch {
      return false;
    }
  }
}

module.exports = FileOperations;
