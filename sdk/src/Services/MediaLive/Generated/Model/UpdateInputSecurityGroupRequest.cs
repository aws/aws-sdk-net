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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInputSecurityGroup operation.
    /// Update an Input Security Group's Whilelists.
    /// </summary>
    public partial class UpdateInputSecurityGroupRequest : AmazonMediaLiveRequest
    {
        private string _inputSecurityGroupId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<InputWhitelistRuleCidr> _whitelistRules = AWSConfigs.InitializeCollections ? new List<InputWhitelistRuleCidr>() : null;

        /// <summary>
        /// Gets and sets the property InputSecurityGroupId. The id of the Input Security Group
        /// to update.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputSecurityGroupId
        {
            get { return this._inputSecurityGroupId; }
            set { this._inputSecurityGroupId = value; }
        }

        // Check to see if InputSecurityGroupId property is set
        internal bool IsSetInputSecurityGroupId()
        {
            return this._inputSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This API is deprecated. You must use UpdateTagsForResource instead.")]
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

        /// <summary>
        /// Gets and sets the property WhitelistRules. List of IPv4 CIDR addresses to whitelist
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputWhitelistRuleCidr> WhitelistRules
        {
            get { return this._whitelistRules; }
            set { this._whitelistRules = value; }
        }

        // Check to see if WhitelistRules property is set
        internal bool IsSetWhitelistRules()
        {
            return this._whitelistRules != null && (this._whitelistRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}