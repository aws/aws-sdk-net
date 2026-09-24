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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Identifying information about the device.
    /// </summary>
    public partial class DeviceSummary
    {
        /// <summary>
        /// Gets and sets the property AssociatedWithJob. 
        /// <para>
        /// The ID of the job used to order the device.
        /// </para>
        /// </summary>
        public string AssociatedWithJob { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedWithJob property is set.
        /// </summary>
        internal bool IsSetAssociatedWithJob() => this.AssociatedWithJob != null;

        /// <summary>
        /// Gets and sets the property ManagedDeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        public string ManagedDeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDeviceArn property is set.
        /// </summary>
        internal bool IsSetManagedDeviceArn() => this.ManagedDeviceArn != null;

        /// <summary>
        /// Gets and sets the property ManagedDeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ManagedDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDeviceId property is set.
        /// </summary>
        internal bool IsSetManagedDeviceId() => this.ManagedDeviceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. You can use tags to categorize a
        /// resource in different ways, such as by purpose, owner, or environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
