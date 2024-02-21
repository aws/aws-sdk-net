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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LookoutEquipment
{

    /// <summary>
    /// Constants used for properties of type AutoPromotionResult.
    /// </summary>
    public class AutoPromotionResult : ConstantClass
    {

        /// <summary>
        /// Constant MODEL_NOT_PROMOTED for AutoPromotionResult
        /// </summary>
        public static readonly AutoPromotionResult MODEL_NOT_PROMOTED = new AutoPromotionResult("MODEL_NOT_PROMOTED");
        /// <summary>
        /// Constant MODEL_PROMOTED for AutoPromotionResult
        /// </summary>
        public static readonly AutoPromotionResult MODEL_PROMOTED = new AutoPromotionResult("MODEL_PROMOTED");
        /// <summary>
        /// Constant RETRAINING_CANCELLED for AutoPromotionResult
        /// </summary>
        public static readonly AutoPromotionResult RETRAINING_CANCELLED = new AutoPromotionResult("RETRAINING_CANCELLED");
        /// <summary>
        /// Constant RETRAINING_CUSTOMER_ERROR for AutoPromotionResult
        /// </summary>
        public static readonly AutoPromotionResult RETRAINING_CUSTOMER_ERROR = new AutoPromotionResult("RETRAINING_CUSTOMER_ERROR");
        /// <summary>
        /// Constant RETRAINING_INTERNAL_ERROR for AutoPromotionResult
        /// </summary>
        public static readonly AutoPromotionResult RETRAINING_INTERNAL_ERROR = new AutoPromotionResult("RETRAINING_INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoPromotionResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoPromotionResult FindValue(string value)
        {
            return FindValue<AutoPromotionResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoPromotionResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetStatus.
    /// </summary>
    public class DatasetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus ACTIVE = new DatasetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATED = new DatasetStatus("CREATED");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus IMPORT_IN_PROGRESS = new DatasetStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant INGESTION_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus INGESTION_IN_PROGRESS = new DatasetStatus("INGESTION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetStatus FindValue(string value)
        {
            return FindValue<DatasetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataUploadFrequency.
    /// </summary>
    public class DataUploadFrequency : ConstantClass
    {

        /// <summary>
        /// Constant PT10M for DataUploadFrequency
        /// </summary>
        public static readonly DataUploadFrequency PT10M = new DataUploadFrequency("PT10M");
        /// <summary>
        /// Constant PT15M for DataUploadFrequency
        /// </summary>
        public static readonly DataUploadFrequency PT15M = new DataUploadFrequency("PT15M");
        /// <summary>
        /// Constant PT1H for DataUploadFrequency
        /// </summary>
        public static readonly DataUploadFrequency PT1H = new DataUploadFrequency("PT1H");
        /// <summary>
        /// Constant PT30M for DataUploadFrequency
        /// </summary>
        public static readonly DataUploadFrequency PT30M = new DataUploadFrequency("PT30M");
        /// <summary>
        /// Constant PT5M for DataUploadFrequency
        /// </summary>
        public static readonly DataUploadFrequency PT5M = new DataUploadFrequency("PT5M");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataUploadFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataUploadFrequency FindValue(string value)
        {
            return FindValue<DataUploadFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataUploadFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceDataImportStrategy.
    /// </summary>
    public class InferenceDataImportStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ADD_WHEN_EMPTY for InferenceDataImportStrategy
        /// </summary>
        public static readonly InferenceDataImportStrategy ADD_WHEN_EMPTY = new InferenceDataImportStrategy("ADD_WHEN_EMPTY");
        /// <summary>
        /// Constant NO_IMPORT for InferenceDataImportStrategy
        /// </summary>
        public static readonly InferenceDataImportStrategy NO_IMPORT = new InferenceDataImportStrategy("NO_IMPORT");
        /// <summary>
        /// Constant OVERWRITE for InferenceDataImportStrategy
        /// </summary>
        public static readonly InferenceDataImportStrategy OVERWRITE = new InferenceDataImportStrategy("OVERWRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceDataImportStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceDataImportStrategy FindValue(string value)
        {
            return FindValue<InferenceDataImportStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceDataImportStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceExecutionStatus.
    /// </summary>
    public class InferenceExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for InferenceExecutionStatus
        /// </summary>
        public static readonly InferenceExecutionStatus FAILED = new InferenceExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for InferenceExecutionStatus
        /// </summary>
        public static readonly InferenceExecutionStatus IN_PROGRESS = new InferenceExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for InferenceExecutionStatus
        /// </summary>
        public static readonly InferenceExecutionStatus SUCCESS = new InferenceExecutionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceExecutionStatus FindValue(string value)
        {
            return FindValue<InferenceExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceSchedulerStatus.
    /// </summary>
    public class InferenceSchedulerStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for InferenceSchedulerStatus
        /// </summary>
        public static readonly InferenceSchedulerStatus PENDING = new InferenceSchedulerStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for InferenceSchedulerStatus
        /// </summary>
        public static readonly InferenceSchedulerStatus RUNNING = new InferenceSchedulerStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for InferenceSchedulerStatus
        /// </summary>
        public static readonly InferenceSchedulerStatus STOPPED = new InferenceSchedulerStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for InferenceSchedulerStatus
        /// </summary>
        public static readonly InferenceSchedulerStatus STOPPING = new InferenceSchedulerStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceSchedulerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceSchedulerStatus FindValue(string value)
        {
            return FindValue<InferenceSchedulerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceSchedulerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionJobStatus.
    /// </summary>
    public class IngestionJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus FAILED = new IngestionJobStatus("FAILED");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus IMPORT_IN_PROGRESS = new IngestionJobStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus IN_PROGRESS = new IngestionJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus SUCCESS = new IngestionJobStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobStatus FindValue(string value)
        {
            return FindValue<IngestionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelRating.
    /// </summary>
    public class LabelRating : ConstantClass
    {

        /// <summary>
        /// Constant ANOMALY for LabelRating
        /// </summary>
        public static readonly LabelRating ANOMALY = new LabelRating("ANOMALY");
        /// <summary>
        /// Constant NEUTRAL for LabelRating
        /// </summary>
        public static readonly LabelRating NEUTRAL = new LabelRating("NEUTRAL");
        /// <summary>
        /// Constant NO_ANOMALY for LabelRating
        /// </summary>
        public static readonly LabelRating NO_ANOMALY = new LabelRating("NO_ANOMALY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelRating(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelRating FindValue(string value)
        {
            return FindValue<LabelRating>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelRating(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LatestInferenceResult.
    /// </summary>
    public class LatestInferenceResult : ConstantClass
    {

        /// <summary>
        /// Constant ANOMALOUS for LatestInferenceResult
        /// </summary>
        public static readonly LatestInferenceResult ANOMALOUS = new LatestInferenceResult("ANOMALOUS");
        /// <summary>
        /// Constant NORMAL for LatestInferenceResult
        /// </summary>
        public static readonly LatestInferenceResult NORMAL = new LatestInferenceResult("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LatestInferenceResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LatestInferenceResult FindValue(string value)
        {
            return FindValue<LatestInferenceResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LatestInferenceResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPromoteMode.
    /// </summary>
    public class ModelPromoteMode : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED for ModelPromoteMode
        /// </summary>
        public static readonly ModelPromoteMode MANAGED = new ModelPromoteMode("MANAGED");
        /// <summary>
        /// Constant MANUAL for ModelPromoteMode
        /// </summary>
        public static readonly ModelPromoteMode MANUAL = new ModelPromoteMode("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPromoteMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPromoteMode FindValue(string value)
        {
            return FindValue<ModelPromoteMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPromoteMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelQuality.
    /// </summary>
    public class ModelQuality : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_DETERMINE_QUALITY for ModelQuality
        /// </summary>
        public static readonly ModelQuality CANNOT_DETERMINE_QUALITY = new ModelQuality("CANNOT_DETERMINE_QUALITY");
        /// <summary>
        /// Constant POOR_QUALITY_DETECTED for ModelQuality
        /// </summary>
        public static readonly ModelQuality POOR_QUALITY_DETECTED = new ModelQuality("POOR_QUALITY_DETECTED");
        /// <summary>
        /// Constant QUALITY_THRESHOLD_MET for ModelQuality
        /// </summary>
        public static readonly ModelQuality QUALITY_THRESHOLD_MET = new ModelQuality("QUALITY_THRESHOLD_MET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelQuality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelQuality FindValue(string value)
        {
            return FindValue<ModelQuality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelQuality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelStatus.
    /// </summary>
    public class ModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ModelStatus
        /// </summary>
        public static readonly ModelStatus FAILED = new ModelStatus("FAILED");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for ModelStatus
        /// </summary>
        public static readonly ModelStatus IMPORT_IN_PROGRESS = new ModelStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for ModelStatus
        /// </summary>
        public static readonly ModelStatus IN_PROGRESS = new ModelStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for ModelStatus
        /// </summary>
        public static readonly ModelStatus SUCCESS = new ModelStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelStatus FindValue(string value)
        {
            return FindValue<ModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelVersionSourceType.
    /// </summary>
    public class ModelVersionSourceType : ConstantClass
    {

        /// <summary>
        /// Constant IMPORT for ModelVersionSourceType
        /// </summary>
        public static readonly ModelVersionSourceType IMPORT = new ModelVersionSourceType("IMPORT");
        /// <summary>
        /// Constant RETRAINING for ModelVersionSourceType
        /// </summary>
        public static readonly ModelVersionSourceType RETRAINING = new ModelVersionSourceType("RETRAINING");
        /// <summary>
        /// Constant TRAINING for ModelVersionSourceType
        /// </summary>
        public static readonly ModelVersionSourceType TRAINING = new ModelVersionSourceType("TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelVersionSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelVersionSourceType FindValue(string value)
        {
            return FindValue<ModelVersionSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelVersionSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelVersionStatus.
    /// </summary>
    public class ModelVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus CANCELED = new ModelVersionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus FAILED = new ModelVersionStatus("FAILED");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus IMPORT_IN_PROGRESS = new ModelVersionStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus IN_PROGRESS = new ModelVersionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus SUCCESS = new ModelVersionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelVersionStatus FindValue(string value)
        {
            return FindValue<ModelVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Monotonicity.
    /// </summary>
    public class Monotonicity : ConstantClass
    {

        /// <summary>
        /// Constant DECREASING for Monotonicity
        /// </summary>
        public static readonly Monotonicity DECREASING = new Monotonicity("DECREASING");
        /// <summary>
        /// Constant INCREASING for Monotonicity
        /// </summary>
        public static readonly Monotonicity INCREASING = new Monotonicity("INCREASING");
        /// <summary>
        /// Constant STATIC for Monotonicity
        /// </summary>
        public static readonly Monotonicity STATIC = new Monotonicity("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Monotonicity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Monotonicity FindValue(string value)
        {
            return FindValue<Monotonicity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Monotonicity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrainingSchedulerStatus.
    /// </summary>
    public class RetrainingSchedulerStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for RetrainingSchedulerStatus
        /// </summary>
        public static readonly RetrainingSchedulerStatus PENDING = new RetrainingSchedulerStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for RetrainingSchedulerStatus
        /// </summary>
        public static readonly RetrainingSchedulerStatus RUNNING = new RetrainingSchedulerStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for RetrainingSchedulerStatus
        /// </summary>
        public static readonly RetrainingSchedulerStatus STOPPED = new RetrainingSchedulerStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for RetrainingSchedulerStatus
        /// </summary>
        public static readonly RetrainingSchedulerStatus STOPPING = new RetrainingSchedulerStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrainingSchedulerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrainingSchedulerStatus FindValue(string value)
        {
            return FindValue<RetrainingSchedulerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrainingSchedulerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatisticalIssueStatus.
    /// </summary>
    public class StatisticalIssueStatus : ConstantClass
    {

        /// <summary>
        /// Constant NO_ISSUE_DETECTED for StatisticalIssueStatus
        /// </summary>
        public static readonly StatisticalIssueStatus NO_ISSUE_DETECTED = new StatisticalIssueStatus("NO_ISSUE_DETECTED");
        /// <summary>
        /// Constant POTENTIAL_ISSUE_DETECTED for StatisticalIssueStatus
        /// </summary>
        public static readonly StatisticalIssueStatus POTENTIAL_ISSUE_DETECTED = new StatisticalIssueStatus("POTENTIAL_ISSUE_DETECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatisticalIssueStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatisticalIssueStatus FindValue(string value)
        {
            return FindValue<StatisticalIssueStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatisticalIssueStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetSamplingRate.
    /// </summary>
    public class TargetSamplingRate : ConstantClass
    {

        /// <summary>
        /// Constant PT10M for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT10M = new TargetSamplingRate("PT10M");
        /// <summary>
        /// Constant PT10S for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT10S = new TargetSamplingRate("PT10S");
        /// <summary>
        /// Constant PT15M for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT15M = new TargetSamplingRate("PT15M");
        /// <summary>
        /// Constant PT15S for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT15S = new TargetSamplingRate("PT15S");
        /// <summary>
        /// Constant PT1H for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT1H = new TargetSamplingRate("PT1H");
        /// <summary>
        /// Constant PT1M for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT1M = new TargetSamplingRate("PT1M");
        /// <summary>
        /// Constant PT1S for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT1S = new TargetSamplingRate("PT1S");
        /// <summary>
        /// Constant PT30M for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT30M = new TargetSamplingRate("PT30M");
        /// <summary>
        /// Constant PT30S for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT30S = new TargetSamplingRate("PT30S");
        /// <summary>
        /// Constant PT5M for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT5M = new TargetSamplingRate("PT5M");
        /// <summary>
        /// Constant PT5S for TargetSamplingRate
        /// </summary>
        public static readonly TargetSamplingRate PT5S = new TargetSamplingRate("PT5S");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetSamplingRate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetSamplingRate FindValue(string value)
        {
            return FindValue<TargetSamplingRate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetSamplingRate(string value)
        {
            return FindValue(value);
        }
    }

}