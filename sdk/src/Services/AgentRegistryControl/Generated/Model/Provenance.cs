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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// One provenance entry describing the lineage of a registry record.
    /// </summary>
    public partial class Provenance
    {
        private ProvenanceRelation _relation;
        private SourceDetails _sourceDetails;
        private string _sourceId;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property Relation.
        /// </summary>
        [AWSProperty(Required=true)]
        public ProvenanceRelation Relation
        {
            get { return this._relation; }
            set { this._relation = value; }
        }

        // Check to see if Relation property is set
        internal bool IsSetRelation()
        {
            return this._relation != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        /// Additional details about the upstream source that the registry record was detected
        /// from, such as the AgentCore Gateway or Runtime configuration. The populated member
        /// corresponds to the source type.
        /// </para>
        /// </summary>
        public SourceDetails SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The identifier of the upstream source that the registry record was detected from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the upstream source that the registry record was detected from.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}