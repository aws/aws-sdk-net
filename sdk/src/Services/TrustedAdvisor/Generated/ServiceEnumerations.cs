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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TrustedAdvisor
{

    /// <summary>
    /// Constants used for properties of type ExclusionStatus.
    /// </summary>
    public class ExclusionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Excluded for ExclusionStatus
        /// </summary>
        public static readonly ExclusionStatus Excluded = new ExclusionStatus("excluded");
        /// <summary>
        /// Constant Included for ExclusionStatus
        /// </summary>
        public static readonly ExclusionStatus Included = new ExclusionStatus("included");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExclusionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExclusionStatus FindValue(string value)
        {
            return FindValue<ExclusionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExclusionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationLanguage.
    /// </summary>
    public class RecommendationLanguage : ConstantClass
    {

        /// <summary>
        /// Constant De for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage De = new RecommendationLanguage("de");
        /// <summary>
        /// Constant En for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage En = new RecommendationLanguage("en");
        /// <summary>
        /// Constant Es for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Es = new RecommendationLanguage("es");
        /// <summary>
        /// Constant Fr for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Fr = new RecommendationLanguage("fr");
        /// <summary>
        /// Constant Id for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Id = new RecommendationLanguage("id");
        /// <summary>
        /// Constant It for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage It = new RecommendationLanguage("it");
        /// <summary>
        /// Constant Ja for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Ja = new RecommendationLanguage("ja");
        /// <summary>
        /// Constant Ko for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Ko = new RecommendationLanguage("ko");
        /// <summary>
        /// Constant Pt_BR for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Pt_BR = new RecommendationLanguage("pt_BR");
        /// <summary>
        /// Constant Zh for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Zh = new RecommendationLanguage("zh");
        /// <summary>
        /// Constant Zh_TW for RecommendationLanguage
        /// </summary>
        public static readonly RecommendationLanguage Zh_TW = new RecommendationLanguage("zh_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationLanguage FindValue(string value)
        {
            return FindValue<RecommendationLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationLifecycleStage.
    /// </summary>
    public class RecommendationLifecycleStage : ConstantClass
    {

        /// <summary>
        /// Constant Dismissed for RecommendationLifecycleStage
        /// </summary>
        public static readonly RecommendationLifecycleStage Dismissed = new RecommendationLifecycleStage("dismissed");
        /// <summary>
        /// Constant In_progress for RecommendationLifecycleStage
        /// </summary>
        public static readonly RecommendationLifecycleStage In_progress = new RecommendationLifecycleStage("in_progress");
        /// <summary>
        /// Constant Pending_response for RecommendationLifecycleStage
        /// </summary>
        public static readonly RecommendationLifecycleStage Pending_response = new RecommendationLifecycleStage("pending_response");
        /// <summary>
        /// Constant Resolved for RecommendationLifecycleStage
        /// </summary>
        public static readonly RecommendationLifecycleStage Resolved = new RecommendationLifecycleStage("resolved");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationLifecycleStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationLifecycleStage FindValue(string value)
        {
            return FindValue<RecommendationLifecycleStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationLifecycleStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationPillar.
    /// </summary>
    public class RecommendationPillar : ConstantClass
    {

        /// <summary>
        /// Constant Cost_optimizing for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Cost_optimizing = new RecommendationPillar("cost_optimizing");
        /// <summary>
        /// Constant Fault_tolerance for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Fault_tolerance = new RecommendationPillar("fault_tolerance");
        /// <summary>
        /// Constant Operational_excellence for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Operational_excellence = new RecommendationPillar("operational_excellence");
        /// <summary>
        /// Constant Performance for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Performance = new RecommendationPillar("performance");
        /// <summary>
        /// Constant Security for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Security = new RecommendationPillar("security");
        /// <summary>
        /// Constant Service_limits for RecommendationPillar
        /// </summary>
        public static readonly RecommendationPillar Service_limits = new RecommendationPillar("service_limits");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationPillar(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationPillar FindValue(string value)
        {
            return FindValue<RecommendationPillar>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationPillar(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationSource.
    /// </summary>
    public class RecommendationSource : ConstantClass
    {

        /// <summary>
        /// Constant Aws_config for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Aws_config = new RecommendationSource("aws_config");
        /// <summary>
        /// Constant Compute_optimizer for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Compute_optimizer = new RecommendationSource("compute_optimizer");
        /// <summary>
        /// Constant Cost_explorer for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Cost_explorer = new RecommendationSource("cost_explorer");
        /// <summary>
        /// Constant Lse for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Lse = new RecommendationSource("lse");
        /// <summary>
        /// Constant Manual for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Manual = new RecommendationSource("manual");
        /// <summary>
        /// Constant Pse for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Pse = new RecommendationSource("pse");
        /// <summary>
        /// Constant Rds for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Rds = new RecommendationSource("rds");
        /// <summary>
        /// Constant Resilience for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Resilience = new RecommendationSource("resilience");
        /// <summary>
        /// Constant Resilience_hub for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Resilience_hub = new RecommendationSource("resilience_hub");
        /// <summary>
        /// Constant Security_hub for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Security_hub = new RecommendationSource("security_hub");
        /// <summary>
        /// Constant Stir for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Stir = new RecommendationSource("stir");
        /// <summary>
        /// Constant Ta_check for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Ta_check = new RecommendationSource("ta_check");
        /// <summary>
        /// Constant Well_architected for RecommendationSource
        /// </summary>
        public static readonly RecommendationSource Well_architected = new RecommendationSource("well_architected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationSource FindValue(string value)
        {
            return FindValue<RecommendationSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationStatus.
    /// </summary>
    public class RecommendationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Error = new RecommendationStatus("error");
        /// <summary>
        /// Constant Ok for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Ok = new RecommendationStatus("ok");
        /// <summary>
        /// Constant Warning for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Warning = new RecommendationStatus("warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationStatus FindValue(string value)
        {
            return FindValue<RecommendationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant Priority for RecommendationType
        /// </summary>
        public static readonly RecommendationType Priority = new RecommendationType("priority");
        /// <summary>
        /// Constant Standard for RecommendationType
        /// </summary>
        public static readonly RecommendationType Standard = new RecommendationType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus Error = new ResourceStatus("error");
        /// <summary>
        /// Constant Ok for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus Ok = new ResourceStatus("ok");
        /// <summary>
        /// Constant Warning for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus Warning = new ResourceStatus("warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateRecommendationLifecycleStage.
    /// </summary>
    public class UpdateRecommendationLifecycleStage : ConstantClass
    {

        /// <summary>
        /// Constant Dismissed for UpdateRecommendationLifecycleStage
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStage Dismissed = new UpdateRecommendationLifecycleStage("dismissed");
        /// <summary>
        /// Constant In_progress for UpdateRecommendationLifecycleStage
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStage In_progress = new UpdateRecommendationLifecycleStage("in_progress");
        /// <summary>
        /// Constant Pending_response for UpdateRecommendationLifecycleStage
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStage Pending_response = new UpdateRecommendationLifecycleStage("pending_response");
        /// <summary>
        /// Constant Resolved for UpdateRecommendationLifecycleStage
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStage Resolved = new UpdateRecommendationLifecycleStage("resolved");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateRecommendationLifecycleStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateRecommendationLifecycleStage FindValue(string value)
        {
            return FindValue<UpdateRecommendationLifecycleStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateRecommendationLifecycleStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateRecommendationLifecycleStageReasonCode.
    /// </summary>
    public class UpdateRecommendationLifecycleStageReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant Low_priority for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Low_priority = new UpdateRecommendationLifecycleStageReasonCode("low_priority");
        /// <summary>
        /// Constant Non_critical_account for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Non_critical_account = new UpdateRecommendationLifecycleStageReasonCode("non_critical_account");
        /// <summary>
        /// Constant Not_applicable for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Not_applicable = new UpdateRecommendationLifecycleStageReasonCode("not_applicable");
        /// <summary>
        /// Constant Other for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Other = new UpdateRecommendationLifecycleStageReasonCode("other");
        /// <summary>
        /// Constant Other_methods_available for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Other_methods_available = new UpdateRecommendationLifecycleStageReasonCode("other_methods_available");
        /// <summary>
        /// Constant Temporary_account for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Temporary_account = new UpdateRecommendationLifecycleStageReasonCode("temporary_account");
        /// <summary>
        /// Constant Valid_business_case for UpdateRecommendationLifecycleStageReasonCode
        /// </summary>
        public static readonly UpdateRecommendationLifecycleStageReasonCode Valid_business_case = new UpdateRecommendationLifecycleStageReasonCode("valid_business_case");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateRecommendationLifecycleStageReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateRecommendationLifecycleStageReasonCode FindValue(string value)
        {
            return FindValue<UpdateRecommendationLifecycleStageReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateRecommendationLifecycleStageReasonCode(string value)
        {
            return FindValue(value);
        }
    }

}