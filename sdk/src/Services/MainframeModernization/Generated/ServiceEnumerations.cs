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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MainframeModernization
{

    /// <summary>
    /// Constants used for properties of type ApplicationDeploymentLifecycle.
    /// </summary>
    public class ApplicationDeploymentLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Deployed for ApplicationDeploymentLifecycle
        /// </summary>
        public static readonly ApplicationDeploymentLifecycle Deployed = new ApplicationDeploymentLifecycle("Deployed");
        /// <summary>
        /// Constant Deploying for ApplicationDeploymentLifecycle
        /// </summary>
        public static readonly ApplicationDeploymentLifecycle Deploying = new ApplicationDeploymentLifecycle("Deploying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationDeploymentLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationDeploymentLifecycle FindValue(string value)
        {
            return FindValue<ApplicationDeploymentLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationDeploymentLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationLifecycle.
    /// </summary>
    public class ApplicationLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Available for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Available = new ApplicationLifecycle("Available");
        /// <summary>
        /// Constant Created for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Created = new ApplicationLifecycle("Created");
        /// <summary>
        /// Constant Creating for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Creating = new ApplicationLifecycle("Creating");
        /// <summary>
        /// Constant Deleting for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Deleting = new ApplicationLifecycle("Deleting");
        /// <summary>
        /// Constant DeletingFromEnvironment for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle DeletingFromEnvironment = new ApplicationLifecycle("Deleting From Environment");
        /// <summary>
        /// Constant Failed for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Failed = new ApplicationLifecycle("Failed");
        /// <summary>
        /// Constant Ready for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Ready = new ApplicationLifecycle("Ready");
        /// <summary>
        /// Constant Running for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Running = new ApplicationLifecycle("Running");
        /// <summary>
        /// Constant Starting for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Starting = new ApplicationLifecycle("Starting");
        /// <summary>
        /// Constant Stopped for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Stopped = new ApplicationLifecycle("Stopped");
        /// <summary>
        /// Constant Stopping for ApplicationLifecycle
        /// </summary>
        public static readonly ApplicationLifecycle Stopping = new ApplicationLifecycle("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationLifecycle FindValue(string value)
        {
            return FindValue<ApplicationLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationVersionLifecycle.
    /// </summary>
    public class ApplicationVersionLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Available for ApplicationVersionLifecycle
        /// </summary>
        public static readonly ApplicationVersionLifecycle Available = new ApplicationVersionLifecycle("Available");
        /// <summary>
        /// Constant Creating for ApplicationVersionLifecycle
        /// </summary>
        public static readonly ApplicationVersionLifecycle Creating = new ApplicationVersionLifecycle("Creating");
        /// <summary>
        /// Constant Failed for ApplicationVersionLifecycle
        /// </summary>
        public static readonly ApplicationVersionLifecycle Failed = new ApplicationVersionLifecycle("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationVersionLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationVersionLifecycle FindValue(string value)
        {
            return FindValue<ApplicationVersionLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationVersionLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchJobExecutionStatus.
    /// </summary>
    public class BatchJobExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Cancelled = new BatchJobExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Cancelling = new BatchJobExecutionStatus("Cancelling");
        /// <summary>
        /// Constant Dispatching for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Dispatching = new BatchJobExecutionStatus("Dispatching");
        /// <summary>
        /// Constant Failed for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Failed = new BatchJobExecutionStatus("Failed");
        /// <summary>
        /// Constant Holding for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Holding = new BatchJobExecutionStatus("Holding");
        /// <summary>
        /// Constant Running for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Running = new BatchJobExecutionStatus("Running");
        /// <summary>
        /// Constant Submitting for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Submitting = new BatchJobExecutionStatus("Submitting");
        /// <summary>
        /// Constant Succeeded for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus Succeeded = new BatchJobExecutionStatus("Succeeded");
        /// <summary>
        /// Constant SucceededWithWarning for BatchJobExecutionStatus
        /// </summary>
        public static readonly BatchJobExecutionStatus SucceededWithWarning = new BatchJobExecutionStatus("Succeeded With Warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchJobExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchJobExecutionStatus FindValue(string value)
        {
            return FindValue<BatchJobExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchJobExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchJobType.
    /// </summary>
    public class BatchJobType : ConstantClass
    {

        /// <summary>
        /// Constant JES2 for BatchJobType
        /// </summary>
        public static readonly BatchJobType JES2 = new BatchJobType("JES2");
        /// <summary>
        /// Constant JES3 for BatchJobType
        /// </summary>
        public static readonly BatchJobType JES3 = new BatchJobType("JES3");
        /// <summary>
        /// Constant VSE for BatchJobType
        /// </summary>
        public static readonly BatchJobType VSE = new BatchJobType("VSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchJobType FindValue(string value)
        {
            return FindValue<BatchJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSetTaskLifecycle.
    /// </summary>
    public class DataSetTaskLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DataSetTaskLifecycle
        /// </summary>
        public static readonly DataSetTaskLifecycle Completed = new DataSetTaskLifecycle("Completed");
        /// <summary>
        /// Constant Creating for DataSetTaskLifecycle
        /// </summary>
        public static readonly DataSetTaskLifecycle Creating = new DataSetTaskLifecycle("Creating");
        /// <summary>
        /// Constant Running for DataSetTaskLifecycle
        /// </summary>
        public static readonly DataSetTaskLifecycle Running = new DataSetTaskLifecycle("Running");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetTaskLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetTaskLifecycle FindValue(string value)
        {
            return FindValue<DataSetTaskLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetTaskLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentLifecycle.
    /// </summary>
    public class DeploymentLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Deploying for DeploymentLifecycle
        /// </summary>
        public static readonly DeploymentLifecycle Deploying = new DeploymentLifecycle("Deploying");
        /// <summary>
        /// Constant Failed for DeploymentLifecycle
        /// </summary>
        public static readonly DeploymentLifecycle Failed = new DeploymentLifecycle("Failed");
        /// <summary>
        /// Constant Succeeded for DeploymentLifecycle
        /// </summary>
        public static readonly DeploymentLifecycle Succeeded = new DeploymentLifecycle("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentLifecycle FindValue(string value)
        {
            return FindValue<DeploymentLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngineType.
    /// </summary>
    public class EngineType : ConstantClass
    {

        /// <summary>
        /// Constant Bluage for EngineType
        /// </summary>
        public static readonly EngineType Bluage = new EngineType("bluage");
        /// <summary>
        /// Constant Microfocus for EngineType
        /// </summary>
        public static readonly EngineType Microfocus = new EngineType("microfocus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngineType FindValue(string value)
        {
            return FindValue<EngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentLifecycle.
    /// </summary>
    public class EnvironmentLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Available for EnvironmentLifecycle
        /// </summary>
        public static readonly EnvironmentLifecycle Available = new EnvironmentLifecycle("Available");
        /// <summary>
        /// Constant Creating for EnvironmentLifecycle
        /// </summary>
        public static readonly EnvironmentLifecycle Creating = new EnvironmentLifecycle("Creating");
        /// <summary>
        /// Constant Deleting for EnvironmentLifecycle
        /// </summary>
        public static readonly EnvironmentLifecycle Deleting = new EnvironmentLifecycle("Deleting");
        /// <summary>
        /// Constant Failed for EnvironmentLifecycle
        /// </summary>
        public static readonly EnvironmentLifecycle Failed = new EnvironmentLifecycle("Failed");
        /// <summary>
        /// Constant Updating for EnvironmentLifecycle
        /// </summary>
        public static readonly EnvironmentLifecycle Updating = new EnvironmentLifecycle("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentLifecycle FindValue(string value)
        {
            return FindValue<EnvironmentLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentLifecycle(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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

}