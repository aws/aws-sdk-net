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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelay operation.
    /// Creates a relay resource which can be used in rules to relay incoming emails to defined
    /// relay destinations.
    /// </summary>
    public partial class CreateRelayRequest : AmazonMailManagerRequest
    {
        private RelayAuthentication _authentication;
        private string _clientToken;
        private string _relayName;
        private string _serverName;
        private int? _serverPort;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Authentication for the relay destination server—specify the secretARN where the SMTP
        /// credentials are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelayAuthentication Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that Amazon SES uses to recognize subsequent retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property RelayName. 
        /// <para>
        /// The unique name of the relay resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RelayName
        {
            get { return this._relayName; }
            set { this._relayName = value; }
        }

        // Check to see if RelayName property is set
        internal bool IsSetRelayName()
        {
            return this._relayName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The destination relay server address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The destination relay server port.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? ServerPort
        {
            get { return this._serverPort; }
            set { this._serverPort = value; }
        }

        // Check to see if ServerPort property is set
        internal bool IsSetServerPort()
        {
            return this._serverPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for the resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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