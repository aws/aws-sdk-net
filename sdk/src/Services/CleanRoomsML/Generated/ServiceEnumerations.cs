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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CleanRoomsML
{

    /// <summary>
    /// Constants used for properties of type AudienceExportJobStatus.
    /// </summary>
    public class AudienceExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AudienceExportJobStatus
        /// </summary>
        public static readonly AudienceExportJobStatus ACTIVE = new AudienceExportJobStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AudienceExportJobStatus
        /// </summary>
        public static readonly AudienceExportJobStatus CREATE_FAILED = new AudienceExportJobStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for AudienceExportJobStatus
        /// </summary>
        public static readonly AudienceExportJobStatus CREATE_IN_PROGRESS = new AudienceExportJobStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for AudienceExportJobStatus
        /// </summary>
        public static readonly AudienceExportJobStatus CREATE_PENDING = new AudienceExportJobStatus("CREATE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudienceExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudienceExportJobStatus FindValue(string value)
        {
            return FindValue<AudienceExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudienceExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudienceGenerationJobStatus.
    /// </summary>
    public class AudienceGenerationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus ACTIVE = new AudienceGenerationJobStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus CREATE_FAILED = new AudienceGenerationJobStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus CREATE_IN_PROGRESS = new AudienceGenerationJobStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus CREATE_PENDING = new AudienceGenerationJobStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_FAILED for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus DELETE_FAILED = new AudienceGenerationJobStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus DELETE_IN_PROGRESS = new AudienceGenerationJobStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for AudienceGenerationJobStatus
        /// </summary>
        public static readonly AudienceGenerationJobStatus DELETE_PENDING = new AudienceGenerationJobStatus("DELETE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudienceGenerationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudienceGenerationJobStatus FindValue(string value)
        {
            return FindValue<AudienceGenerationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudienceGenerationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudienceModelStatus.
    /// </summary>
    public class AudienceModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus ACTIVE = new AudienceModelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus CREATE_FAILED = new AudienceModelStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus CREATE_IN_PROGRESS = new AudienceModelStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus CREATE_PENDING = new AudienceModelStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_FAILED for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus DELETE_FAILED = new AudienceModelStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus DELETE_IN_PROGRESS = new AudienceModelStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for AudienceModelStatus
        /// </summary>
        public static readonly AudienceModelStatus DELETE_PENDING = new AudienceModelStatus("DELETE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudienceModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudienceModelStatus FindValue(string value)
        {
            return FindValue<AudienceModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudienceModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudienceSizeType.
    /// </summary>
    public class AudienceSizeType : ConstantClass
    {

        /// <summary>
        /// Constant ABSOLUTE for AudienceSizeType
        /// </summary>
        public static readonly AudienceSizeType ABSOLUTE = new AudienceSizeType("ABSOLUTE");
        /// <summary>
        /// Constant PERCENTAGE for AudienceSizeType
        /// </summary>
        public static readonly AudienceSizeType PERCENTAGE = new AudienceSizeType("PERCENTAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudienceSizeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudienceSizeType FindValue(string value)
        {
            return FindValue<AudienceSizeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudienceSizeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnType.
    /// </summary>
    public class ColumnType : ConstantClass
    {

        /// <summary>
        /// Constant CATEGORICAL_FEATURE for ColumnType
        /// </summary>
        public static readonly ColumnType CATEGORICAL_FEATURE = new ColumnType("CATEGORICAL_FEATURE");
        /// <summary>
        /// Constant ITEM_ID for ColumnType
        /// </summary>
        public static readonly ColumnType ITEM_ID = new ColumnType("ITEM_ID");
        /// <summary>
        /// Constant NUMERICAL_FEATURE for ColumnType
        /// </summary>
        public static readonly ColumnType NUMERICAL_FEATURE = new ColumnType("NUMERICAL_FEATURE");
        /// <summary>
        /// Constant TIMESTAMP for ColumnType
        /// </summary>
        public static readonly ColumnType TIMESTAMP = new ColumnType("TIMESTAMP");
        /// <summary>
        /// Constant USER_ID for ColumnType
        /// </summary>
        public static readonly ColumnType USER_ID = new ColumnType("USER_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnType FindValue(string value)
        {
            return FindValue<ColumnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfiguredAudienceModelStatus.
    /// </summary>
    public class ConfiguredAudienceModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConfiguredAudienceModelStatus
        /// </summary>
        public static readonly ConfiguredAudienceModelStatus ACTIVE = new ConfiguredAudienceModelStatus("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfiguredAudienceModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfiguredAudienceModelStatus FindValue(string value)
        {
            return FindValue<ConfiguredAudienceModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfiguredAudienceModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetType.
    /// </summary>
    public class DatasetType : ConstantClass
    {

        /// <summary>
        /// Constant INTERACTIONS for DatasetType
        /// </summary>
        public static readonly DatasetType INTERACTIONS = new DatasetType("INTERACTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetType FindValue(string value)
        {
            return FindValue<DatasetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyExistenceCondition.
    /// </summary>
    public class PolicyExistenceCondition : ConstantClass
    {

        /// <summary>
        /// Constant POLICY_MUST_EXIST for PolicyExistenceCondition
        /// </summary>
        public static readonly PolicyExistenceCondition POLICY_MUST_EXIST = new PolicyExistenceCondition("POLICY_MUST_EXIST");
        /// <summary>
        /// Constant POLICY_MUST_NOT_EXIST for PolicyExistenceCondition
        /// </summary>
        public static readonly PolicyExistenceCondition POLICY_MUST_NOT_EXIST = new PolicyExistenceCondition("POLICY_MUST_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyExistenceCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyExistenceCondition FindValue(string value)
        {
            return FindValue<PolicyExistenceCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyExistenceCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharedAudienceMetrics.
    /// </summary>
    public class SharedAudienceMetrics : ConstantClass
    {

        /// <summary>
        /// Constant ALL for SharedAudienceMetrics
        /// </summary>
        public static readonly SharedAudienceMetrics ALL = new SharedAudienceMetrics("ALL");
        /// <summary>
        /// Constant NONE for SharedAudienceMetrics
        /// </summary>
        public static readonly SharedAudienceMetrics NONE = new SharedAudienceMetrics("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharedAudienceMetrics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharedAudienceMetrics FindValue(string value)
        {
            return FindValue<SharedAudienceMetrics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharedAudienceMetrics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagOnCreatePolicy.
    /// </summary>
    public class TagOnCreatePolicy : ConstantClass
    {

        /// <summary>
        /// Constant FROM_PARENT_RESOURCE for TagOnCreatePolicy
        /// </summary>
        public static readonly TagOnCreatePolicy FROM_PARENT_RESOURCE = new TagOnCreatePolicy("FROM_PARENT_RESOURCE");
        /// <summary>
        /// Constant NONE for TagOnCreatePolicy
        /// </summary>
        public static readonly TagOnCreatePolicy NONE = new TagOnCreatePolicy("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagOnCreatePolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagOnCreatePolicy FindValue(string value)
        {
            return FindValue<TagOnCreatePolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagOnCreatePolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingDatasetStatus.
    /// </summary>
    public class TrainingDatasetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrainingDatasetStatus
        /// </summary>
        public static readonly TrainingDatasetStatus ACTIVE = new TrainingDatasetStatus("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingDatasetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingDatasetStatus FindValue(string value)
        {
            return FindValue<TrainingDatasetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingDatasetStatus(string value)
        {
            return FindValue(value);
        }
    }

}