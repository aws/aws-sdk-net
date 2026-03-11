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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTicketV2 operation.
    /// Grants permission to create a ticket in the chosen ITSM based on finding information
    /// for the provided finding metadata UID.
    /// </summary>
    public partial class CreateTicketV2Request : AmazonSecurityHubRequest
    {
        private string _clientToken;
        private string _connectorId;
        private string _findingMetadataUid;
        private TicketCreationMode _mode;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The UUID of the connectorV2 to identify connectorV2 resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingMetadataUid. 
        /// <para>
        /// The the unique ID for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingMetadataUid
        {
            get { return this._findingMetadataUid; }
            set { this._findingMetadataUid = value; }
        }

        // Check to see if FindingMetadataUid property is set
        internal bool IsSetFindingMetadataUid()
        {
            return this._findingMetadataUid != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode for ticket creation. When set to DRYRUN, the ticket is created using a Security
        /// Hub owned template test finding to verify the integration is working correctly.
        /// </para>
        /// </summary>
        public TicketCreationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}