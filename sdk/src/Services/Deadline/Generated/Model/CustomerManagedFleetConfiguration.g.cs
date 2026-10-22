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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The configuration details for a customer managed fleet.
    /// </summary>
    public partial class CustomerManagedFleetConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoScalingConfiguration. 
        /// <para>
        /// The auto scaling configuration settings for the customer managed fleet.
        /// </para>
        /// </summary>
        public CustomerManagedAutoScalingConfiguration AutoScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfiguration() => this.AutoScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The Auto Scaling mode for the customer managed fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoScalingMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID for the customer managed fleet.
        /// </para>
        /// </summary>
        public string StorageProfileId { get; set; }

        /// <summary>
        /// Checks to see if the StorageProfileId property is set.
        /// </summary>
        internal bool IsSetStorageProfileId() => this.StorageProfileId != null;

        /// <summary>
        /// Gets and sets the property TagPropagationMode. 
        /// <para>
        /// The tag propagation mode for the customer managed fleet.
        /// </para>
        /// </summary>
        public TagPropagationMode TagPropagationMode { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagationMode property is set.
        /// </summary>
        internal bool IsSetTagPropagationMode() => this.TagPropagationMode != null;

        /// <summary>
        /// Gets and sets the property WorkerCapabilities. 
        /// <para>
        /// The worker capabilities for the customer managed fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerManagedWorkerCapabilities WorkerCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the WorkerCapabilities property is set.
        /// </summary>
        internal bool IsSetWorkerCapabilities() => this.WorkerCapabilities != null;
    }
}
