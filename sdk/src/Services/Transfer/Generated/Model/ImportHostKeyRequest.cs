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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ImportHostKey operation.
    /// Adds a host key to the server that's specified by the <code>ServerId</code> parameter.
    /// </summary>
    public partial class ImportHostKeyRequest : AmazonTransferRequest
    {
        private string _description;
        private string _hostKeyBody;
        private string _serverId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The text description that identifies this host key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HostKeyBody. 
        /// <para>
        /// The private key portion of an SSH key pair.
        /// </para>
        ///  
        /// <para>
        /// Transfer Family accepts RSA, ECDSA, and ED25519 keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=4096)]
        public string HostKeyBody
        {
            get { return this._hostKeyBody; }
            set { this._hostKeyBody = value; }
        }

        // Check to see if HostKeyBody property is set
        internal bool IsSetHostKeyBody()
        {
            return this._hostKeyBody != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// The identifier of the server that contains the host key that you are importing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for host keys.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}