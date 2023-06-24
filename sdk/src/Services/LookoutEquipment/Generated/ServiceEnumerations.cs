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
    /// Constants used for properties of type ModelStatus.
    /// </summary>
    public class ModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ModelStatus
        /// </summary>
        public static readonly ModelStatus FAILED = new ModelStatus("FAILED");
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