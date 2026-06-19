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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configuration for managed knowledge base connector data sources.
    /// </summary>
    public partial class ManagedKnowledgeBaseConnectorConfiguration
    {
        private Amazon.Runtime.Documents.Document _connectorParameters;
        private DeletionProtectionConfiguration _deletionProtectionConfiguration;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;

        /// <summary>
        /// Gets and sets the property ConnectorParameters. 
        /// <para>
        /// Connector-specific parameters. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-managed-connect-ds.html">Connect
        /// a data source</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ConnectorParameters
        {
            get { return this._connectorParameters; }
            set { this._connectorParameters = value; }
        }

        // Check to see if ConnectorParameters property is set
        internal bool IsSetConnectorParameters()
        {
            return !this._connectorParameters.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionConfiguration. 
        /// <para>
        /// A safeguard against accidental bulk deletion of indexed content.
        /// </para>
        /// </summary>
        public DeletionProtectionConfiguration DeletionProtectionConfiguration
        {
            get { return this._deletionProtectionConfiguration; }
            set { this._deletionProtectionConfiguration = value; }
        }

        // Check to see if DeletionProtectionConfiguration property is set
        internal bool IsSetDeletionProtectionConfiguration()
        {
            return this._deletionProtectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// Configuration for extracting media (images, audio, video) from data source files.
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration
        {
            get { return this._mediaExtractionConfiguration; }
            set { this._mediaExtractionConfiguration = value; }
        }

        // Check to see if MediaExtractionConfiguration property is set
        internal bool IsSetMediaExtractionConfiguration()
        {
            return this._mediaExtractionConfiguration != null;
        }

    }
}