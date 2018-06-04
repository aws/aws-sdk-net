/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMaker
{

    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for CompressionType
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("Gzip");
        /// <summary>
        /// Constant None for CompressionType
        /// </summary>
        public static readonly CompressionType None = new CompressionType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectInternetAccess.
    /// </summary>
    public class DirectInternetAccess : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Disabled = new DirectInternetAccess("Disabled");
        /// <summary>
        /// Constant Enabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Enabled = new DirectInternetAccess("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectInternetAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectInternetAccess FindValue(string value)
        {
            return FindValue<DirectInternetAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectInternetAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointConfigSortKey.
    /// </summary>
    public class EndpointConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey CreationTime = new EndpointConfigSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey Name = new EndpointConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointConfigSortKey FindValue(string value)
        {
            return FindValue<EndpointConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointSortKey.
    /// </summary>
    public class EndpointSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey CreationTime = new EndpointSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Name = new EndpointSortKey("Name");
        /// <summary>
        /// Constant Status for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Status = new EndpointSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointSortKey FindValue(string value)
        {
            return FindValue<EndpointSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Creating = new EndpointStatus("Creating");
        /// <summary>
        /// Constant Deleting for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleting = new EndpointStatus("Deleting");
        /// <summary>
        /// Constant Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Failed = new EndpointStatus("Failed");
        /// <summary>
        /// Constant InService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus InService = new EndpointStatus("InService");
        /// <summary>
        /// Constant OutOfService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus OutOfService = new EndpointStatus("OutOfService");
        /// <summary>
        /// Constant RollingBack for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus RollingBack = new EndpointStatus("RollingBack");
        /// <summary>
        /// Constant Updating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Updating = new EndpointStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobObjectiveType.
    /// </summary>
    public class HyperParameterTuningJobObjectiveType : ConstantClass
    {

        /// <summary>
        /// Constant Maximize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Maximize = new HyperParameterTuningJobObjectiveType("Maximize");
        /// <summary>
        /// Constant Minimize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Minimize = new HyperParameterTuningJobObjectiveType("Minimize");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobObjectiveType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobObjectiveType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobObjectiveType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobObjectiveType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobSortByOptions.
    /// </summary>
    public class HyperParameterTuningJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions CreationTime = new HyperParameterTuningJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant Name for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Name = new HyperParameterTuningJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Status = new HyperParameterTuningJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobSortByOptions FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStatus.
    /// </summary>
    public class HyperParameterTuningJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Completed = new HyperParameterTuningJobStatus("Completed");
        /// <summary>
        /// Constant Failed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Failed = new HyperParameterTuningJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus InProgress = new HyperParameterTuningJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopped = new HyperParameterTuningJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopping = new HyperParameterTuningJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStatus FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStrategyType.
    /// </summary>
    public class HyperParameterTuningJobStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Bayesian for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Bayesian = new HyperParameterTuningJobStrategyType("Bayesian");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStrategyType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStrategyType(string value)
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
        /// Constant MlT22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT22xlarge = new InstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Large = new InstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Medium = new InstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Xlarge = new InstanceType("ml.t2.xlarge");

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
    /// Constants used for properties of type ModelSortKey.
    /// </summary>
    public class ModelSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey CreationTime = new ModelSortKey("CreationTime");
        /// <summary>
        /// Constant Name for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey Name = new ModelSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelSortKey FindValue(string value)
        {
            return FindValue<ModelSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortKey.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey CreationTime = new NotebookInstanceLifecycleConfigSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey LastModifiedTime = new NotebookInstanceLifecycleConfigSortKey("LastModifiedTime");
        /// <summary>
        /// Constant Name for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey Name = new NotebookInstanceLifecycleConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortOrder.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Ascending = new NotebookInstanceLifecycleConfigSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Descending = new NotebookInstanceLifecycleConfigSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortKey.
    /// </summary>
    public class NotebookInstanceSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey CreationTime = new NotebookInstanceSortKey("CreationTime");
        /// <summary>
        /// Constant Name for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Name = new NotebookInstanceSortKey("Name");
        /// <summary>
        /// Constant Status for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Status = new NotebookInstanceSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortOrder.
    /// </summary>
    public class NotebookInstanceSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Ascending = new NotebookInstanceSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Descending = new NotebookInstanceSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceStatus.
    /// </summary>
    public class NotebookInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Deleting = new NotebookInstanceStatus("Deleting");
        /// <summary>
        /// Constant Failed for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Failed = new NotebookInstanceStatus("Failed");
        /// <summary>
        /// Constant InService for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus InService = new NotebookInstanceStatus("InService");
        /// <summary>
        /// Constant Pending for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Pending = new NotebookInstanceStatus("Pending");
        /// <summary>
        /// Constant Stopped for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopped = new NotebookInstanceStatus("Stopped");
        /// <summary>
        /// Constant Stopping for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopping = new NotebookInstanceStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceStatus FindValue(string value)
        {
            return FindValue<NotebookInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectiveStatus.
    /// </summary>
    public class ObjectiveStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Failed = new ObjectiveStatus("Failed");
        /// <summary>
        /// Constant Pending for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Pending = new ObjectiveStatus("Pending");
        /// <summary>
        /// Constant Succeeded for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Succeeded = new ObjectiveStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectiveStatus FindValue(string value)
        {
            return FindValue<ObjectiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectiveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderKey.
    /// </summary>
    public class OrderKey : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderKey
        /// </summary>
        public static readonly OrderKey Ascending = new OrderKey("Ascending");
        /// <summary>
        /// Constant Descending for OrderKey
        /// </summary>
        public static readonly OrderKey Descending = new OrderKey("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderKey FindValue(string value)
        {
            return FindValue<OrderKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductionVariantInstanceType.
    /// </summary>
    public class ProductionVariantInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC42xlarge = new ProductionVariantInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC44xlarge = new ProductionVariantInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC48xlarge = new ProductionVariantInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Large = new ProductionVariantInstanceType("ml.c4.large");
        /// <summary>
        /// Constant MlC4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Xlarge = new ProductionVariantInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC518xlarge = new ProductionVariantInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC52xlarge = new ProductionVariantInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC54xlarge = new ProductionVariantInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC59xlarge = new ProductionVariantInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Large = new ProductionVariantInstanceType("ml.c5.large");
        /// <summary>
        /// Constant MlC5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Xlarge = new ProductionVariantInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM410xlarge = new ProductionVariantInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM416xlarge = new ProductionVariantInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM42xlarge = new ProductionVariantInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM44xlarge = new ProductionVariantInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM4Xlarge = new ProductionVariantInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM512xlarge = new ProductionVariantInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM524xlarge = new ProductionVariantInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM52xlarge = new ProductionVariantInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM54xlarge = new ProductionVariantInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Large = new ProductionVariantInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Xlarge = new ProductionVariantInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP216xlarge = new ProductionVariantInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP28xlarge = new ProductionVariantInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP2Xlarge = new ProductionVariantInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP316xlarge = new ProductionVariantInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP32xlarge = new ProductionVariantInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP38xlarge = new ProductionVariantInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlT22xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT22xlarge = new ProductionVariantInstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Large = new ProductionVariantInstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Medium = new ProductionVariantInstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Xlarge = new ProductionVariantInstanceType("ml.t2.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductionVariantInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductionVariantInstanceType FindValue(string value)
        {
            return FindValue<ProductionVariantInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductionVariantInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordWrapper.
    /// </summary>
    public class RecordWrapper : ConstantClass
    {

        /// <summary>
        /// Constant None for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper None = new RecordWrapper("None");
        /// <summary>
        /// Constant RecordIO for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper RecordIO = new RecordWrapper("RecordIO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordWrapper(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordWrapper FindValue(string value)
        {
            return FindValue<RecordWrapper>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordWrapper(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataDistribution.
    /// </summary>
    public class S3DataDistribution : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution FullyReplicated = new S3DataDistribution("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution ShardedByS3Key = new S3DataDistribution("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataDistribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataDistribution FindValue(string value)
        {
            return FindValue<S3DataDistribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataDistribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataType.
    /// </summary>
    public class S3DataType : ConstantClass
    {

        /// <summary>
        /// Constant ManifestFile for S3DataType
        /// </summary>
        public static readonly S3DataType ManifestFile = new S3DataType("ManifestFile");
        /// <summary>
        /// Constant S3Prefix for S3DataType
        /// </summary>
        public static readonly S3DataType S3Prefix = new S3DataType("S3Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataType FindValue(string value)
        {
            return FindValue<S3DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecondaryStatus.
    /// </summary>
    public class SecondaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Completed = new SecondaryStatus("Completed");
        /// <summary>
        /// Constant Downloading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Downloading = new SecondaryStatus("Downloading");
        /// <summary>
        /// Constant Failed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Failed = new SecondaryStatus("Failed");
        /// <summary>
        /// Constant MaxRuntimeExceeded for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus MaxRuntimeExceeded = new SecondaryStatus("MaxRuntimeExceeded");
        /// <summary>
        /// Constant Starting for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Starting = new SecondaryStatus("Starting");
        /// <summary>
        /// Constant Stopped for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopped = new SecondaryStatus("Stopped");
        /// <summary>
        /// Constant Stopping for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopping = new SecondaryStatus("Stopping");
        /// <summary>
        /// Constant Training for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Training = new SecondaryStatus("Training");
        /// <summary>
        /// Constant Uploading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Uploading = new SecondaryStatus("Uploading");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecondaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecondaryStatus FindValue(string value)
        {
            return FindValue<SecondaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecondaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortBy
        /// </summary>
        public static readonly SortBy CreationTime = new SortBy("CreationTime");
        /// <summary>
        /// Constant Name for SortBy
        /// </summary>
        public static readonly SortBy Name = new SortBy("Name");
        /// <summary>
        /// Constant Status for SortBy
        /// </summary>
        public static readonly SortBy Status = new SortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortBy FindValue(string value)
        {
            return FindValue<SortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortBy(string value)
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
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

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
    /// Constants used for properties of type TrainingInputMode.
    /// </summary>
    public class TrainingInputMode : ConstantClass
    {

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
    /// Constants used for properties of type TrainingInstanceType.
    /// </summary>
    public class TrainingInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC42xlarge = new TrainingInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC44xlarge = new TrainingInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC48xlarge = new TrainingInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC4Xlarge = new TrainingInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC518xlarge = new TrainingInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC52xlarge = new TrainingInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC54xlarge = new TrainingInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC59xlarge = new TrainingInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5Xlarge = new TrainingInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM410xlarge = new TrainingInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM416xlarge = new TrainingInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM42xlarge = new TrainingInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM44xlarge = new TrainingInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM4Xlarge = new TrainingInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM512xlarge = new TrainingInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM524xlarge = new TrainingInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM52xlarge = new TrainingInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM54xlarge = new TrainingInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Large = new TrainingInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Xlarge = new TrainingInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP216xlarge = new TrainingInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP28xlarge = new TrainingInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP2Xlarge = new TrainingInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP316xlarge = new TrainingInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP32xlarge = new TrainingInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP38xlarge = new TrainingInstanceType("ml.p3.8xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInstanceType FindValue(string value)
        {
            return FindValue<TrainingInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobSortByOptions.
    /// </summary>
    public class TrainingJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions CreationTime = new TrainingJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant FinalObjectiveMetricValue for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions FinalObjectiveMetricValue = new TrainingJobSortByOptions("FinalObjectiveMetricValue");
        /// <summary>
        /// Constant Name for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Name = new TrainingJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Status = new TrainingJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobSortByOptions FindValue(string value)
        {
            return FindValue<TrainingJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobStatus.
    /// </summary>
    public class TrainingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Completed = new TrainingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Failed = new TrainingJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus InProgress = new TrainingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopped = new TrainingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopping = new TrainingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobStatus FindValue(string value)
        {
            return FindValue<TrainingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobStatus(string value)
        {
            return FindValue(value);
        }
    }

}