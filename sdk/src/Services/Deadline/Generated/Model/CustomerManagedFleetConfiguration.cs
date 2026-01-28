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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The configuration details for a customer managed fleet.
    /// </summary>
    public partial class CustomerManagedFleetConfiguration
    {
        private AutoScalingMode _mode;
        private string _storageProfileId;
        private TagPropagationMode _tagPropagationMode;
        private CustomerManagedWorkerCapabilities _workerCapabilities;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The Auto Scaling mode for the customer managed fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoScalingMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID for the customer managed fleet.
        /// </para>
        /// </summary>
        public string StorageProfileId
        {
            get { return this._storageProfileId; }
            set { this._storageProfileId = value; }
        }

        // Check to see if StorageProfileId property is set
        internal bool IsSetStorageProfileId()
        {
            return this._storageProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property TagPropagationMode. 
        /// <para>
        /// The tag propagation mode for the customer managed fleet.
        /// </para>
        /// </summary>
        public TagPropagationMode TagPropagationMode
        {
            get { return this._tagPropagationMode; }
            set { this._tagPropagationMode = value; }
        }

        // Check to see if TagPropagationMode property is set
        internal bool IsSetTagPropagationMode()
        {
            return this._tagPropagationMode != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerCapabilities. 
        /// <para>
        /// The worker capabilities for the customer managed fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomerManagedWorkerCapabilities WorkerCapabilities
        {
            get { return this._workerCapabilities; }
            set { this._workerCapabilities = value; }
        }

        // Check to see if WorkerCapabilities property is set
        internal bool IsSetWorkerCapabilities()
        {
            return this._workerCapabilities != null;
        }

    }
}