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
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_PERSONALLY_IDENTIFIABLE_INFORMATION for EntityType
        /// </summary>
        public static readonly EntityType ALL_PERSONALLY_IDENTIFIABLE_INFORMATION = new EntityType("ALL_PERSONALLY_IDENTIFIABLE_INFORMATION");
        /// <summary>
        /// Constant CUSTOM for EntityType
        /// </summary>
        public static readonly EntityType CUSTOM = new EntityType("CUSTOM");
        /// <summary>
        /// Constant NUMBERS for EntityType
        /// </summary>
        public static readonly EntityType NUMBERS = new EntityType("NUMBERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceInstanceType.
    /// </summary>
    public class InferenceInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC42xlarge = new InferenceInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC44xlarge = new InferenceInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC48xlarge = new InferenceInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC4Xlarge = new InferenceInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC518xlarge = new InferenceInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC52xlarge = new InferenceInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC54xlarge = new InferenceInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC59xlarge = new InferenceInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC5Xlarge = new InferenceInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlC6i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i12xlarge = new InferenceInstanceType("ml.c6i.12xlarge");
        /// <summary>
        /// Constant MlC6i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i16xlarge = new InferenceInstanceType("ml.c6i.16xlarge");
        /// <summary>
        /// Constant MlC6i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i24xlarge = new InferenceInstanceType("ml.c6i.24xlarge");
        /// <summary>
        /// Constant MlC6i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i2xlarge = new InferenceInstanceType("ml.c6i.2xlarge");
        /// <summary>
        /// Constant MlC6i32xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i32xlarge = new InferenceInstanceType("ml.c6i.32xlarge");
        /// <summary>
        /// Constant MlC6i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i4xlarge = new InferenceInstanceType("ml.c6i.4xlarge");
        /// <summary>
        /// Constant MlC6i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6i8xlarge = new InferenceInstanceType("ml.c6i.8xlarge");
        /// <summary>
        /// Constant MlC6iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6iLarge = new InferenceInstanceType("ml.c6i.large");
        /// <summary>
        /// Constant MlC6iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC6iXlarge = new InferenceInstanceType("ml.c6i.xlarge");
        /// <summary>
        /// Constant MlC7i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i12xlarge = new InferenceInstanceType("ml.c7i.12xlarge");
        /// <summary>
        /// Constant MlC7i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i16xlarge = new InferenceInstanceType("ml.c7i.16xlarge");
        /// <summary>
        /// Constant MlC7i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i24xlarge = new InferenceInstanceType("ml.c7i.24xlarge");
        /// <summary>
        /// Constant MlC7i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i2xlarge = new InferenceInstanceType("ml.c7i.2xlarge");
        /// <summary>
        /// Constant MlC7i48xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i48xlarge = new InferenceInstanceType("ml.c7i.48xlarge");
        /// <summary>
        /// Constant MlC7i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i4xlarge = new InferenceInstanceType("ml.c7i.4xlarge");
        /// <summary>
        /// Constant MlC7i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7i8xlarge = new InferenceInstanceType("ml.c7i.8xlarge");
        /// <summary>
        /// Constant MlC7iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7iLarge = new InferenceInstanceType("ml.c7i.large");
        /// <summary>
        /// Constant MlC7iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlC7iXlarge = new InferenceInstanceType("ml.c7i.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dn12xlarge = new InferenceInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dn16xlarge = new InferenceInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dn2xlarge = new InferenceInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dn4xlarge = new InferenceInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dn8xlarge = new InferenceInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG4dnXlarge = new InferenceInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG512xlarge = new InferenceInstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG516xlarge = new InferenceInstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG524xlarge = new InferenceInstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG52xlarge = new InferenceInstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG548xlarge = new InferenceInstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG54xlarge = new InferenceInstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG58xlarge = new InferenceInstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlG5Xlarge = new InferenceInstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM410xlarge = new InferenceInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM416xlarge = new InferenceInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM42xlarge = new InferenceInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM44xlarge = new InferenceInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM4Xlarge = new InferenceInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM512xlarge = new InferenceInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM524xlarge = new InferenceInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM52xlarge = new InferenceInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM54xlarge = new InferenceInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM5Large = new InferenceInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM5Xlarge = new InferenceInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlM6i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i12xlarge = new InferenceInstanceType("ml.m6i.12xlarge");
        /// <summary>
        /// Constant MlM6i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i16xlarge = new InferenceInstanceType("ml.m6i.16xlarge");
        /// <summary>
        /// Constant MlM6i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i24xlarge = new InferenceInstanceType("ml.m6i.24xlarge");
        /// <summary>
        /// Constant MlM6i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i2xlarge = new InferenceInstanceType("ml.m6i.2xlarge");
        /// <summary>
        /// Constant MlM6i32xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i32xlarge = new InferenceInstanceType("ml.m6i.32xlarge");
        /// <summary>
        /// Constant MlM6i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i4xlarge = new InferenceInstanceType("ml.m6i.4xlarge");
        /// <summary>
        /// Constant MlM6i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6i8xlarge = new InferenceInstanceType("ml.m6i.8xlarge");
        /// <summary>
        /// Constant MlM6iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6iLarge = new InferenceInstanceType("ml.m6i.large");
        /// <summary>
        /// Constant MlM6iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM6iXlarge = new InferenceInstanceType("ml.m6i.xlarge");
        /// <summary>
        /// Constant MlM7i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i12xlarge = new InferenceInstanceType("ml.m7i.12xlarge");
        /// <summary>
        /// Constant MlM7i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i16xlarge = new InferenceInstanceType("ml.m7i.16xlarge");
        /// <summary>
        /// Constant MlM7i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i24xlarge = new InferenceInstanceType("ml.m7i.24xlarge");
        /// <summary>
        /// Constant MlM7i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i2xlarge = new InferenceInstanceType("ml.m7i.2xlarge");
        /// <summary>
        /// Constant MlM7i48xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i48xlarge = new InferenceInstanceType("ml.m7i.48xlarge");
        /// <summary>
        /// Constant MlM7i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i4xlarge = new InferenceInstanceType("ml.m7i.4xlarge");
        /// <summary>
        /// Constant MlM7i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7i8xlarge = new InferenceInstanceType("ml.m7i.8xlarge");
        /// <summary>
        /// Constant MlM7iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7iLarge = new InferenceInstanceType("ml.m7i.large");
        /// <summary>
        /// Constant MlM7iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlM7iXlarge = new InferenceInstanceType("ml.m7i.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP216xlarge = new InferenceInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP28xlarge = new InferenceInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP2Xlarge = new InferenceInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP316xlarge = new InferenceInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP32xlarge = new InferenceInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlP38xlarge = new InferenceInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlR6i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i12xlarge = new InferenceInstanceType("ml.r6i.12xlarge");
        /// <summary>
        /// Constant MlR6i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i16xlarge = new InferenceInstanceType("ml.r6i.16xlarge");
        /// <summary>
        /// Constant MlR6i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i24xlarge = new InferenceInstanceType("ml.r6i.24xlarge");
        /// <summary>
        /// Constant MlR6i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i2xlarge = new InferenceInstanceType("ml.r6i.2xlarge");
        /// <summary>
        /// Constant MlR6i32xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i32xlarge = new InferenceInstanceType("ml.r6i.32xlarge");
        /// <summary>
        /// Constant MlR6i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i4xlarge = new InferenceInstanceType("ml.r6i.4xlarge");
        /// <summary>
        /// Constant MlR6i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6i8xlarge = new InferenceInstanceType("ml.r6i.8xlarge");
        /// <summary>
        /// Constant MlR6iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6iLarge = new InferenceInstanceType("ml.r6i.large");
        /// <summary>
        /// Constant MlR6iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR6iXlarge = new InferenceInstanceType("ml.r6i.xlarge");
        /// <summary>
        /// Constant MlR7i12xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i12xlarge = new InferenceInstanceType("ml.r7i.12xlarge");
        /// <summary>
        /// Constant MlR7i16xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i16xlarge = new InferenceInstanceType("ml.r7i.16xlarge");
        /// <summary>
        /// Constant MlR7i24xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i24xlarge = new InferenceInstanceType("ml.r7i.24xlarge");
        /// <summary>
        /// Constant MlR7i2xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i2xlarge = new InferenceInstanceType("ml.r7i.2xlarge");
        /// <summary>
        /// Constant MlR7i48xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i48xlarge = new InferenceInstanceType("ml.r7i.48xlarge");
        /// <summary>
        /// Constant MlR7i4xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i4xlarge = new InferenceInstanceType("ml.r7i.4xlarge");
        /// <summary>
        /// Constant MlR7i8xlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7i8xlarge = new InferenceInstanceType("ml.r7i.8xlarge");
        /// <summary>
        /// Constant MlR7iLarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7iLarge = new InferenceInstanceType("ml.r7i.large");
        /// <summary>
        /// Constant MlR7iXlarge for InferenceInstanceType
        /// </summary>
        public static readonly InferenceInstanceType MlR7iXlarge = new InferenceInstanceType("ml.r7i.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceInstanceType FindValue(string value)
        {
            return FindValue<InferenceInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC42xlarge = new InstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC44xlarge = new InstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC48xlarge = new InstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC4Xlarge = new InstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC518xlarge = new InstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC52xlarge = new InstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC54xlarge = new InstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC59xlarge = new InstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5n18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n18xlarge = new InstanceType("ml.c5n.18xlarge");
        /// <summary>
        /// Constant MlC5n2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n2xlarge = new InstanceType("ml.c5n.2xlarge");
        /// <summary>
        /// Constant MlC5n4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n4xlarge = new InstanceType("ml.c5n.4xlarge");
        /// <summary>
        /// Constant MlC5n9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5n9xlarge = new InstanceType("ml.c5n.9xlarge");
        /// <summary>
        /// Constant MlC5nXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5nXlarge = new InstanceType("ml.c5n.xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5Xlarge = new InstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlC6i12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i12xlarge = new InstanceType("ml.c6i.12xlarge");
        /// <summary>
        /// Constant MlC6i16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i16xlarge = new InstanceType("ml.c6i.16xlarge");
        /// <summary>
        /// Constant MlC6i24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i24xlarge = new InstanceType("ml.c6i.24xlarge");
        /// <summary>
        /// Constant MlC6i2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i2xlarge = new InstanceType("ml.c6i.2xlarge");
        /// <summary>
        /// Constant MlC6i32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i32xlarge = new InstanceType("ml.c6i.32xlarge");
        /// <summary>
        /// Constant MlC6i4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i4xlarge = new InstanceType("ml.c6i.4xlarge");
        /// <summary>
        /// Constant MlC6i8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6i8xlarge = new InstanceType("ml.c6i.8xlarge");
        /// <summary>
        /// Constant MlC6iXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC6iXlarge = new InstanceType("ml.c6i.xlarge");
        /// <summary>
        /// Constant MlC7i12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i12xlarge = new InstanceType("ml.c7i.12xlarge");
        /// <summary>
        /// Constant MlC7i16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i16xlarge = new InstanceType("ml.c7i.16xlarge");
        /// <summary>
        /// Constant MlC7i24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i24xlarge = new InstanceType("ml.c7i.24xlarge");
        /// <summary>
        /// Constant MlC7i2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i2xlarge = new InstanceType("ml.c7i.2xlarge");
        /// <summary>
        /// Constant MlC7i48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i48xlarge = new InstanceType("ml.c7i.48xlarge");
        /// <summary>
        /// Constant MlC7i4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i4xlarge = new InstanceType("ml.c7i.4xlarge");
        /// <summary>
        /// Constant MlC7i8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7i8xlarge = new InstanceType("ml.c7i.8xlarge");
        /// <summary>
        /// Constant MlC7iLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7iLarge = new InstanceType("ml.c7i.large");
        /// <summary>
        /// Constant MlC7iXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC7iXlarge = new InstanceType("ml.c7i.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn12xlarge = new InstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn16xlarge = new InstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn2xlarge = new InstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn4xlarge = new InstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn8xlarge = new InstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dnXlarge = new InstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG512xlarge = new InstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG516xlarge = new InstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG524xlarge = new InstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG52xlarge = new InstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG548xlarge = new InstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG54xlarge = new InstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG58xlarge = new InstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG5Xlarge = new InstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlG612xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG612xlarge = new InstanceType("ml.g6.12xlarge");
        /// <summary>
        /// Constant MlG616xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG616xlarge = new InstanceType("ml.g6.16xlarge");
        /// <summary>
        /// Constant MlG624xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG624xlarge = new InstanceType("ml.g6.24xlarge");
        /// <summary>
        /// Constant MlG62xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG62xlarge = new InstanceType("ml.g6.2xlarge");
        /// <summary>
        /// Constant MlG648xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG648xlarge = new InstanceType("ml.g6.48xlarge");
        /// <summary>
        /// Constant MlG64xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG64xlarge = new InstanceType("ml.g6.4xlarge");
        /// <summary>
        /// Constant MlG68xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG68xlarge = new InstanceType("ml.g6.8xlarge");
        /// <summary>
        /// Constant MlG6e12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e12xlarge = new InstanceType("ml.g6e.12xlarge");
        /// <summary>
        /// Constant MlG6e16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e16xlarge = new InstanceType("ml.g6e.16xlarge");
        /// <summary>
        /// Constant MlG6e24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e24xlarge = new InstanceType("ml.g6e.24xlarge");
        /// <summary>
        /// Constant MlG6e2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e2xlarge = new InstanceType("ml.g6e.2xlarge");
        /// <summary>
        /// Constant MlG6e48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e48xlarge = new InstanceType("ml.g6e.48xlarge");
        /// <summary>
        /// Constant MlG6e4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e4xlarge = new InstanceType("ml.g6e.4xlarge");
        /// <summary>
        /// Constant MlG6e8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6e8xlarge = new InstanceType("ml.g6e.8xlarge");
        /// <summary>
        /// Constant MlG6eXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6eXlarge = new InstanceType("ml.g6e.xlarge");
        /// <summary>
        /// Constant MlG6Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG6Xlarge = new InstanceType("ml.g6.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM410xlarge = new InstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM416xlarge = new InstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM42xlarge = new InstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM44xlarge = new InstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM4Xlarge = new InstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM512xlarge = new InstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM524xlarge = new InstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM52xlarge = new InstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM54xlarge = new InstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Large = new InstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Xlarge = new InstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlM6i12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i12xlarge = new InstanceType("ml.m6i.12xlarge");
        /// <summary>
        /// Constant MlM6i16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i16xlarge = new InstanceType("ml.m6i.16xlarge");
        /// <summary>
        /// Constant MlM6i24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i24xlarge = new InstanceType("ml.m6i.24xlarge");
        /// <summary>
        /// Constant MlM6i2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i2xlarge = new InstanceType("ml.m6i.2xlarge");
        /// <summary>
        /// Constant MlM6i32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i32xlarge = new InstanceType("ml.m6i.32xlarge");
        /// <summary>
        /// Constant MlM6i4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i4xlarge = new InstanceType("ml.m6i.4xlarge");
        /// <summary>
        /// Constant MlM6i8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6i8xlarge = new InstanceType("ml.m6i.8xlarge");
        /// <summary>
        /// Constant MlM6iLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6iLarge = new InstanceType("ml.m6i.large");
        /// <summary>
        /// Constant MlM6iXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM6iXlarge = new InstanceType("ml.m6i.xlarge");
        /// <summary>
        /// Constant MlM7i12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i12xlarge = new InstanceType("ml.m7i.12xlarge");
        /// <summary>
        /// Constant MlM7i16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i16xlarge = new InstanceType("ml.m7i.16xlarge");
        /// <summary>
        /// Constant MlM7i24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i24xlarge = new InstanceType("ml.m7i.24xlarge");
        /// <summary>
        /// Constant MlM7i2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i2xlarge = new InstanceType("ml.m7i.2xlarge");
        /// <summary>
        /// Constant MlM7i48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i48xlarge = new InstanceType("ml.m7i.48xlarge");
        /// <summary>
        /// Constant MlM7i4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i4xlarge = new InstanceType("ml.m7i.4xlarge");
        /// <summary>
        /// Constant MlM7i8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7i8xlarge = new InstanceType("ml.m7i.8xlarge");
        /// <summary>
        /// Constant MlM7iLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7iLarge = new InstanceType("ml.m7i.large");
        /// <summary>
        /// Constant MlM7iXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM7iXlarge = new InstanceType("ml.m7i.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP216xlarge = new InstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP28xlarge = new InstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP2Xlarge = new InstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP316xlarge = new InstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP32xlarge = new InstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP38xlarge = new InstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP3dn24xlarge = new InstanceType("ml.p3dn.24xlarge");
        /// <summary>
        /// Constant MlP4d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP4d24xlarge = new InstanceType("ml.p4d.24xlarge");
        /// <summary>
        /// Constant MlP4de24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP4de24xlarge = new InstanceType("ml.p4de.24xlarge");
        /// <summary>
        /// Constant MlP548xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP548xlarge = new InstanceType("ml.p5.48xlarge");
        /// <summary>
        /// Constant MlP5en48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP5en48xlarge = new InstanceType("ml.p5en.48xlarge");
        /// <summary>
        /// Constant MlR512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR512xlarge = new InstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR516xlarge = new InstanceType("ml.r5.16xlarge");
        /// <summary>
        /// Constant MlR524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR524xlarge = new InstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR52xlarge = new InstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR54xlarge = new InstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR58xlarge = new InstanceType("ml.r5.8xlarge");
        /// <summary>
        /// Constant MlR5d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d12xlarge = new InstanceType("ml.r5d.12xlarge");
        /// <summary>
        /// Constant MlR5d16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d16xlarge = new InstanceType("ml.r5d.16xlarge");
        /// <summary>
        /// Constant MlR5d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d24xlarge = new InstanceType("ml.r5d.24xlarge");
        /// <summary>
        /// Constant MlR5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d2xlarge = new InstanceType("ml.r5d.2xlarge");
        /// <summary>
        /// Constant MlR5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d4xlarge = new InstanceType("ml.r5d.4xlarge");
        /// <summary>
        /// Constant MlR5d8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5d8xlarge = new InstanceType("ml.r5d.8xlarge");
        /// <summary>
        /// Constant MlR5dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5dLarge = new InstanceType("ml.r5d.large");
        /// <summary>
        /// Constant MlR5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5dXlarge = new InstanceType("ml.r5d.xlarge");
        /// <summary>
        /// Constant MlR5Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5Large = new InstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5Xlarge = new InstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlR7i12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i12xlarge = new InstanceType("ml.r7i.12xlarge");
        /// <summary>
        /// Constant MlR7i16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i16xlarge = new InstanceType("ml.r7i.16xlarge");
        /// <summary>
        /// Constant MlR7i24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i24xlarge = new InstanceType("ml.r7i.24xlarge");
        /// <summary>
        /// Constant MlR7i2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i2xlarge = new InstanceType("ml.r7i.2xlarge");
        /// <summary>
        /// Constant MlR7i48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i48xlarge = new InstanceType("ml.r7i.48xlarge");
        /// <summary>
        /// Constant MlR7i4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i4xlarge = new InstanceType("ml.r7i.4xlarge");
        /// <summary>
        /// Constant MlR7i8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7i8xlarge = new InstanceType("ml.r7i.8xlarge");
        /// <summary>
        /// Constant MlR7iLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7iLarge = new InstanceType("ml.r7i.large");
        /// <summary>
        /// Constant MlR7iXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR7iXlarge = new InstanceType("ml.r7i.xlarge");
        /// <summary>
        /// Constant MlT32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT32xlarge = new InstanceType("ml.t3.2xlarge");
        /// <summary>
        /// Constant MlT3Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Large = new InstanceType("ml.t3.large");
        /// <summary>
        /// Constant MlT3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Medium = new InstanceType("ml.t3.medium");
        /// <summary>
        /// Constant MlT3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Xlarge = new InstanceType("ml.t3.xlarge");
        /// <summary>
        /// Constant MlTrn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlTrn12xlarge = new InstanceType("ml.trn1.2xlarge");
        /// <summary>
        /// Constant MlTrn132xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlTrn132xlarge = new InstanceType("ml.trn1.32xlarge");
        /// <summary>
        /// Constant MlTrn1n32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlTrn1n32xlarge = new InstanceType("ml.trn1n.32xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogsStatus.
    /// </summary>
    public class LogsStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISH_FAILED for LogsStatus
        /// </summary>
        public static readonly LogsStatus PUBLISH_FAILED = new LogsStatus("PUBLISH_FAILED");
        /// <summary>
        /// Constant PUBLISH_SUCCEEDED for LogsStatus
        /// </summary>
        public static readonly LogsStatus PUBLISH_SUCCEEDED = new LogsStatus("PUBLISH_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogsStatus FindValue(string value)
        {
            return FindValue<LogsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for LogType
        /// </summary>
        public static readonly LogType ALL = new LogType("ALL");
        /// <summary>
        /// Constant ERROR_SUMMARY for LogType
        /// </summary>
        public static readonly LogType ERROR_SUMMARY = new LogType("ERROR_SUMMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsStatus.
    /// </summary>
    public class MetricsStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISH_FAILED for MetricsStatus
        /// </summary>
        public static readonly MetricsStatus PUBLISH_FAILED = new MetricsStatus("PUBLISH_FAILED");
        /// <summary>
        /// Constant PUBLISH_SUCCEEDED for MetricsStatus
        /// </summary>
        public static readonly MetricsStatus PUBLISH_SUCCEEDED = new MetricsStatus("PUBLISH_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsStatus FindValue(string value)
        {
            return FindValue<MetricsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MLInputChannelStatus.
    /// </summary>
    public class MLInputChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus ACTIVE = new MLInputChannelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus CREATE_FAILED = new MLInputChannelStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus CREATE_IN_PROGRESS = new MLInputChannelStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus CREATE_PENDING = new MLInputChannelStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_FAILED for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus DELETE_FAILED = new MLInputChannelStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus DELETE_IN_PROGRESS = new MLInputChannelStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus DELETE_PENDING = new MLInputChannelStatus("DELETE_PENDING");
        /// <summary>
        /// Constant INACTIVE for MLInputChannelStatus
        /// </summary>
        public static readonly MLInputChannelStatus INACTIVE = new MLInputChannelStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MLInputChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MLInputChannelStatus FindValue(string value)
        {
            return FindValue<MLInputChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MLInputChannelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoiseLevelType.
    /// </summary>
    public class NoiseLevelType : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for NoiseLevelType
        /// </summary>
        public static readonly NoiseLevelType HIGH = new NoiseLevelType("HIGH");
        /// <summary>
        /// Constant LOW for NoiseLevelType
        /// </summary>
        public static readonly NoiseLevelType LOW = new NoiseLevelType("LOW");
        /// <summary>
        /// Constant MEDIUM for NoiseLevelType
        /// </summary>
        public static readonly NoiseLevelType MEDIUM = new NoiseLevelType("MEDIUM");
        /// <summary>
        /// Constant NONE for NoiseLevelType
        /// </summary>
        public static readonly NoiseLevelType NONE = new NoiseLevelType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoiseLevelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoiseLevelType FindValue(string value)
        {
            return FindValue<NoiseLevelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoiseLevelType(string value)
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
    /// Constants used for properties of type ResultFormat.
    /// </summary>
    public class ResultFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ResultFormat
        /// </summary>
        public static readonly ResultFormat CSV = new ResultFormat("CSV");
        /// <summary>
        /// Constant PARQUET for ResultFormat
        /// </summary>
        public static readonly ResultFormat PARQUET = new ResultFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResultFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultFormat FindValue(string value)
        {
            return FindValue<ResultFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataDistributionType.
    /// </summary>
    public class S3DataDistributionType : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for S3DataDistributionType
        /// </summary>
        public static readonly S3DataDistributionType FullyReplicated = new S3DataDistributionType("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for S3DataDistributionType
        /// </summary>
        public static readonly S3DataDistributionType ShardedByS3Key = new S3DataDistributionType("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataDistributionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataDistributionType FindValue(string value)
        {
            return FindValue<S3DataDistributionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataDistributionType(string value)
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
    /// Constants used for properties of type TrainedModelArtifactMaxSizeUnitType.
    /// </summary>
    public class TrainedModelArtifactMaxSizeUnitType : ConstantClass
    {

        /// <summary>
        /// Constant GB for TrainedModelArtifactMaxSizeUnitType
        /// </summary>
        public static readonly TrainedModelArtifactMaxSizeUnitType GB = new TrainedModelArtifactMaxSizeUnitType("GB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelArtifactMaxSizeUnitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelArtifactMaxSizeUnitType FindValue(string value)
        {
            return FindValue<TrainedModelArtifactMaxSizeUnitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelArtifactMaxSizeUnitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelExportFileType.
    /// </summary>
    public class TrainedModelExportFileType : ConstantClass
    {

        /// <summary>
        /// Constant MODEL for TrainedModelExportFileType
        /// </summary>
        public static readonly TrainedModelExportFileType MODEL = new TrainedModelExportFileType("MODEL");
        /// <summary>
        /// Constant OUTPUT for TrainedModelExportFileType
        /// </summary>
        public static readonly TrainedModelExportFileType OUTPUT = new TrainedModelExportFileType("OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelExportFileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelExportFileType FindValue(string value)
        {
            return FindValue<TrainedModelExportFileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelExportFileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelExportJobStatus.
    /// </summary>
    public class TrainedModelExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrainedModelExportJobStatus
        /// </summary>
        public static readonly TrainedModelExportJobStatus ACTIVE = new TrainedModelExportJobStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for TrainedModelExportJobStatus
        /// </summary>
        public static readonly TrainedModelExportJobStatus CREATE_FAILED = new TrainedModelExportJobStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for TrainedModelExportJobStatus
        /// </summary>
        public static readonly TrainedModelExportJobStatus CREATE_IN_PROGRESS = new TrainedModelExportJobStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for TrainedModelExportJobStatus
        /// </summary>
        public static readonly TrainedModelExportJobStatus CREATE_PENDING = new TrainedModelExportJobStatus("CREATE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelExportJobStatus FindValue(string value)
        {
            return FindValue<TrainedModelExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelExportsMaxSizeUnitType.
    /// </summary>
    public class TrainedModelExportsMaxSizeUnitType : ConstantClass
    {

        /// <summary>
        /// Constant GB for TrainedModelExportsMaxSizeUnitType
        /// </summary>
        public static readonly TrainedModelExportsMaxSizeUnitType GB = new TrainedModelExportsMaxSizeUnitType("GB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelExportsMaxSizeUnitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelExportsMaxSizeUnitType FindValue(string value)
        {
            return FindValue<TrainedModelExportsMaxSizeUnitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelExportsMaxSizeUnitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelInferenceJobStatus.
    /// </summary>
    public class TrainedModelInferenceJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus ACTIVE = new TrainedModelInferenceJobStatus("ACTIVE");
        /// <summary>
        /// Constant CANCEL_FAILED for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CANCEL_FAILED = new TrainedModelInferenceJobStatus("CANCEL_FAILED");
        /// <summary>
        /// Constant CANCEL_IN_PROGRESS for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CANCEL_IN_PROGRESS = new TrainedModelInferenceJobStatus("CANCEL_IN_PROGRESS");
        /// <summary>
        /// Constant CANCEL_PENDING for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CANCEL_PENDING = new TrainedModelInferenceJobStatus("CANCEL_PENDING");
        /// <summary>
        /// Constant CREATE_FAILED for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CREATE_FAILED = new TrainedModelInferenceJobStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CREATE_IN_PROGRESS = new TrainedModelInferenceJobStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus CREATE_PENDING = new TrainedModelInferenceJobStatus("CREATE_PENDING");
        /// <summary>
        /// Constant INACTIVE for TrainedModelInferenceJobStatus
        /// </summary>
        public static readonly TrainedModelInferenceJobStatus INACTIVE = new TrainedModelInferenceJobStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelInferenceJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelInferenceJobStatus FindValue(string value)
        {
            return FindValue<TrainedModelInferenceJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelInferenceJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelInferenceMaxOutputSizeUnitType.
    /// </summary>
    public class TrainedModelInferenceMaxOutputSizeUnitType : ConstantClass
    {

        /// <summary>
        /// Constant GB for TrainedModelInferenceMaxOutputSizeUnitType
        /// </summary>
        public static readonly TrainedModelInferenceMaxOutputSizeUnitType GB = new TrainedModelInferenceMaxOutputSizeUnitType("GB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelInferenceMaxOutputSizeUnitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelInferenceMaxOutputSizeUnitType FindValue(string value)
        {
            return FindValue<TrainedModelInferenceMaxOutputSizeUnitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelInferenceMaxOutputSizeUnitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainedModelStatus.
    /// </summary>
    public class TrainedModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus ACTIVE = new TrainedModelStatus("ACTIVE");
        /// <summary>
        /// Constant CANCEL_FAILED for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CANCEL_FAILED = new TrainedModelStatus("CANCEL_FAILED");
        /// <summary>
        /// Constant CANCEL_IN_PROGRESS for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CANCEL_IN_PROGRESS = new TrainedModelStatus("CANCEL_IN_PROGRESS");
        /// <summary>
        /// Constant CANCEL_PENDING for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CANCEL_PENDING = new TrainedModelStatus("CANCEL_PENDING");
        /// <summary>
        /// Constant CREATE_FAILED for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CREATE_FAILED = new TrainedModelStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CREATE_IN_PROGRESS = new TrainedModelStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus CREATE_PENDING = new TrainedModelStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_FAILED for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus DELETE_FAILED = new TrainedModelStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus DELETE_IN_PROGRESS = new TrainedModelStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus DELETE_PENDING = new TrainedModelStatus("DELETE_PENDING");
        /// <summary>
        /// Constant INACTIVE for TrainedModelStatus
        /// </summary>
        public static readonly TrainedModelStatus INACTIVE = new TrainedModelStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainedModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainedModelStatus FindValue(string value)
        {
            return FindValue<TrainedModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainedModelStatus(string value)
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


    /// <summary>
    /// Constants used for properties of type TrainingInputMode.
    /// </summary>
    public class TrainingInputMode : ConstantClass
    {

        /// <summary>
        /// Constant FastFile for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode FastFile = new TrainingInputMode("FastFile");
        /// <summary>
        /// Constant File for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode File = new TrainingInputMode("File");
        /// <summary>
        /// Constant Pipe for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode Pipe = new TrainingInputMode("Pipe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInputMode FindValue(string value)
        {
            return FindValue<TrainingInputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkerComputeType.
    /// </summary>
    public class WorkerComputeType : ConstantClass
    {

        /// <summary>
        /// Constant CR1X for WorkerComputeType
        /// </summary>
        public static readonly WorkerComputeType CR1X = new WorkerComputeType("CR.1X");
        /// <summary>
        /// Constant CR4X for WorkerComputeType
        /// </summary>
        public static readonly WorkerComputeType CR4X = new WorkerComputeType("CR.4X");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerComputeType FindValue(string value)
        {
            return FindValue<WorkerComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerComputeType(string value)
        {
            return FindValue(value);
        }
    }

}