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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// The details of an Elastic Inference Accelerator.
    /// </summary>
    public partial class ElasticInferenceAccelerator
    {
        private ElasticInferenceAcceleratorHealth _acceleratorHealth;
        private string _acceleratorId;
        private string _acceleratorType;
        private string _attachedResource;
        private string _availabilityZone;

        /// <summary>
        /// Gets and sets the property AcceleratorHealth. 
        /// <para>
        ///  The health of the Elastic Inference Accelerator. 
        /// </para>
        /// </summary>
        public ElasticInferenceAcceleratorHealth AcceleratorHealth
        {
            get { return this._acceleratorHealth; }
            set { this._acceleratorHealth = value; }
        }

        // Check to see if AcceleratorHealth property is set
        internal bool IsSetAcceleratorHealth()
        {
            return this._acceleratorHealth != null;
        }

        /// <summary>
        /// Gets and sets the property AcceleratorId. 
        /// <para>
        ///  The ID of the Elastic Inference Accelerator. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AcceleratorId
        {
            get { return this._acceleratorId; }
            set { this._acceleratorId = value; }
        }

        // Check to see if AcceleratorId property is set
        internal bool IsSetAcceleratorId()
        {
            return this._acceleratorId != null;
        }

        /// <summary>
        /// Gets and sets the property AcceleratorType. 
        /// <para>
        ///  The type of the Elastic Inference Accelerator. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AcceleratorType
        {
            get { return this._acceleratorType; }
            set { this._acceleratorType = value; }
        }

        // Check to see if AcceleratorType property is set
        internal bool IsSetAcceleratorType()
        {
            return this._acceleratorType != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedResource. 
        /// <para>
        ///  The ARN of the resource that the Elastic Inference Accelerator is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string AttachedResource
        {
            get { return this._attachedResource; }
            set { this._attachedResource = value; }
        }

        // Check to see if AttachedResource property is set
        internal bool IsSetAttachedResource()
        {
            return this._attachedResource != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The availability zone where the Elastic Inference Accelerator is present. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

    }
}