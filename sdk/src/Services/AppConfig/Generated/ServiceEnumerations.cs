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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppConfig
{

    /// <summary>
    /// Constants used for properties of type ActionPoint.
    /// </summary>
    public class ActionPoint : ConstantClass
    {

        /// <summary>
        /// Constant AT_DEPLOYMENT_TICK for ActionPoint
        /// </summary>
        public static readonly ActionPoint AT_DEPLOYMENT_TICK = new ActionPoint("AT_DEPLOYMENT_TICK");
        /// <summary>
        /// Constant ON_DEPLOYMENT_BAKING for ActionPoint
        /// </summary>
        public static readonly ActionPoint ON_DEPLOYMENT_BAKING = new ActionPoint("ON_DEPLOYMENT_BAKING");
        /// <summary>
        /// Constant ON_DEPLOYMENT_COMPLETE for ActionPoint
        /// </summary>
        public static readonly ActionPoint ON_DEPLOYMENT_COMPLETE = new ActionPoint("ON_DEPLOYMENT_COMPLETE");
        /// <summary>
        /// Constant ON_DEPLOYMENT_ROLLED_BACK for ActionPoint
        /// </summary>
        public static readonly ActionPoint ON_DEPLOYMENT_ROLLED_BACK = new ActionPoint("ON_DEPLOYMENT_ROLLED_BACK");
        /// <summary>
        /// Constant ON_DEPLOYMENT_START for ActionPoint
        /// </summary>
        public static readonly ActionPoint ON_DEPLOYMENT_START = new ActionPoint("ON_DEPLOYMENT_START");
        /// <summary>
        /// Constant ON_DEPLOYMENT_STEP for ActionPoint
        /// </summary>
        public static readonly ActionPoint ON_DEPLOYMENT_STEP = new ActionPoint("ON_DEPLOYMENT_STEP");
        /// <summary>
        /// Constant PRE_CREATE_HOSTED_CONFIGURATION_VERSION for ActionPoint
        /// </summary>
        public static readonly ActionPoint PRE_CREATE_HOSTED_CONFIGURATION_VERSION = new ActionPoint("PRE_CREATE_HOSTED_CONFIGURATION_VERSION");
        /// <summary>
        /// Constant PRE_START_DEPLOYMENT for ActionPoint
        /// </summary>
        public static readonly ActionPoint PRE_START_DEPLOYMENT = new ActionPoint("PRE_START_DEPLOYMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionPoint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionPoint FindValue(string value)
        {
            return FindValue<ActionPoint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionPoint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BadRequestReason.
    /// </summary>
    public class BadRequestReason : ConstantClass
    {

        /// <summary>
        /// Constant InvalidConfiguration for BadRequestReason
        /// </summary>
        public static readonly BadRequestReason InvalidConfiguration = new BadRequestReason("InvalidConfiguration");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BadRequestReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BadRequestReason FindValue(string value)
        {
            return FindValue<BadRequestReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BadRequestReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BytesMeasure.
    /// </summary>
    public class BytesMeasure : ConstantClass
    {

        /// <summary>
        /// Constant KILOBYTES for BytesMeasure
        /// </summary>
        public static readonly BytesMeasure KILOBYTES = new BytesMeasure("KILOBYTES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BytesMeasure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BytesMeasure FindValue(string value)
        {
            return FindValue<BytesMeasure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BytesMeasure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletionProtectionCheck.
    /// </summary>
    public class DeletionProtectionCheck : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_DEFAULT for DeletionProtectionCheck
        /// </summary>
        public static readonly DeletionProtectionCheck ACCOUNT_DEFAULT = new DeletionProtectionCheck("ACCOUNT_DEFAULT");
        /// <summary>
        /// Constant APPLY for DeletionProtectionCheck
        /// </summary>
        public static readonly DeletionProtectionCheck APPLY = new DeletionProtectionCheck("APPLY");
        /// <summary>
        /// Constant BYPASS for DeletionProtectionCheck
        /// </summary>
        public static readonly DeletionProtectionCheck BYPASS = new DeletionProtectionCheck("BYPASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionProtectionCheck(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionProtectionCheck FindValue(string value)
        {
            return FindValue<DeletionProtectionCheck>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionProtectionCheck(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentEventType.
    /// </summary>
    public class DeploymentEventType : ConstantClass
    {

        /// <summary>
        /// Constant BAKE_TIME_STARTED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType BAKE_TIME_STARTED = new DeploymentEventType("BAKE_TIME_STARTED");
        /// <summary>
        /// Constant DEPLOYMENT_COMPLETED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType DEPLOYMENT_COMPLETED = new DeploymentEventType("DEPLOYMENT_COMPLETED");
        /// <summary>
        /// Constant DEPLOYMENT_STARTED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType DEPLOYMENT_STARTED = new DeploymentEventType("DEPLOYMENT_STARTED");
        /// <summary>
        /// Constant PERCENTAGE_UPDATED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType PERCENTAGE_UPDATED = new DeploymentEventType("PERCENTAGE_UPDATED");
        /// <summary>
        /// Constant REVERT_COMPLETED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType REVERT_COMPLETED = new DeploymentEventType("REVERT_COMPLETED");
        /// <summary>
        /// Constant ROLLBACK_COMPLETED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType ROLLBACK_COMPLETED = new DeploymentEventType("ROLLBACK_COMPLETED");
        /// <summary>
        /// Constant ROLLBACK_STARTED for DeploymentEventType
        /// </summary>
        public static readonly DeploymentEventType ROLLBACK_STARTED = new DeploymentEventType("ROLLBACK_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentEventType FindValue(string value)
        {
            return FindValue<DeploymentEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentState.
    /// </summary>
    public class DeploymentState : ConstantClass
    {

        /// <summary>
        /// Constant BAKING for DeploymentState
        /// </summary>
        public static readonly DeploymentState BAKING = new DeploymentState("BAKING");
        /// <summary>
        /// Constant COMPLETE for DeploymentState
        /// </summary>
        public static readonly DeploymentState COMPLETE = new DeploymentState("COMPLETE");
        /// <summary>
        /// Constant DEPLOYING for DeploymentState
        /// </summary>
        public static readonly DeploymentState DEPLOYING = new DeploymentState("DEPLOYING");
        /// <summary>
        /// Constant REVERTED for DeploymentState
        /// </summary>
        public static readonly DeploymentState REVERTED = new DeploymentState("REVERTED");
        /// <summary>
        /// Constant ROLLED_BACK for DeploymentState
        /// </summary>
        public static readonly DeploymentState ROLLED_BACK = new DeploymentState("ROLLED_BACK");
        /// <summary>
        /// Constant ROLLING_BACK for DeploymentState
        /// </summary>
        public static readonly DeploymentState ROLLING_BACK = new DeploymentState("ROLLING_BACK");
        /// <summary>
        /// Constant VALIDATING for DeploymentState
        /// </summary>
        public static readonly DeploymentState VALIDATING = new DeploymentState("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentState FindValue(string value)
        {
            return FindValue<DeploymentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentState.
    /// </summary>
    public class EnvironmentState : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYING for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState DEPLOYING = new EnvironmentState("DEPLOYING");
        /// <summary>
        /// Constant READY_FOR_DEPLOYMENT for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState READY_FOR_DEPLOYMENT = new EnvironmentState("READY_FOR_DEPLOYMENT");
        /// <summary>
        /// Constant REVERTED for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState REVERTED = new EnvironmentState("REVERTED");
        /// <summary>
        /// Constant ROLLED_BACK for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState ROLLED_BACK = new EnvironmentState("ROLLED_BACK");
        /// <summary>
        /// Constant ROLLING_BACK for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState ROLLING_BACK = new EnvironmentState("ROLLING_BACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentState FindValue(string value)
        {
            return FindValue<EnvironmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GrowthType.
    /// </summary>
    public class GrowthType : ConstantClass
    {

        /// <summary>
        /// Constant EXPONENTIAL for GrowthType
        /// </summary>
        public static readonly GrowthType EXPONENTIAL = new GrowthType("EXPONENTIAL");
        /// <summary>
        /// Constant LINEAR for GrowthType
        /// </summary>
        public static readonly GrowthType LINEAR = new GrowthType("LINEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GrowthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GrowthType FindValue(string value)
        {
            return FindValue<GrowthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GrowthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicateTo.
    /// </summary>
    public class ReplicateTo : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ReplicateTo
        /// </summary>
        public static readonly ReplicateTo NONE = new ReplicateTo("NONE");
        /// <summary>
        /// Constant SSM_DOCUMENT for ReplicateTo
        /// </summary>
        public static readonly ReplicateTo SSM_DOCUMENT = new ReplicateTo("SSM_DOCUMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicateTo(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicateTo FindValue(string value)
        {
            return FindValue<ReplicateTo>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicateTo(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggeredBy.
    /// </summary>
    public class TriggeredBy : ConstantClass
    {

        /// <summary>
        /// Constant APPCONFIG for TriggeredBy
        /// </summary>
        public static readonly TriggeredBy APPCONFIG = new TriggeredBy("APPCONFIG");
        /// <summary>
        /// Constant CLOUDWATCH_ALARM for TriggeredBy
        /// </summary>
        public static readonly TriggeredBy CLOUDWATCH_ALARM = new TriggeredBy("CLOUDWATCH_ALARM");
        /// <summary>
        /// Constant INTERNAL_ERROR for TriggeredBy
        /// </summary>
        public static readonly TriggeredBy INTERNAL_ERROR = new TriggeredBy("INTERNAL_ERROR");
        /// <summary>
        /// Constant USER for TriggeredBy
        /// </summary>
        public static readonly TriggeredBy USER = new TriggeredBy("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggeredBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggeredBy FindValue(string value)
        {
            return FindValue<TriggeredBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggeredBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidatorType.
    /// </summary>
    public class ValidatorType : ConstantClass
    {

        /// <summary>
        /// Constant JSON_SCHEMA for ValidatorType
        /// </summary>
        public static readonly ValidatorType JSON_SCHEMA = new ValidatorType("JSON_SCHEMA");
        /// <summary>
        /// Constant LAMBDA for ValidatorType
        /// </summary>
        public static readonly ValidatorType LAMBDA = new ValidatorType("LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidatorType FindValue(string value)
        {
            return FindValue<ValidatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidatorType(string value)
        {
            return FindValue(value);
        }
    }

}