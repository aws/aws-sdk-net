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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConnectCampaignService
{

    /// <summary>
    /// Constants used for properties of type CampaignState.
    /// </summary>
    public class CampaignState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for CampaignState
        /// </summary>
        public static readonly CampaignState Failed = new CampaignState("Failed");
        /// <summary>
        /// Constant Initialized for CampaignState
        /// </summary>
        public static readonly CampaignState Initialized = new CampaignState("Initialized");
        /// <summary>
        /// Constant Paused for CampaignState
        /// </summary>
        public static readonly CampaignState Paused = new CampaignState("Paused");
        /// <summary>
        /// Constant Running for CampaignState
        /// </summary>
        public static readonly CampaignState Running = new CampaignState("Running");
        /// <summary>
        /// Constant Stopped for CampaignState
        /// </summary>
        public static readonly CampaignState Stopped = new CampaignState("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CampaignState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignState FindValue(string value)
        {
            return FindValue<CampaignState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureCode.
    /// </summary>
    public class FailureCode : ConstantClass
    {

        /// <summary>
        /// Constant InvalidInput for FailureCode
        /// </summary>
        public static readonly FailureCode InvalidInput = new FailureCode("InvalidInput");
        /// <summary>
        /// Constant RequestThrottled for FailureCode
        /// </summary>
        public static readonly FailureCode RequestThrottled = new FailureCode("RequestThrottled");
        /// <summary>
        /// Constant UnknownError for FailureCode
        /// </summary>
        public static readonly FailureCode UnknownError = new FailureCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureCode FindValue(string value)
        {
            return FindValue<FailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GetCampaignStateBatchFailureCode.
    /// </summary>
    public class GetCampaignStateBatchFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant ResourceNotFound for GetCampaignStateBatchFailureCode
        /// </summary>
        public static readonly GetCampaignStateBatchFailureCode ResourceNotFound = new GetCampaignStateBatchFailureCode("ResourceNotFound");
        /// <summary>
        /// Constant UnknownError for GetCampaignStateBatchFailureCode
        /// </summary>
        public static readonly GetCampaignStateBatchFailureCode UnknownError = new GetCampaignStateBatchFailureCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetCampaignStateBatchFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetCampaignStateBatchFailureCode FindValue(string value)
        {
            return FindValue<GetCampaignStateBatchFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetCampaignStateBatchFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceIdFilterOperator.
    /// </summary>
    public class InstanceIdFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Eq for InstanceIdFilterOperator
        /// </summary>
        public static readonly InstanceIdFilterOperator Eq = new InstanceIdFilterOperator("Eq");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceIdFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceIdFilterOperator FindValue(string value)
        {
            return FindValue<InstanceIdFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceIdFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceOnboardingJobFailureCode.
    /// </summary>
    public class InstanceOnboardingJobFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_BRIDGE_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode EVENT_BRIDGE_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("EVENT_BRIDGE_ACCESS_DENIED");
        /// <summary>
        /// Constant EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED = new InstanceOnboardingJobFailureCode("EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant IAM_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode IAM_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("IAM_ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_FAILURE for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode INTERNAL_FAILURE = new InstanceOnboardingJobFailureCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant KMS_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode KMS_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("KMS_ACCESS_DENIED");
        /// <summary>
        /// Constant KMS_KEY_NOT_FOUND for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode KMS_KEY_NOT_FOUND = new InstanceOnboardingJobFailureCode("KMS_KEY_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceOnboardingJobFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceOnboardingJobFailureCode FindValue(string value)
        {
            return FindValue<InstanceOnboardingJobFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceOnboardingJobFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceOnboardingJobStatusCode.
    /// </summary>
    public class InstanceOnboardingJobStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode FAILED = new InstanceOnboardingJobStatusCode("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode IN_PROGRESS = new InstanceOnboardingJobStatusCode("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode SUCCEEDED = new InstanceOnboardingJobStatusCode("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceOnboardingJobStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceOnboardingJobStatusCode FindValue(string value)
        {
            return FindValue<InstanceOnboardingJobStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceOnboardingJobStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}