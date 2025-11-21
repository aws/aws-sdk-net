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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the ListInvestigations operation.
    /// </summary>
    public partial class ListInvestigationsResponse : AmazonWebServiceResponse
    {
        private List<InvestigationAction> _investigationActions = AWSConfigs.InitializeCollections ? new List<InvestigationAction>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InvestigationActions. 
        /// <para>
        /// Investigation performed by an agent for a security incid…Unique identifier for the
        /// specific investigation&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InvestigationAction> InvestigationActions
        {
            get { return this._investigationActions; }
            set { this._investigationActions = value; }
        }

        // Check to see if InvestigationActions property is set
        internal bool IsSetInvestigationActions()
        {
            return this._investigationActions != null && (this._investigationActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Investigation performed by an agent for a security incident for next Token
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