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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConnectorParameters. 
        /// <para>
        /// Connector-specific parameters. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-managed-connect-ds.html">Connect
        /// a data source</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ConnectorParameters { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorParameters property is set.
        /// </summary>
        internal bool IsSetConnectorParameters() => !this.ConnectorParameters.IsNull();

        /// <summary>
        /// Gets and sets the property DeletionProtectionConfiguration. 
        /// <para>
        /// A safeguard against accidental bulk deletion of indexed content.
        /// </para>
        /// </summary>
        public DeletionProtectionConfiguration DeletionProtectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionConfiguration property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionConfiguration() => this.DeletionProtectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// Configuration for extracting media (images, audio, video) from data source files.
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MediaExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetMediaExtractionConfiguration() => this.MediaExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SyncSchedule. 
        /// <para>
        /// The recurring schedule on which the connector automatically syncs this data source.
        /// If not specified, the data source is not synced automatically and you start each sync
        /// yourself. Not supported for the Custom connector.
        /// </para>
        /// </summary>
        public SyncSchedule SyncSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SyncSchedule property is set.
        /// </summary>
        internal bool IsSetSyncSchedule() => this.SyncSchedule != null;
    }
}
