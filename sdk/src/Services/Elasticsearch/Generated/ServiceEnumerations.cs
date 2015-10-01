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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Elasticsearch
{

    /// <summary>
    /// Constants used for properties of type ESPartitionInstanceType.
    /// </summary>
    public class ESPartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant I22xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I22xlargeElasticsearch = new ESPartitionInstanceType("i2.2xlarge.elasticsearch");
        /// <summary>
        /// Constant I2XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I2XlargeElasticsearch = new ESPartitionInstanceType("i2.xlarge.elasticsearch");
        /// <summary>
        /// Constant M32xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M32xlargeElasticsearch = new ESPartitionInstanceType("m3.2xlarge.elasticsearch");
        /// <summary>
        /// Constant M3LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3LargeElasticsearch = new ESPartitionInstanceType("m3.large.elasticsearch");
        /// <summary>
        /// Constant M3MediumElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3MediumElasticsearch = new ESPartitionInstanceType("m3.medium.elasticsearch");
        /// <summary>
        /// Constant M3XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3XlargeElasticsearch = new ESPartitionInstanceType("m3.xlarge.elasticsearch");
        /// <summary>
        /// Constant R32xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R32xlargeElasticsearch = new ESPartitionInstanceType("r3.2xlarge.elasticsearch");
        /// <summary>
        /// Constant R34xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R34xlargeElasticsearch = new ESPartitionInstanceType("r3.4xlarge.elasticsearch");
        /// <summary>
        /// Constant R38xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R38xlargeElasticsearch = new ESPartitionInstanceType("r3.8xlarge.elasticsearch");
        /// <summary>
        /// Constant R3LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R3LargeElasticsearch = new ESPartitionInstanceType("r3.large.elasticsearch");
        /// <summary>
        /// Constant R3XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R3XlargeElasticsearch = new ESPartitionInstanceType("r3.xlarge.elasticsearch");
        /// <summary>
        /// Constant T2MediumElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2MediumElasticsearch = new ESPartitionInstanceType("t2.medium.elasticsearch");
        /// <summary>
        /// Constant T2MicroElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2MicroElasticsearch = new ESPartitionInstanceType("t2.micro.elasticsearch");
        /// <summary>
        /// Constant T2SmallElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2SmallElasticsearch = new ESPartitionInstanceType("t2.small.elasticsearch");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ESPartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ESPartitionInstanceType FindValue(string value)
        {
            return FindValue<ESPartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ESPartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptionState.
    /// </summary>
    public class OptionState : ConstantClass
    {

        /// <summary>
        /// Constant Active for OptionState
        /// </summary>
        public static readonly OptionState Active = new OptionState("Active");
        /// <summary>
        /// Constant Processing for OptionState
        /// </summary>
        public static readonly OptionState Processing = new OptionState("Processing");
        /// <summary>
        /// Constant RequiresIndexDocuments for OptionState
        /// </summary>
        public static readonly OptionState RequiresIndexDocuments = new OptionState("RequiresIndexDocuments");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionState FindValue(string value)
        {
            return FindValue<OptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }

}