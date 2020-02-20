/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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