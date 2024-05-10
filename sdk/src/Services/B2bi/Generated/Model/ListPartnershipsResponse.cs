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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the ListPartnerships operation.
    /// </summary>
    public partial class ListPartnershipsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PartnershipSummary> _partnerships = AWSConfigs.InitializeCollections ? new List<PartnershipSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When additional results are obtained from the command, a <c>NextToken</c> parameter
        /// is returned in the output. You can then pass the <c>NextToken</c> parameter in a subsequent
        /// command to continue listing additional resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Partnerships. 
        /// <para>
        /// Specifies a list of your partnerships.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PartnershipSummary> Partnerships
        {
            get { return this._partnerships; }
            set { this._partnerships = value; }
        }

        // Check to see if Partnerships property is set
        internal bool IsSetPartnerships()
        {
            return this._partnerships != null && (this._partnerships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}