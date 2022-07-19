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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SagemakerEdgeManager
{

    /// <summary>
    /// Constants used for properties of type ChecksumType.
    /// </summary>
    public class ChecksumType : ConstantClass
    {

        /// <summary>
        /// Constant SHA1 for ChecksumType
        /// </summary>
        public static readonly ChecksumType SHA1 = new ChecksumType("SHA1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumType FindValue(string value)
        {
            return FindValue<ChecksumType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAIL = new DeploymentStatus("FAIL");
        /// <summary>
        /// Constant SUCCESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus SUCCESS = new DeploymentStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant Model for DeploymentType
        /// </summary>
        public static readonly DeploymentType Model = new DeploymentType("Model");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureHandlingPolicy.
    /// </summary>
    public class FailureHandlingPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOTHING for FailureHandlingPolicy
        /// </summary>
        public static readonly FailureHandlingPolicy DO_NOTHING = new FailureHandlingPolicy("DO_NOTHING");
        /// <summary>
        /// Constant ROLLBACK_ON_FAILURE for FailureHandlingPolicy
        /// </summary>
        public static readonly FailureHandlingPolicy ROLLBACK_ON_FAILURE = new FailureHandlingPolicy("ROLLBACK_ON_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureHandlingPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureHandlingPolicy FindValue(string value)
        {
            return FindValue<FailureHandlingPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureHandlingPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelState.
    /// </summary>
    public class ModelState : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOY for ModelState
        /// </summary>
        public static readonly ModelState DEPLOY = new ModelState("DEPLOY");
        /// <summary>
        /// Constant UNDEPLOY for ModelState
        /// </summary>
        public static readonly ModelState UNDEPLOY = new ModelState("UNDEPLOY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelState FindValue(string value)
        {
            return FindValue<ModelState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelState(string value)
        {
            return FindValue(value);
        }
    }

}