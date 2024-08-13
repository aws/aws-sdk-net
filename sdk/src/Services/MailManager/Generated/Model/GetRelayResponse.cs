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
    /// This is the response object from the GetRelay operation.
    /// </summary>
    public partial class GetRelayResponse : AmazonWebServiceResponse
    {
        private RelayAuthentication _authentication;
        private DateTime? _createdTimestamp;
        private DateTime? _lastModifiedTimestamp;
        private string _relayArn;
        private string _relayId;
        private string _relayName;
        private string _serverName;
        private int? _serverPort;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// The authentication attribute—contains the secret ARN where the customer relay server
        /// credentials are stored. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the relay was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The timestamp of when relay was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the relay.
        /// </para>
        /// </summary>
        public string RelayArn
        {
            get { return this._relayArn; }
            set { this._relayArn = value; }
        }

        // Check to see if RelayArn property is set
        internal bool IsSetRelayArn()
        {
            return this._relayArn != null;
        }

        /// <summary>
        /// Gets and sets the property RelayId. 
        /// <para>
        /// The unique relay identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RelayId
        {
            get { return this._relayId; }
            set { this._relayId = value; }
        }

        // Check to see if RelayId property is set
        internal bool IsSetRelayId()
        {
            return this._relayId != null;
        }

        /// <summary>
        /// Gets and sets the property RelayName. 
        /// <para>
        /// The unique name of the relay.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        [AWSProperty(Min=1, Max=100)]
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
        [AWSProperty(Min=1, Max=65535)]
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

    }
}