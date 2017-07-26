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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an Elastic GPU.
    /// </summary>
    public partial class ElasticGpus
    {
        private string _availabilityZone;
        private ElasticGpuHealth _elasticGpuHealth;
        private string _elasticGpuId;
        private ElasticGpuState _elasticGpuState;
        private string _elasticGpuType;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in the which the Elastic GPU resides.
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
        /// The status of the Elastic GPU.
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
        /// The ID of the Elastic GPU.
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
        /// The state of the Elastic GPU.
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
        /// The type of Elastic GPU.
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
        /// The ID of the instance to which the Elastic GPU is attached.
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

    }
}