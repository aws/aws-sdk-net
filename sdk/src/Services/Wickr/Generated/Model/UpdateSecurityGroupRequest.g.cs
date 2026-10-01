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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityGroup operation. Updates the properties
    /// of an existing security group in a Wickr network, such as its name or settings.
    /// </summary>
    public partial class UpdateSecurityGroupRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The unique identifier of the security group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the security group.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the security group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupSettings. 
        /// <para>
        /// The updated configuration settings for the security group.
        /// </para>
        ///  
        /// <para>
        /// Federation mode - 0 (Local federation), 1 (Restricted federation), 2 (Global federation)
        /// 
        /// </para>
        /// </summary>
        public SecurityGroupSettings SecurityGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupSettings property is set.
        /// </summary>
        internal bool IsSetSecurityGroupSettings() => this.SecurityGroupSettings != null;
    }
}
