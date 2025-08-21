const core = require('@actions/core');

class DevConfigGenerator {
  /**
   * Generate DevConfig JSON content based on PR title and detected changes
   * @param {string} prTitle - Pull request title for changelog messages
   * @param {Object} changes - Changes object with coreChanges and serviceChanges
   * @returns {string} - Formatted JSON string
   */
  async generate(prTitle, changes) {
    core.info('Generating DevConfig content...');

    if (!prTitle) {
      throw new Error('PR title is required for DevConfig generation');
    }

    const devConfig = {};

    // Add core section if there are core changes
    if (changes.coreChanges > 0) {
      devConfig.core = {
        changeLogMessages: [prTitle],
        type: "patch",
        updateMinimum: true
      };
      core.info(`Added core section with ${changes.coreChanges} changes`);
    }

    // Add services section if there are service changes
    if (changes.serviceChanges && changes.serviceChanges.length > 0) {
      devConfig.services = changes.serviceChanges.map(serviceName => ({
        serviceName: serviceName,
        type: "patch",
        changeLogMessages: [prTitle]
      }));
      core.info(`Added services section with ${changes.serviceChanges.length} services: ${changes.serviceChanges.join(', ')}`);
    }

    // Validate that we have at least one section
    if (!devConfig.core && !devConfig.services) {
      throw new Error('No changes detected - cannot generate DevConfig without core or service changes');
    }

    // Format as pretty JSON
    const jsonString = JSON.stringify(devConfig, null, 2);
    core.debug(`Generated DevConfig:\n${jsonString}`);

    return jsonString;
  }

  /**
   * Validate DevConfig JSON structure
   * @param {string} jsonString - JSON string to validate
   * @returns {Object} - Validation result with isValid and errors
   */
  validate(jsonString) {
    try {
      const devConfig = JSON.parse(jsonString);
      const errors = [];

      // Check for required structure
      if (!devConfig.core && !devConfig.services) {
        errors.push('DevConfig must have either "core" or "services" section');
      }

      // Validate core section if present
      if (devConfig.core) {
        if (!devConfig.core.changeLogMessages || !Array.isArray(devConfig.core.changeLogMessages)) {
          errors.push('Core section must have "changeLogMessages" array');
        }
        if (!devConfig.core.type) {
          errors.push('Core section must have "type" field');
        }
      }

      // Validate services section if present
      if (devConfig.services) {
        if (!Array.isArray(devConfig.services)) {
          errors.push('Services section must be an array');
        } else {
          devConfig.services.forEach((service, index) => {
            if (!service.serviceName) {
              errors.push(`Service at index ${index} must have "serviceName" field`);
            }
            if (!service.type) {
              errors.push(`Service at index ${index} must have "type" field`);
            }
            if (!service.changeLogMessages || !Array.isArray(service.changeLogMessages)) {
              errors.push(`Service at index ${index} must have "changeLogMessages" array`);
            }
          });
        }
      }

      return {
        isValid: errors.length === 0,
        errors: errors,
        devConfig: devConfig
      };
    } catch (error) {
      return {
        isValid: false,
        errors: [`Invalid JSON: ${error.message}`],
        devConfig: null
      };
    }
  }

  /**
   * Format JSON string with proper indentation
   * @param {string} jsonString - JSON string to format
   * @returns {string} - Formatted JSON string
   */
  formatJson(jsonString) {
    try {
      const parsed = JSON.parse(jsonString);
      return JSON.stringify(parsed, null, 2);
    } catch (error) {
      core.warning(`Failed to format JSON: ${error.message}`);
      return jsonString;
    }
  }
}

module.exports = DevConfigGenerator;
