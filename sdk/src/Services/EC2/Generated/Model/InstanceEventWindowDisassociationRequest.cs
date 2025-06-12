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
    /// The targets to disassociate from the specified event window.
    /// </summary>
    public partial class InstanceEventWindowDisassociationRequest
    {
        private List<string> _dedicatedHostIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _instanceTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DedicatedHostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts to disassociate from the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DedicatedHostIds
        {
            get { return this._dedicatedHostIds; }
            set { this._dedicatedHostIds = value; }
        }

        // Check to see if DedicatedHostIds property is set
        internal bool IsSetDedicatedHostIds()
        {
            return this._dedicatedHostIds != null && (this._dedicatedHostIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances to disassociate from the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceTags. 
        /// <para>
        /// The instance tags to disassociate from the event window. Any instances associated
        /// with the tags will be disassociated from the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> InstanceTags
        {
            get { return this._instanceTags; }
            set { this._instanceTags = value; }
        }

        // Check to see if InstanceTags property is set
        internal bool IsSetInstanceTags()
        {
            return this._instanceTags != null && (this._instanceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}