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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes an Elastic Graphics accelerator.
    /// </para>
    /// </summary>
    public partial class ElasticGpus
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in the which the Elastic Graphics accelerator resides.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuHealth. 
        /// <para>
        /// The status of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public ElasticGpuHealth ElasticGpuHealth { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuHealth property is set.
        /// </summary>
        internal bool IsSetElasticGpuHealth() => this.ElasticGpuHealth != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuId. 
        /// <para>
        /// The ID of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuId { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuId property is set.
        /// </summary>
        internal bool IsSetElasticGpuId() => this.ElasticGpuId != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuState. 
        /// <para>
        /// The state of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public ElasticGpuState ElasticGpuState { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuState property is set.
        /// </summary>
        internal bool IsSetElasticGpuState() => this.ElasticGpuState != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuType. 
        /// <para>
        /// The type of Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuType { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuType property is set.
        /// </summary>
        internal bool IsSetElasticGpuType() => this.ElasticGpuType != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to which the Elastic Graphics accelerator is attached.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Elastic Graphics accelerator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
