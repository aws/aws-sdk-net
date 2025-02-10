/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PrometheusService
{

    /// <summary>
    /// Constants used for properties of type AlertManagerDefinitionStatusCode.
    /// </summary>
    public class AlertManagerDefinitionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode ACTIVE = new AlertManagerDefinitionStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATING for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode CREATING = new AlertManagerDefinitionStatusCode("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode CREATION_FAILED = new AlertManagerDefinitionStatusCode("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode DELETING = new AlertManagerDefinitionStatusCode("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode UPDATE_FAILED = new AlertManagerDefinitionStatusCode("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for AlertManagerDefinitionStatusCode
        /// </summary>
        public static readonly AlertManagerDefinitionStatusCode UPDATING = new AlertManagerDefinitionStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertManagerDefinitionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertManagerDefinitionStatusCode FindValue(string value)
        {
            return FindValue<AlertManagerDefinitionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertManagerDefinitionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingConfigurationStatusCode.
    /// </summary>
    public class LoggingConfigurationStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode ACTIVE = new LoggingConfigurationStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATING for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode CREATING = new LoggingConfigurationStatusCode("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode CREATION_FAILED = new LoggingConfigurationStatusCode("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode DELETING = new LoggingConfigurationStatusCode("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode UPDATE_FAILED = new LoggingConfigurationStatusCode("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for LoggingConfigurationStatusCode
        /// </summary>
        public static readonly LoggingConfigurationStatusCode UPDATING = new LoggingConfigurationStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingConfigurationStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingConfigurationStatusCode FindValue(string value)
        {
            return FindValue<LoggingConfigurationStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingConfigurationStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleGroupsNamespaceStatusCode.
    /// </summary>
    public class RuleGroupsNamespaceStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode ACTIVE = new RuleGroupsNamespaceStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATING for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode CREATING = new RuleGroupsNamespaceStatusCode("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode CREATION_FAILED = new RuleGroupsNamespaceStatusCode("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode DELETING = new RuleGroupsNamespaceStatusCode("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode UPDATE_FAILED = new RuleGroupsNamespaceStatusCode("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for RuleGroupsNamespaceStatusCode
        /// </summary>
        public static readonly RuleGroupsNamespaceStatusCode UPDATING = new RuleGroupsNamespaceStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleGroupsNamespaceStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleGroupsNamespaceStatusCode FindValue(string value)
        {
            return FindValue<RuleGroupsNamespaceStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleGroupsNamespaceStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScraperStatusCode.
    /// </summary>
    public class ScraperStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode ACTIVE = new ScraperStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATING for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode CREATING = new ScraperStatusCode("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode CREATION_FAILED = new ScraperStatusCode("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode DELETING = new ScraperStatusCode("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode DELETION_FAILED = new ScraperStatusCode("DELETION_FAILED");
        /// <summary>
        /// Constant UPDATE_FAILED for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode UPDATE_FAILED = new ScraperStatusCode("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ScraperStatusCode
        /// </summary>
        public static readonly ScraperStatusCode UPDATING = new ScraperStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScraperStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScraperStatusCode FindValue(string value)
        {
            return FindValue<ScraperStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScraperStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceStatusCode.
    /// </summary>
    public class WorkspaceStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkspaceStatusCode
        /// </summary>
        public static readonly WorkspaceStatusCode ACTIVE = new WorkspaceStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATING for WorkspaceStatusCode
        /// </summary>
        public static readonly WorkspaceStatusCode CREATING = new WorkspaceStatusCode("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for WorkspaceStatusCode
        /// </summary>
        public static readonly WorkspaceStatusCode CREATION_FAILED = new WorkspaceStatusCode("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for WorkspaceStatusCode
        /// </summary>
        public static readonly WorkspaceStatusCode DELETING = new WorkspaceStatusCode("DELETING");
        /// <summary>
        /// Constant UPDATING for WorkspaceStatusCode
        /// </summary>
        public static readonly WorkspaceStatusCode UPDATING = new WorkspaceStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceStatusCode FindValue(string value)
        {
            return FindValue<WorkspaceStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}