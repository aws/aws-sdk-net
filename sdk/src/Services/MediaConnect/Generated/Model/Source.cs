/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for the source of the flow.
    /// </summary>
    public partial class Source
    {
        private Encryption _decryption;
        private string _description;
        private string _entitlementArn;
        private string _ingestIp;
        private int? _ingestPort;
        private string _name;
        private string _sourceArn;
        private Transport _transport;
        private string _whitelistCidr;

        /// <summary>
        /// Gets and sets the property Decryption. The type of encryption that is used on the
        /// content ingested from this source.
        /// </summary>
        public Encryption Decryption
        {
            get { return this._decryption; }
            set { this._decryption = value; }
        }

        // Check to see if Decryption property is set
        internal bool IsSetDecryption()
        {
            return this._decryption != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A description for the source. This value is
        /// not used or seen outside of the current AWS Elemental MediaConnect account.
        /// </summary>
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
        /// Gets and sets the property EntitlementArn. The ARN of the entitlement that allows
        /// you to subscribe to content that comes from another AWS account. The entitlement is
        /// set by the content originator and the ARN is generated as part of the originator's
        /// flow.
        /// </summary>
        public string EntitlementArn
        {
            get { return this._entitlementArn; }
            set { this._entitlementArn = value; }
        }

        // Check to see if EntitlementArn property is set
        internal bool IsSetEntitlementArn()
        {
            return this._entitlementArn != null;
        }

        /// <summary>
        /// Gets and sets the property IngestIp. The IP address that the flow will be listening
        /// on for incoming content.
        /// </summary>
        public string IngestIp
        {
            get { return this._ingestIp; }
            set { this._ingestIp = value; }
        }

        // Check to see if IngestIp property is set
        internal bool IsSetIngestIp()
        {
            return this._ingestIp != null;
        }

        /// <summary>
        /// Gets and sets the property IngestPort. The port that the flow will be listening on
        /// for incoming content.
        /// </summary>
        public int IngestPort
        {
            get { return this._ingestPort.GetValueOrDefault(); }
            set { this._ingestPort = value; }
        }

        // Check to see if IngestPort property is set
        internal bool IsSetIngestPort()
        {
            return this._ingestPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the source.
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
        /// Gets and sets the property SourceArn. The ARN of the source.
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Transport. Attributes related to the transport stream that
        /// are used in the source.
        /// </summary>
        public Transport Transport
        {
            get { return this._transport; }
            set { this._transport = value; }
        }

        // Check to see if Transport property is set
        internal bool IsSetTransport()
        {
            return this._transport != null;
        }

        /// <summary>
        /// Gets and sets the property WhitelistCidr. The range of IP addresses that should be
        /// allowed to contribute content to your source. These IP addresses should in the form
        /// of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </summary>
        public string WhitelistCidr
        {
            get { return this._whitelistCidr; }
            set { this._whitelistCidr = value; }
        }

        // Check to see if WhitelistCidr property is set
        internal bool IsSetWhitelistCidr()
        {
            return this._whitelistCidr != null;
        }

    }
}