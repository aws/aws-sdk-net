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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LookoutforVision
{

    /// <summary>
    /// Constants used for properties of type DatasetStatus.
    /// </summary>
    public class DatasetStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_COMPLETE = new DatasetStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_FAILED = new DatasetStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_IN_PROGRESS = new DatasetStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETE_COMPLETE = new DatasetStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETE_FAILED = new DatasetStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETE_IN_PROGRESS = new DatasetStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_COMPLETE = new DatasetStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED_ROLLBACK_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_FAILED_ROLLBACK_COMPLETE = new DatasetStatus("UPDATE_FAILED_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED_ROLLBACK_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_FAILED_ROLLBACK_IN_PROGRESS = new DatasetStatus("UPDATE_FAILED_ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_IN_PROGRESS = new DatasetStatus("UPDATE_IN_PROGRESS");

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
    /// Constants used for properties of type ModelHostingStatus.
    /// </summary>
    public class ModelHostingStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus FAILED = new ModelHostingStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus RUNNING = new ModelHostingStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus STARTING = new ModelHostingStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus STOPPED = new ModelHostingStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelHostingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelHostingStatus FindValue(string value)
        {
            return FindValue<ModelHostingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelHostingStatus(string value)
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
        /// Constant DELETING for ModelStatus
        /// </summary>
        public static readonly ModelStatus DELETING = new ModelStatus("DELETING");
        /// <summary>
        /// Constant HOSTED for ModelStatus
        /// </summary>
        public static readonly ModelStatus HOSTED = new ModelStatus("HOSTED");
        /// <summary>
        /// Constant HOSTING_FAILED for ModelStatus
        /// </summary>
        public static readonly ModelStatus HOSTING_FAILED = new ModelStatus("HOSTING_FAILED");
        /// <summary>
        /// Constant STARTING_HOSTING for ModelStatus
        /// </summary>
        public static readonly ModelStatus STARTING_HOSTING = new ModelStatus("STARTING_HOSTING");
        /// <summary>
        /// Constant STOPPING_HOSTING for ModelStatus
        /// </summary>
        public static readonly ModelStatus STOPPING_HOSTING = new ModelStatus("STOPPING_HOSTING");
        /// <summary>
        /// Constant SYSTEM_UPDATING for ModelStatus
        /// </summary>
        public static readonly ModelStatus SYSTEM_UPDATING = new ModelStatus("SYSTEM_UPDATING");
        /// <summary>
        /// Constant TRAINED for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINED = new ModelStatus("TRAINED");
        /// <summary>
        /// Constant TRAINING for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINING = new ModelStatus("TRAINING");
        /// <summary>
        /// Constant TRAINING_FAILED for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINING_FAILED = new ModelStatus("TRAINING_FAILED");

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
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant DATASET for ResourceType
        /// </summary>
        public static readonly ResourceType DATASET = new ResourceType("DATASET");
        /// <summary>
        /// Constant MODEL for ResourceType
        /// </summary>
        public static readonly ResourceType MODEL = new ResourceType("MODEL");
        /// <summary>
        /// Constant PROJECT for ResourceType
        /// </summary>
        public static readonly ResourceType PROJECT = new ResourceType("PROJECT");
        /// <summary>
        /// Constant TRIAL for ResourceType
        /// </summary>
        public static readonly ResourceType TRIAL = new ResourceType("TRIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }

}