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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes proposed changes to a network function group.
    /// </summary>
    public partial class ProposedNetworkFunctionGroupChange
    {
        private int? _attachmentPolicyRuleNumber;
        private string _networkFunctionGroupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentPolicyRuleNumber. 
        /// <para>
        /// The proposed new attachment policy rule number for the network function group.
        /// </para>
        /// </summary>
        public int? AttachmentPolicyRuleNumber
        {
            get { return this._attachmentPolicyRuleNumber; }
            set { this._attachmentPolicyRuleNumber = value; }
        }

        // Check to see if AttachmentPolicyRuleNumber property is set
        internal bool IsSetAttachmentPolicyRuleNumber()
        {
            return this._attachmentPolicyRuleNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The proposed name change for the network function group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NetworkFunctionGroupName
        {
            get { return this._networkFunctionGroupName; }
            set { this._networkFunctionGroupName = value; }
        }

        // Check to see if NetworkFunctionGroupName property is set
        internal bool IsSetNetworkFunctionGroupName()
        {
            return this._networkFunctionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of proposed changes to the key-value tags associated with the network function
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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