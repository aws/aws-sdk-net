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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the ListPolicyGenerations operation.
    /// </summary>
    public partial class ListPolicyGenerationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicyGeneration> _policyGenerations = AWSConfigs.InitializeCollections ? new List<PolicyGeneration>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination of results returned.
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

        /// <summary>
        /// Gets and sets the property PolicyGenerations. 
        /// <para>
        /// A <c>PolicyGeneration</c> object that contains details about the generated policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PolicyGeneration> PolicyGenerations
        {
            get { return this._policyGenerations; }
            set { this._policyGenerations = value; }
        }

        // Check to see if PolicyGenerations property is set
        internal bool IsSetPolicyGenerations()
        {
            return this._policyGenerations != null && (this._policyGenerations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}