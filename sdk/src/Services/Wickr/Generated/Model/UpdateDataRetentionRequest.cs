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
    /// Container for the parameters to the UpdateDataRetention operation.
    /// Updates the data retention bot settings, allowing you to enable or disable the data
    /// retention service, or acknowledge the public key message.
    /// </summary>
    public partial class UpdateDataRetentionRequest : AmazonWickrRequest
    {
        private DataRetentionActionType _actionType;
        private string _networkId;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The action to perform. Valid values are 'ENABLE' (to enable the data retention service),
        /// 'DISABLE' (to disable the service), or 'PUBKEY_MSG_ACK' (to acknowledge the public
        /// key message).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataRetentionActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the data retention bot.
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

    }
}