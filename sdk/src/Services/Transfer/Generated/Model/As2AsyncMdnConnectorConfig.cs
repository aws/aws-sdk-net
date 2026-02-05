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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains the configuration details for asynchronous Message Disposition Notification
    /// (MDN) responses in AS2 connectors. This configuration specifies where asynchronous
    /// MDN responses should be sent and which servers should handle them.
    /// </summary>
    public partial class As2AsyncMdnConnectorConfig
    {
        private List<string> _serverIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _url;

        /// <summary>
        /// Gets and sets the property ServerIds. 
        /// <para>
        /// A list of server identifiers that can handle asynchronous MDN responses. You can specify
        /// between 1 and 10 server IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ServerIds
        {
            get { return this._serverIds; }
            set { this._serverIds = value; }
        }

        // Check to see if ServerIds property is set
        internal bool IsSetServerIds()
        {
            return this._serverIds != null && (this._serverIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL endpoint where asynchronous MDN responses should be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}