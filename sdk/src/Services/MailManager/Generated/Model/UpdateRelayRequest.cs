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
    /// Container for the parameters to the UpdateRelay operation.
    /// Updates the attributes of an existing relay resource.
    /// </summary>
    public partial class UpdateRelayRequest : AmazonMailManagerRequest
    {
        private RelayAuthentication _authentication;
        private string _relayId;
        private string _relayName;
        private string _serverName;
        private int? _serverPort;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Authentication for the relay destination server—specify the secretARN where the SMTP
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
        /// The name of the relay resource.
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