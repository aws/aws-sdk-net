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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk
{

    /// <summary>
    /// Constants used for properties of type ActionHistoryStatus.
    /// </summary>
    public class ActionHistoryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ActionHistoryStatus
        /// </summary>
        public static readonly ActionHistoryStatus Completed = new ActionHistoryStatus("Completed");
        /// <summary>
        /// Constant Failed for ActionHistoryStatus
        /// </summary>
        public static readonly ActionHistoryStatus Failed = new ActionHistoryStatus("Failed");
        /// <summary>
        /// Constant Unknown for ActionHistoryStatus
        /// </summary>
        public static readonly ActionHistoryStatus Unknown = new ActionHistoryStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionHistoryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionHistoryStatus FindValue(string value)
        {
            return FindValue<ActionHistoryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionHistoryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionStatus.
    /// </summary>
    public class ActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Pending for ActionStatus
        /// </summary>
        public static readonly ActionStatus Pending = new ActionStatus("Pending");
        /// <summary>
        /// Constant Running for ActionStatus
        /// </summary>
        public static readonly ActionStatus Running = new ActionStatus("Running");
        /// <summary>
        /// Constant Scheduled for ActionStatus
        /// </summary>
        public static readonly ActionStatus Scheduled = new ActionStatus("Scheduled");
        /// <summary>
        /// Constant Unknown for ActionStatus
        /// </summary>
        public static readonly ActionStatus Unknown = new ActionStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionStatus FindValue(string value)
        {
            return FindValue<ActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant InstanceRefresh for ActionType
        /// </summary>
        public static readonly ActionType InstanceRefresh = new ActionType("InstanceRefresh");
        /// <summary>
        /// Constant PlatformUpdate for ActionType
        /// </summary>
        public static readonly ActionType PlatformUpdate = new ActionType("PlatformUpdate");
        /// <summary>
        /// Constant Unknown for ActionType
        /// </summary>
        public static readonly ActionType Unknown = new ActionType("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationVersionStatus.
    /// </summary>
    public class ApplicationVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Building for ApplicationVersionStatus
        /// </summary>
        public static readonly ApplicationVersionStatus Building = new ApplicationVersionStatus("Building");
        /// <summary>
        /// Constant Failed for ApplicationVersionStatus
        /// </summary>
        public static readonly ApplicationVersionStatus Failed = new ApplicationVersionStatus("Failed");
        /// <summary>
        /// Constant Processed for ApplicationVersionStatus
        /// </summary>
        public static readonly ApplicationVersionStatus Processed = new ApplicationVersionStatus("Processed");
        /// <summary>
        /// Constant Processing for ApplicationVersionStatus
        /// </summary>
        public static readonly ApplicationVersionStatus Processing = new ApplicationVersionStatus("Processing");
        /// <summary>
        /// Constant Unprocessed for ApplicationVersionStatus
        /// </summary>
        public static readonly ApplicationVersionStatus Unprocessed = new ApplicationVersionStatus("Unprocessed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationVersionStatus FindValue(string value)
        {
            return FindValue<ApplicationVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

        /// <summary>
        /// Constant BUILD_GENERAL1_LARGE for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_LARGE = new ComputeType("BUILD_GENERAL1_LARGE");
        /// <summary>
        /// Constant BUILD_GENERAL1_MEDIUM for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_MEDIUM = new ComputeType("BUILD_GENERAL1_MEDIUM");
        /// <summary>
        /// Constant BUILD_GENERAL1_SMALL for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_SMALL = new ComputeType("BUILD_GENERAL1_SMALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeType FindValue(string value)
        {
            return FindValue<ComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationDeploymentStatus.
    /// </summary>
    public class ConfigurationDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deployed for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Deployed = new ConfigurationDeploymentStatus("deployed");
        /// <summary>
        /// Constant Failed for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Failed = new ConfigurationDeploymentStatus("failed");
        /// <summary>
        /// Constant Pending for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Pending = new ConfigurationDeploymentStatus("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationDeploymentStatus FindValue(string value)
        {
            return FindValue<ConfigurationDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationOptionValueType.
    /// </summary>
    public class ConfigurationOptionValueType : ConstantClass
    {

        /// <summary>
        /// Constant List for ConfigurationOptionValueType
        /// </summary>
        public static readonly ConfigurationOptionValueType List = new ConfigurationOptionValueType("List");
        /// <summary>
        /// Constant Scalar for ConfigurationOptionValueType
        /// </summary>
        public static readonly ConfigurationOptionValueType Scalar = new ConfigurationOptionValueType("Scalar");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationOptionValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationOptionValueType FindValue(string value)
        {
            return FindValue<ConfigurationOptionValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationOptionValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealth.
    /// </summary>
    public class EnvironmentHealth : ConstantClass
    {

        /// <summary>
        /// Constant Green for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Green = new EnvironmentHealth("Green");
        /// <summary>
        /// Constant Grey for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Grey = new EnvironmentHealth("Grey");
        /// <summary>
        /// Constant Red for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Red = new EnvironmentHealth("Red");
        /// <summary>
        /// Constant Yellow for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Yellow = new EnvironmentHealth("Yellow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealth FindValue(string value)
        {
            return FindValue<EnvironmentHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealthAttribute.
    /// </summary>
    public class EnvironmentHealthAttribute : ConstantClass
    {

        /// <summary>
        /// Constant All for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute All = new EnvironmentHealthAttribute("All");
        /// <summary>
        /// Constant ApplicationMetrics for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute ApplicationMetrics = new EnvironmentHealthAttribute("ApplicationMetrics");
        /// <summary>
        /// Constant Causes for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Causes = new EnvironmentHealthAttribute("Causes");
        /// <summary>
        /// Constant Color for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Color = new EnvironmentHealthAttribute("Color");
        /// <summary>
        /// Constant HealthStatus for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute HealthStatus = new EnvironmentHealthAttribute("HealthStatus");
        /// <summary>
        /// Constant InstancesHealth for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute InstancesHealth = new EnvironmentHealthAttribute("InstancesHealth");
        /// <summary>
        /// Constant RefreshedAt for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute RefreshedAt = new EnvironmentHealthAttribute("RefreshedAt");
        /// <summary>
        /// Constant Status for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Status = new EnvironmentHealthAttribute("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentHealthAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealthAttribute FindValue(string value)
        {
            return FindValue<EnvironmentHealthAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentHealthAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealthStatus.
    /// </summary>
    public class EnvironmentHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant Degraded for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Degraded = new EnvironmentHealthStatus("Degraded");
        /// <summary>
        /// Constant Info for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Info = new EnvironmentHealthStatus("Info");
        /// <summary>
        /// Constant NoData for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus NoData = new EnvironmentHealthStatus("NoData");
        /// <summary>
        /// Constant Ok for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Ok = new EnvironmentHealthStatus("Ok");
        /// <summary>
        /// Constant Pending for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Pending = new EnvironmentHealthStatus("Pending");
        /// <summary>
        /// Constant Severe for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Severe = new EnvironmentHealthStatus("Severe");
        /// <summary>
        /// Constant Suspended for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Suspended = new EnvironmentHealthStatus("Suspended");
        /// <summary>
        /// Constant Unknown for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Unknown = new EnvironmentHealthStatus("Unknown");
        /// <summary>
        /// Constant Warning for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Warning = new EnvironmentHealthStatus("Warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealthStatus FindValue(string value)
        {
            return FindValue<EnvironmentHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentInfoType.
    /// </summary>
    public class EnvironmentInfoType : ConstantClass
    {

        /// <summary>
        /// Constant Bundle for EnvironmentInfoType
        /// </summary>
        public static readonly EnvironmentInfoType Bundle = new EnvironmentInfoType("bundle");
        /// <summary>
        /// Constant Tail for EnvironmentInfoType
        /// </summary>
        public static readonly EnvironmentInfoType Tail = new EnvironmentInfoType("tail");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentInfoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentInfoType FindValue(string value)
        {
            return FindValue<EnvironmentInfoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentInfoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Aborting for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Aborting = new EnvironmentStatus("Aborting");
        /// <summary>
        /// Constant Launching for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Launching = new EnvironmentStatus("Launching");
        /// <summary>
        /// Constant LinkingFrom for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus LinkingFrom = new EnvironmentStatus("LinkingFrom");
        /// <summary>
        /// Constant LinkingTo for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus LinkingTo = new EnvironmentStatus("LinkingTo");
        /// <summary>
        /// Constant Ready for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Ready = new EnvironmentStatus("Ready");
        /// <summary>
        /// Constant Terminated for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Terminated = new EnvironmentStatus("Terminated");
        /// <summary>
        /// Constant Terminating for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Terminating = new EnvironmentStatus("Terminating");
        /// <summary>
        /// Constant Updating for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Updating = new EnvironmentStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSeverity.
    /// </summary>
    public class EventSeverity : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for EventSeverity
        /// </summary>
        public static readonly EventSeverity DEBUG = new EventSeverity("DEBUG");
        /// <summary>
        /// Constant ERROR for EventSeverity
        /// </summary>
        public static readonly EventSeverity ERROR = new EventSeverity("ERROR");
        /// <summary>
        /// Constant FATAL for EventSeverity
        /// </summary>
        public static readonly EventSeverity FATAL = new EventSeverity("FATAL");
        /// <summary>
        /// Constant INFO for EventSeverity
        /// </summary>
        public static readonly EventSeverity INFO = new EventSeverity("INFO");
        /// <summary>
        /// Constant TRACE for EventSeverity
        /// </summary>
        public static readonly EventSeverity TRACE = new EventSeverity("TRACE");
        /// <summary>
        /// Constant WARN for EventSeverity
        /// </summary>
        public static readonly EventSeverity WARN = new EventSeverity("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSeverity FindValue(string value)
        {
            return FindValue<EventSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureType.
    /// </summary>
    public class FailureType : ConstantClass
    {

        /// <summary>
        /// Constant CancellationFailed for FailureType
        /// </summary>
        public static readonly FailureType CancellationFailed = new FailureType("CancellationFailed");
        /// <summary>
        /// Constant InternalFailure for FailureType
        /// </summary>
        public static readonly FailureType InternalFailure = new FailureType("InternalFailure");
        /// <summary>
        /// Constant InvalidEnvironmentState for FailureType
        /// </summary>
        public static readonly FailureType InvalidEnvironmentState = new FailureType("InvalidEnvironmentState");
        /// <summary>
        /// Constant PermissionsError for FailureType
        /// </summary>
        public static readonly FailureType PermissionsError = new FailureType("PermissionsError");
        /// <summary>
        /// Constant RollbackFailed for FailureType
        /// </summary>
        public static readonly FailureType RollbackFailed = new FailureType("RollbackFailed");
        /// <summary>
        /// Constant RollbackSuccessful for FailureType
        /// </summary>
        public static readonly FailureType RollbackSuccessful = new FailureType("RollbackSuccessful");
        /// <summary>
        /// Constant UpdateCancelled for FailureType
        /// </summary>
        public static readonly FailureType UpdateCancelled = new FailureType("UpdateCancelled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureType FindValue(string value)
        {
            return FindValue<FailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancesHealthAttribute.
    /// </summary>
    public class InstancesHealthAttribute : ConstantClass
    {

        /// <summary>
        /// Constant All for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute All = new InstancesHealthAttribute("All");
        /// <summary>
        /// Constant ApplicationMetrics for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute ApplicationMetrics = new InstancesHealthAttribute("ApplicationMetrics");
        /// <summary>
        /// Constant AvailabilityZone for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute AvailabilityZone = new InstancesHealthAttribute("AvailabilityZone");
        /// <summary>
        /// Constant Causes for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute Causes = new InstancesHealthAttribute("Causes");
        /// <summary>
        /// Constant Color for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute Color = new InstancesHealthAttribute("Color");
        /// <summary>
        /// Constant Deployment for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute Deployment = new InstancesHealthAttribute("Deployment");
        /// <summary>
        /// Constant HealthStatus for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute HealthStatus = new InstancesHealthAttribute("HealthStatus");
        /// <summary>
        /// Constant InstanceType for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute InstanceType = new InstancesHealthAttribute("InstanceType");
        /// <summary>
        /// Constant LaunchedAt for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute LaunchedAt = new InstancesHealthAttribute("LaunchedAt");
        /// <summary>
        /// Constant RefreshedAt for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute RefreshedAt = new InstancesHealthAttribute("RefreshedAt");
        /// <summary>
        /// Constant System for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute System = new InstancesHealthAttribute("System");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstancesHealthAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancesHealthAttribute FindValue(string value)
        {
            return FindValue<InstancesHealthAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstancesHealthAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformStatus.
    /// </summary>
    public class PlatformStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for PlatformStatus
        /// </summary>
        public static readonly PlatformStatus Creating = new PlatformStatus("Creating");
        /// <summary>
        /// Constant Deleted for PlatformStatus
        /// </summary>
        public static readonly PlatformStatus Deleted = new PlatformStatus("Deleted");
        /// <summary>
        /// Constant Deleting for PlatformStatus
        /// </summary>
        public static readonly PlatformStatus Deleting = new PlatformStatus("Deleting");
        /// <summary>
        /// Constant Failed for PlatformStatus
        /// </summary>
        public static readonly PlatformStatus Failed = new PlatformStatus("Failed");
        /// <summary>
        /// Constant Ready for PlatformStatus
        /// </summary>
        public static readonly PlatformStatus Ready = new PlatformStatus("Ready");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformStatus FindValue(string value)
        {
            return FindValue<PlatformStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceRepository.
    /// </summary>
    public class SourceRepository : ConstantClass
    {

        /// <summary>
        /// Constant CodeCommit for SourceRepository
        /// </summary>
        public static readonly SourceRepository CodeCommit = new SourceRepository("CodeCommit");
        /// <summary>
        /// Constant S3 for SourceRepository
        /// </summary>
        public static readonly SourceRepository S3 = new SourceRepository("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceRepository(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceRepository FindValue(string value)
        {
            return FindValue<SourceRepository>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceRepository(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant Git for SourceType
        /// </summary>
        public static readonly SourceType Git = new SourceType("Git");
        /// <summary>
        /// Constant Zip for SourceType
        /// </summary>
        public static readonly SourceType Zip = new SourceType("Zip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationSeverity.
    /// </summary>
    public class ValidationSeverity : ConstantClass
    {

        /// <summary>
        /// Constant Error for ValidationSeverity
        /// </summary>
        public static readonly ValidationSeverity Error = new ValidationSeverity("error");
        /// <summary>
        /// Constant Warning for ValidationSeverity
        /// </summary>
        public static readonly ValidationSeverity Warning = new ValidationSeverity("warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationSeverity FindValue(string value)
        {
            return FindValue<ValidationSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationSeverity(string value)
        {
            return FindValue(value);
        }
    }

}