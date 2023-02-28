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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FraudDetector
{

    /// <summary>
    /// Constants used for properties of type AsyncJobStatus.
    /// </summary>
    public class AsyncJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_IN_PROGRESS for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus CANCEL_IN_PROGRESS = new AsyncJobStatus("CANCEL_IN_PROGRESS");
        /// <summary>
        /// Constant CANCELED for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus CANCELED = new AsyncJobStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETE for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus COMPLETE = new AsyncJobStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus FAILED = new AsyncJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus IN_PROGRESS = new AsyncJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS_INITIALIZING for AsyncJobStatus
        /// </summary>
        public static readonly AsyncJobStatus IN_PROGRESS_INITIALIZING = new AsyncJobStatus("IN_PROGRESS_INITIALIZING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AsyncJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AsyncJobStatus FindValue(string value)
        {
            return FindValue<AsyncJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AsyncJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSource.
    /// </summary>
    public class DataSource : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for DataSource
        /// </summary>
        public static readonly DataSource EVENT = new DataSource("EVENT");
        /// <summary>
        /// Constant EXTERNAL_MODEL_SCORE for DataSource
        /// </summary>
        public static readonly DataSource EXTERNAL_MODEL_SCORE = new DataSource("EXTERNAL_MODEL_SCORE");
        /// <summary>
        /// Constant MODEL_SCORE for DataSource
        /// </summary>
        public static readonly DataSource MODEL_SCORE = new DataSource("MODEL_SCORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSource FindValue(string value)
        {
            return FindValue<DataSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataType.
    /// </summary>
    public class DataType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for DataType
        /// </summary>
        public static readonly DataType BOOLEAN = new DataType("BOOLEAN");
        /// <summary>
        /// Constant FLOAT for DataType
        /// </summary>
        public static readonly DataType FLOAT = new DataType("FLOAT");
        /// <summary>
        /// Constant INTEGER for DataType
        /// </summary>
        public static readonly DataType INTEGER = new DataType("INTEGER");
        /// <summary>
        /// Constant STRING for DataType
        /// </summary>
        public static readonly DataType STRING = new DataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataType FindValue(string value)
        {
            return FindValue<DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectorVersionStatus.
    /// </summary>
    public class DetectorVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DetectorVersionStatus
        /// </summary>
        public static readonly DetectorVersionStatus ACTIVE = new DetectorVersionStatus("ACTIVE");
        /// <summary>
        /// Constant DRAFT for DetectorVersionStatus
        /// </summary>
        public static readonly DetectorVersionStatus DRAFT = new DetectorVersionStatus("DRAFT");
        /// <summary>
        /// Constant INACTIVE for DetectorVersionStatus
        /// </summary>
        public static readonly DetectorVersionStatus INACTIVE = new DetectorVersionStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorVersionStatus FindValue(string value)
        {
            return FindValue<DetectorVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventIngestion.
    /// </summary>
    public class EventIngestion : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EventIngestion
        /// </summary>
        public static readonly EventIngestion DISABLED = new EventIngestion("DISABLED");
        /// <summary>
        /// Constant ENABLED for EventIngestion
        /// </summary>
        public static readonly EventIngestion ENABLED = new EventIngestion("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventIngestion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventIngestion FindValue(string value)
        {
            return FindValue<EventIngestion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventIngestion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Language.
    /// </summary>
    public class Language : ConstantClass
    {

        /// <summary>
        /// Constant DETECTORPL for Language
        /// </summary>
        public static readonly Language DETECTORPL = new Language("DETECTORPL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Language(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Language FindValue(string value)
        {
            return FindValue<Language>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Language(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListUpdateMode.
    /// </summary>
    public class ListUpdateMode : ConstantClass
    {

        /// <summary>
        /// Constant APPEND for ListUpdateMode
        /// </summary>
        public static readonly ListUpdateMode APPEND = new ListUpdateMode("APPEND");
        /// <summary>
        /// Constant REMOVE for ListUpdateMode
        /// </summary>
        public static readonly ListUpdateMode REMOVE = new ListUpdateMode("REMOVE");
        /// <summary>
        /// Constant REPLACE for ListUpdateMode
        /// </summary>
        public static readonly ListUpdateMode REPLACE = new ListUpdateMode("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListUpdateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListUpdateMode FindValue(string value)
        {
            return FindValue<ListUpdateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListUpdateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelEndpointStatus.
    /// </summary>
    public class ModelEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED for ModelEndpointStatus
        /// </summary>
        public static readonly ModelEndpointStatus ASSOCIATED = new ModelEndpointStatus("ASSOCIATED");
        /// <summary>
        /// Constant DISSOCIATED for ModelEndpointStatus
        /// </summary>
        public static readonly ModelEndpointStatus DISSOCIATED = new ModelEndpointStatus("DISSOCIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelEndpointStatus FindValue(string value)
        {
            return FindValue<ModelEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelInputDataFormat.
    /// </summary>
    public class ModelInputDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION_JSON for ModelInputDataFormat
        /// </summary>
        public static readonly ModelInputDataFormat APPLICATION_JSON = new ModelInputDataFormat("APPLICATION_JSON");
        /// <summary>
        /// Constant TEXT_CSV for ModelInputDataFormat
        /// </summary>
        public static readonly ModelInputDataFormat TEXT_CSV = new ModelInputDataFormat("TEXT_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelInputDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelInputDataFormat FindValue(string value)
        {
            return FindValue<ModelInputDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelInputDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelOutputDataFormat.
    /// </summary>
    public class ModelOutputDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION_JSONLINES for ModelOutputDataFormat
        /// </summary>
        public static readonly ModelOutputDataFormat APPLICATION_JSONLINES = new ModelOutputDataFormat("APPLICATION_JSONLINES");
        /// <summary>
        /// Constant TEXT_CSV for ModelOutputDataFormat
        /// </summary>
        public static readonly ModelOutputDataFormat TEXT_CSV = new ModelOutputDataFormat("TEXT_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelOutputDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelOutputDataFormat FindValue(string value)
        {
            return FindValue<ModelOutputDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelOutputDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelSource.
    /// </summary>
    public class ModelSource : ConstantClass
    {

        /// <summary>
        /// Constant SAGEMAKER for ModelSource
        /// </summary>
        public static readonly ModelSource SAGEMAKER = new ModelSource("SAGEMAKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelSource FindValue(string value)
        {
            return FindValue<ModelSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelTypeEnum.
    /// </summary>
    public class ModelTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_TAKEOVER_INSIGHTS for ModelTypeEnum
        /// </summary>
        public static readonly ModelTypeEnum ACCOUNT_TAKEOVER_INSIGHTS = new ModelTypeEnum("ACCOUNT_TAKEOVER_INSIGHTS");
        /// <summary>
        /// Constant ONLINE_FRAUD_INSIGHTS for ModelTypeEnum
        /// </summary>
        public static readonly ModelTypeEnum ONLINE_FRAUD_INSIGHTS = new ModelTypeEnum("ONLINE_FRAUD_INSIGHTS");
        /// <summary>
        /// Constant TRANSACTION_FRAUD_INSIGHTS for ModelTypeEnum
        /// </summary>
        public static readonly ModelTypeEnum TRANSACTION_FRAUD_INSIGHTS = new ModelTypeEnum("TRANSACTION_FRAUD_INSIGHTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelTypeEnum FindValue(string value)
        {
            return FindValue<ModelTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelTypeEnum(string value)
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
        /// Constant ACTIVE for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus ACTIVE = new ModelVersionStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus INACTIVE = new ModelVersionStatus("INACTIVE");
        /// <summary>
        /// Constant TRAINING_CANCELLED for ModelVersionStatus
        /// </summary>
        public static readonly ModelVersionStatus TRAINING_CANCELLED = new ModelVersionStatus("TRAINING_CANCELLED");

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
    /// Constants used for properties of type RuleExecutionMode.
    /// </summary>
    public class RuleExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL_MATCHED for RuleExecutionMode
        /// </summary>
        public static readonly RuleExecutionMode ALL_MATCHED = new RuleExecutionMode("ALL_MATCHED");
        /// <summary>
        /// Constant FIRST_MATCHED for RuleExecutionMode
        /// </summary>
        public static readonly RuleExecutionMode FIRST_MATCHED = new RuleExecutionMode("FIRST_MATCHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleExecutionMode FindValue(string value)
        {
            return FindValue<RuleExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingDataSourceEnum.
    /// </summary>
    public class TrainingDataSourceEnum : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL_EVENTS for TrainingDataSourceEnum
        /// </summary>
        public static readonly TrainingDataSourceEnum EXTERNAL_EVENTS = new TrainingDataSourceEnum("EXTERNAL_EVENTS");
        /// <summary>
        /// Constant INGESTED_EVENTS for TrainingDataSourceEnum
        /// </summary>
        public static readonly TrainingDataSourceEnum INGESTED_EVENTS = new TrainingDataSourceEnum("INGESTED_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingDataSourceEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingDataSourceEnum FindValue(string value)
        {
            return FindValue<TrainingDataSourceEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingDataSourceEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnlabeledEventsTreatment.
    /// </summary>
    public class UnlabeledEventsTreatment : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for UnlabeledEventsTreatment
        /// </summary>
        public static readonly UnlabeledEventsTreatment AUTO = new UnlabeledEventsTreatment("AUTO");
        /// <summary>
        /// Constant FRAUD for UnlabeledEventsTreatment
        /// </summary>
        public static readonly UnlabeledEventsTreatment FRAUD = new UnlabeledEventsTreatment("FRAUD");
        /// <summary>
        /// Constant IGNORE for UnlabeledEventsTreatment
        /// </summary>
        public static readonly UnlabeledEventsTreatment IGNORE = new UnlabeledEventsTreatment("IGNORE");
        /// <summary>
        /// Constant LEGIT for UnlabeledEventsTreatment
        /// </summary>
        public static readonly UnlabeledEventsTreatment LEGIT = new UnlabeledEventsTreatment("LEGIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnlabeledEventsTreatment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnlabeledEventsTreatment FindValue(string value)
        {
            return FindValue<UnlabeledEventsTreatment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnlabeledEventsTreatment(string value)
        {
            return FindValue(value);
        }
    }

}