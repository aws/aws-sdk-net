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
    /// One or more targets associated with the specified event window. Only one <i>type</i>
    /// of target (instance ID, instance tag, or Dedicated Host ID) can be associated with
    /// an event window.
    /// </summary>
    public partial class InstanceEventWindowAssociationRequest
    {
        private List<string> _dedicatedHostIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _instanceTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DedicatedHostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts to associate with the event window.
        /// </para>
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
        /// The IDs of the instances to associate with the event window. If the instance is on
        /// a Dedicated Host, you can't specify the Instance ID parameter; you must use the Dedicated
        /// Host ID parameter.
        /// </para>
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
        /// The instance tags to associate with the event window. Any instances associated with
        /// the tags will be associated with the event window.
        /// </para>
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