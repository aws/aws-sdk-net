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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
    /// Container for the parameters to the UpdateSecurityGroup operation.
    /// Updates the properties of an existing security group in a Wickr network, such as its
    /// name or settings.
    /// </summary>
    public partial class UpdateSecurityGroupRequest : AmazonWickrRequest
    {
        private string _groupId;
        private string _name;
        private string _networkId;
        private SecurityGroupSettings _securityGroupSettings;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The unique identifier of the security group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the security group.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the security group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

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
        public SecurityGroupSettings SecurityGroupSettings
        {
            get { return this._securityGroupSettings; }
            set { this._securityGroupSettings = value; }
        }

        // Check to see if SecurityGroupSettings property is set
        internal bool IsSetSecurityGroupSettings()
        {
            return this._securityGroupSettings != null;
        }

    }
}