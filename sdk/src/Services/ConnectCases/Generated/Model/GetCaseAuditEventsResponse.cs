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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the GetCaseAuditEvents operation.
    /// </summary>
    public partial class GetCaseAuditEventsResponse : AmazonWebServiceResponse
    {
        private List<AuditEvent> _auditEvents = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AuditEvents. 
        /// <para>
        /// A list of case audits where each represents a particular edit of the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<AuditEvent> AuditEvents
        {
            get { return this._auditEvents; }
            set { this._auditEvents = value; }
        }

        // Check to see if AuditEvents property is set
        internal bool IsSetAuditEvents()
        {
            return this._auditEvents != null && (this._auditEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. This is null if there are no more results to
        /// return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9000)]
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