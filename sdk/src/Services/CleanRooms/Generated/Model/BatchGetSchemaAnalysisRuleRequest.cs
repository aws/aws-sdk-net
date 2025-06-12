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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetSchemaAnalysisRule operation.
    /// Retrieves multiple analysis rule schemas.
    /// </summary>
    public partial class BatchGetSchemaAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        private string _collaborationIdentifier;
        private List<SchemaAnalysisRuleRequest> _schemaAnalysisRuleRequests = AWSConfigs.InitializeCollections ? new List<SchemaAnalysisRuleRequest>() : null;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The unique identifier of the collaboration that contains the schema analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaAnalysisRuleRequests. 
        /// <para>
        /// The information that's necessary to retrieve a schema analysis rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<SchemaAnalysisRuleRequest> SchemaAnalysisRuleRequests
        {
            get { return this._schemaAnalysisRuleRequests; }
            set { this._schemaAnalysisRuleRequests = value; }
        }

        // Check to see if SchemaAnalysisRuleRequests property is set
        internal bool IsSetSchemaAnalysisRuleRequests()
        {
            return this._schemaAnalysisRuleRequests != null && (this._schemaAnalysisRuleRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}