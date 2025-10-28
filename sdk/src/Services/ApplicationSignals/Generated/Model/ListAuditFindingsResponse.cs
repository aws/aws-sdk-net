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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the ListAuditFindings operation.
    /// </summary>
    public partial class ListAuditFindingsResponse : AmazonWebServiceResponse
    {
        private List<AuditFinding> _auditFindings = AWSConfigs.InitializeCollections ? new List<AuditFinding>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AuditFindings. 
        /// <para>
        /// An array of audit findings that match the specified criteria. Each finding includes
        /// details about the issue, affected resources, and auditor results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AuditFinding> AuditFindings
        {
            get { return this._auditFindings; }
            set { this._auditFindings = value; }
        }

        // Check to see if AuditFindings property is set
        internal bool IsSetAuditFindings()
        {
            return this._auditFindings != null && (this._auditFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use for retrieving the next page of results. This value is present only
        /// if there are more results available than were returned in the current response.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}