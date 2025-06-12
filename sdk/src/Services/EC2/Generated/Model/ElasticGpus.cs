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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _availabilityZone;
        private ElasticGpuHealth _elasticGpuHealth;
        private string _elasticGpuId;
        private ElasticGpuState _elasticGpuState;
        private string _elasticGpuType;
        private string _instanceId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in the which the Elastic Graphics accelerator resides.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuHealth. 
        /// <para>
        /// The status of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public ElasticGpuHealth ElasticGpuHealth
        {
            get { return this._elasticGpuHealth; }
            set { this._elasticGpuHealth = value; }
        }

        // Check to see if ElasticGpuHealth property is set
        internal bool IsSetElasticGpuHealth()
        {
            return this._elasticGpuHealth != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuId. 
        /// <para>
        /// The ID of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuId
        {
            get { return this._elasticGpuId; }
            set { this._elasticGpuId = value; }
        }

        // Check to see if ElasticGpuId property is set
        internal bool IsSetElasticGpuId()
        {
            return this._elasticGpuId != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuState. 
        /// <para>
        /// The state of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public ElasticGpuState ElasticGpuState
        {
            get { return this._elasticGpuState; }
            set { this._elasticGpuState = value; }
        }

        // Check to see if ElasticGpuState property is set
        internal bool IsSetElasticGpuState()
        {
            return this._elasticGpuState != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuType. 
        /// <para>
        /// The type of Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuType
        {
            get { return this._elasticGpuType; }
            set { this._elasticGpuType = value; }
        }

        // Check to see if ElasticGpuType property is set
        internal bool IsSetElasticGpuType()
        {
            return this._elasticGpuType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to which the Elastic Graphics accelerator is attached.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Elastic Graphics accelerator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}