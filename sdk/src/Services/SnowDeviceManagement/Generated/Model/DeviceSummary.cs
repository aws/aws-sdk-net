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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
        private string _associatedWithJob;
        private string _managedDeviceArn;
        private string _managedDeviceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedWithJob. 
        /// <para>
        /// The ID of the job used to order the device.
        /// </para>
        /// </summary>
        public string AssociatedWithJob
        {
            get { return this._associatedWithJob; }
            set { this._associatedWithJob = value; }
        }

        // Check to see if AssociatedWithJob property is set
        internal bool IsSetAssociatedWithJob()
        {
            return this._associatedWithJob != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedDeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        public string ManagedDeviceArn
        {
            get { return this._managedDeviceArn; }
            set { this._managedDeviceArn = value; }
        }

        // Check to see if ManagedDeviceArn property is set
        internal bool IsSetManagedDeviceArn()
        {
            return this._managedDeviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedDeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedDeviceId
        {
            get { return this._managedDeviceId; }
            set { this._managedDeviceId = value; }
        }

        // Check to see if ManagedDeviceId property is set
        internal bool IsSetManagedDeviceId()
        {
            return this._managedDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. You can use tags to categorize a
        /// resource in different ways, such as by purpose, owner, or environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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