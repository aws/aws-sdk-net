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
        /// Constant HOSTED for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus HOSTED = new ModelHostingStatus("HOSTED");
        /// <summary>
        /// Constant HOSTING_FAILED for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus HOSTING_FAILED = new ModelHostingStatus("HOSTING_FAILED");
        /// <summary>
        /// Constant STARTING_HOSTING for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus STARTING_HOSTING = new ModelHostingStatus("STARTING_HOSTING");
        /// <summary>
        /// Constant STOPPING_HOSTING for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus STOPPING_HOSTING = new ModelHostingStatus("STOPPING_HOSTING");
        /// <summary>
        /// Constant SYSTEM_UPDATING for ModelHostingStatus
        /// </summary>
        public static readonly ModelHostingStatus SYSTEM_UPDATING = new ModelHostingStatus("SYSTEM_UPDATING");

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
    /// Constants used for properties of type ModelPackagingJobStatus.
    /// </summary>
    public class ModelPackagingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ModelPackagingJobStatus
        /// </summary>
        public static readonly ModelPackagingJobStatus CREATED = new ModelPackagingJobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for ModelPackagingJobStatus
        /// </summary>
        public static readonly ModelPackagingJobStatus FAILED = new ModelPackagingJobStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ModelPackagingJobStatus
        /// </summary>
        public static readonly ModelPackagingJobStatus RUNNING = new ModelPackagingJobStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for ModelPackagingJobStatus
        /// </summary>
        public static readonly ModelPackagingJobStatus SUCCEEDED = new ModelPackagingJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackagingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackagingJobStatus FindValue(string value)
        {
            return FindValue<ModelPackagingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackagingJobStatus(string value)
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
        /// Constant MODEL_PACKAGE_JOB for ResourceType
        /// </summary>
        public static readonly ResourceType MODEL_PACKAGE_JOB = new ResourceType("MODEL_PACKAGE_JOB");
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


    /// <summary>
    /// Constants used for properties of type TargetDevice.
    /// </summary>
    public class TargetDevice : ConstantClass
    {

        /// <summary>
        /// Constant Jetson_xavier for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_xavier = new TargetDevice("jetson_xavier");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDevice(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDevice FindValue(string value)
        {
            return FindValue<TargetDevice>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDevice(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformAccelerator.
    /// </summary>
    public class TargetPlatformAccelerator : ConstantClass
    {

        /// <summary>
        /// Constant NVIDIA for TargetPlatformAccelerator
        /// </summary>
        public static readonly TargetPlatformAccelerator NVIDIA = new TargetPlatformAccelerator("NVIDIA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformAccelerator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformAccelerator FindValue(string value)
        {
            return FindValue<TargetPlatformAccelerator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformAccelerator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformArch.
    /// </summary>
    public class TargetPlatformArch : ConstantClass
    {

        /// <summary>
        /// Constant ARM64 for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch ARM64 = new TargetPlatformArch("ARM64");
        /// <summary>
        /// Constant X86_64 for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch X86_64 = new TargetPlatformArch("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformArch(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformArch FindValue(string value)
        {
            return FindValue<TargetPlatformArch>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformArch(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformOs.
    /// </summary>
    public class TargetPlatformOs : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for TargetPlatformOs
        /// </summary>
        public static readonly TargetPlatformOs LINUX = new TargetPlatformOs("LINUX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformOs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformOs FindValue(string value)
        {
            return FindValue<TargetPlatformOs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformOs(string value)
        {
            return FindValue(value);
        }
    }

}