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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MachineLearning
{

    /// <summary>
    /// Constants used for properties of type Algorithm.
    /// </summary>
    public class Algorithm : ConstantClass
    {

        /// <summary>
        /// Constant Sgd for Algorithm
        /// </summary>
        public static readonly Algorithm Sgd = new Algorithm("sgd");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Algorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Algorithm FindValue(string value)
        {
            return FindValue<Algorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Algorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchPredictionFilterVariable.
    /// </summary>
    public class BatchPredictionFilterVariable : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable CreatedAt = new BatchPredictionFilterVariable("CreatedAt");
        /// <summary>
        /// Constant DataSourceId for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable DataSourceId = new BatchPredictionFilterVariable("DataSourceId");
        /// <summary>
        /// Constant DataURI for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable DataURI = new BatchPredictionFilterVariable("DataURI");
        /// <summary>
        /// Constant IAMUser for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable IAMUser = new BatchPredictionFilterVariable("IAMUser");
        /// <summary>
        /// Constant LastUpdatedAt for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable LastUpdatedAt = new BatchPredictionFilterVariable("LastUpdatedAt");
        /// <summary>
        /// Constant MLModelId for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable MLModelId = new BatchPredictionFilterVariable("MLModelId");
        /// <summary>
        /// Constant Name for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable Name = new BatchPredictionFilterVariable("Name");
        /// <summary>
        /// Constant Status for BatchPredictionFilterVariable
        /// </summary>
        public static readonly BatchPredictionFilterVariable Status = new BatchPredictionFilterVariable("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchPredictionFilterVariable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchPredictionFilterVariable FindValue(string value)
        {
            return FindValue<BatchPredictionFilterVariable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchPredictionFilterVariable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceFilterVariable.
    /// </summary>
    public class DataSourceFilterVariable : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable CreatedAt = new DataSourceFilterVariable("CreatedAt");
        /// <summary>
        /// Constant DataLocationS3 for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable DataLocationS3 = new DataSourceFilterVariable("DataLocationS3");
        /// <summary>
        /// Constant IAMUser for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable IAMUser = new DataSourceFilterVariable("IAMUser");
        /// <summary>
        /// Constant LastUpdatedAt for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable LastUpdatedAt = new DataSourceFilterVariable("LastUpdatedAt");
        /// <summary>
        /// Constant Name for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable Name = new DataSourceFilterVariable("Name");
        /// <summary>
        /// Constant Status for DataSourceFilterVariable
        /// </summary>
        public static readonly DataSourceFilterVariable Status = new DataSourceFilterVariable("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceFilterVariable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceFilterVariable FindValue(string value)
        {
            return FindValue<DataSourceFilterVariable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceFilterVariable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailsAttributes.
    /// </summary>
    public class DetailsAttributes : ConstantClass
    {

        /// <summary>
        /// Constant Algorithm for DetailsAttributes
        /// </summary>
        public static readonly DetailsAttributes Algorithm = new DetailsAttributes("Algorithm");
        /// <summary>
        /// Constant PredictiveModelType for DetailsAttributes
        /// </summary>
        public static readonly DetailsAttributes PredictiveModelType = new DetailsAttributes("PredictiveModelType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailsAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailsAttributes FindValue(string value)
        {
            return FindValue<DetailsAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailsAttributes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityStatus.
    /// </summary>
    public class EntityStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for EntityStatus
        /// </summary>
        public static readonly EntityStatus COMPLETED = new EntityStatus("COMPLETED");
        /// <summary>
        /// Constant DELETED for EntityStatus
        /// </summary>
        public static readonly EntityStatus DELETED = new EntityStatus("DELETED");
        /// <summary>
        /// Constant FAILED for EntityStatus
        /// </summary>
        public static readonly EntityStatus FAILED = new EntityStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for EntityStatus
        /// </summary>
        public static readonly EntityStatus INPROGRESS = new EntityStatus("INPROGRESS");
        /// <summary>
        /// Constant PENDING for EntityStatus
        /// </summary>
        public static readonly EntityStatus PENDING = new EntityStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityStatus FindValue(string value)
        {
            return FindValue<EntityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFilterVariable.
    /// </summary>
    public class EvaluationFilterVariable : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable CreatedAt = new EvaluationFilterVariable("CreatedAt");
        /// <summary>
        /// Constant DataSourceId for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable DataSourceId = new EvaluationFilterVariable("DataSourceId");
        /// <summary>
        /// Constant DataURI for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable DataURI = new EvaluationFilterVariable("DataURI");
        /// <summary>
        /// Constant IAMUser for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable IAMUser = new EvaluationFilterVariable("IAMUser");
        /// <summary>
        /// Constant LastUpdatedAt for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable LastUpdatedAt = new EvaluationFilterVariable("LastUpdatedAt");
        /// <summary>
        /// Constant MLModelId for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable MLModelId = new EvaluationFilterVariable("MLModelId");
        /// <summary>
        /// Constant Name for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable Name = new EvaluationFilterVariable("Name");
        /// <summary>
        /// Constant Status for EvaluationFilterVariable
        /// </summary>
        public static readonly EvaluationFilterVariable Status = new EvaluationFilterVariable("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFilterVariable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFilterVariable FindValue(string value)
        {
            return FindValue<EvaluationFilterVariable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFilterVariable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MLModelFilterVariable.
    /// </summary>
    public class MLModelFilterVariable : ConstantClass
    {

        /// <summary>
        /// Constant Algorithm for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable Algorithm = new MLModelFilterVariable("Algorithm");
        /// <summary>
        /// Constant CreatedAt for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable CreatedAt = new MLModelFilterVariable("CreatedAt");
        /// <summary>
        /// Constant IAMUser for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable IAMUser = new MLModelFilterVariable("IAMUser");
        /// <summary>
        /// Constant LastUpdatedAt for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable LastUpdatedAt = new MLModelFilterVariable("LastUpdatedAt");
        /// <summary>
        /// Constant MLModelType for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable MLModelType = new MLModelFilterVariable("MLModelType");
        /// <summary>
        /// Constant Name for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable Name = new MLModelFilterVariable("Name");
        /// <summary>
        /// Constant RealtimeEndpointStatus for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable RealtimeEndpointStatus = new MLModelFilterVariable("RealtimeEndpointStatus");
        /// <summary>
        /// Constant Status for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable Status = new MLModelFilterVariable("Status");
        /// <summary>
        /// Constant TrainingDataSourceId for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable TrainingDataSourceId = new MLModelFilterVariable("TrainingDataSourceId");
        /// <summary>
        /// Constant TrainingDataURI for MLModelFilterVariable
        /// </summary>
        public static readonly MLModelFilterVariable TrainingDataURI = new MLModelFilterVariable("TrainingDataURI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MLModelFilterVariable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MLModelFilterVariable FindValue(string value)
        {
            return FindValue<MLModelFilterVariable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MLModelFilterVariable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MLModelType.
    /// </summary>
    public class MLModelType : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for MLModelType
        /// </summary>
        public static readonly MLModelType BINARY = new MLModelType("BINARY");
        /// <summary>
        /// Constant MULTICLASS for MLModelType
        /// </summary>
        public static readonly MLModelType MULTICLASS = new MLModelType("MULTICLASS");
        /// <summary>
        /// Constant REGRESSION for MLModelType
        /// </summary>
        public static readonly MLModelType REGRESSION = new MLModelType("REGRESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MLModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MLModelType FindValue(string value)
        {
            return FindValue<MLModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MLModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealtimeEndpointStatus.
    /// </summary>
    public class RealtimeEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RealtimeEndpointStatus
        /// </summary>
        public static readonly RealtimeEndpointStatus FAILED = new RealtimeEndpointStatus("FAILED");
        /// <summary>
        /// Constant NONE for RealtimeEndpointStatus
        /// </summary>
        public static readonly RealtimeEndpointStatus NONE = new RealtimeEndpointStatus("NONE");
        /// <summary>
        /// Constant READY for RealtimeEndpointStatus
        /// </summary>
        public static readonly RealtimeEndpointStatus READY = new RealtimeEndpointStatus("READY");
        /// <summary>
        /// Constant UPDATING for RealtimeEndpointStatus
        /// </summary>
        public static readonly RealtimeEndpointStatus UPDATING = new RealtimeEndpointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealtimeEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealtimeEndpointStatus FindValue(string value)
        {
            return FindValue<RealtimeEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealtimeEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Asc for SortOrder
        /// </summary>
        public static readonly SortOrder Asc = new SortOrder("asc");
        /// <summary>
        /// Constant Dsc for SortOrder
        /// </summary>
        public static readonly SortOrder Dsc = new SortOrder("dsc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaggableResourceType.
    /// </summary>
    public class TaggableResourceType : ConstantClass
    {

        /// <summary>
        /// Constant BatchPrediction for TaggableResourceType
        /// </summary>
        public static readonly TaggableResourceType BatchPrediction = new TaggableResourceType("BatchPrediction");
        /// <summary>
        /// Constant DataSource for TaggableResourceType
        /// </summary>
        public static readonly TaggableResourceType DataSource = new TaggableResourceType("DataSource");
        /// <summary>
        /// Constant Evaluation for TaggableResourceType
        /// </summary>
        public static readonly TaggableResourceType Evaluation = new TaggableResourceType("Evaluation");
        /// <summary>
        /// Constant MLModel for TaggableResourceType
        /// </summary>
        public static readonly TaggableResourceType MLModel = new TaggableResourceType("MLModel");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaggableResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaggableResourceType FindValue(string value)
        {
            return FindValue<TaggableResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaggableResourceType(string value)
        {
            return FindValue(value);
        }
    }

}