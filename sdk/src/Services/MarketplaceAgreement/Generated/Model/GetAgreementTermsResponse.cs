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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// This is the response object from the GetAgreementTerms operation.
    /// </summary>
    public partial class GetAgreementTermsResponse : AmazonWebServiceResponse
    {
        private List<AcceptedTerm> _acceptedTerms = AWSConfigs.InitializeCollections ? new List<AcceptedTerm>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AcceptedTerms. 
        /// <para>
        /// A subset of terms proposed by the proposer that have been accepted by the acceptor
        /// as part of the agreement creation.
        /// </para>
        /// </summary>
        public List<AcceptedTerm> AcceptedTerms
        {
            get { return this._acceptedTerms; }
            set { this._acceptedTerms = value; }
        }

        // Check to see if AcceptedTerms property is set
        internal bool IsSetAcceptedTerms()
        {
            return this._acceptedTerms != null && (this._acceptedTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start pagination
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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