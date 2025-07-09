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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the ListPolicyVersions operation.
    /// </summary>
    public partial class ListPolicyVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicyVersionSummary> _policyVersions = AWSConfigs.InitializeCollections ? new List<PolicyVersionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <c>NextToken</c> request parameter in a next call
        /// to the operation to get more output. You can repeat this until the <c>NextToken</c>
        /// response element returns <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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
        /// Gets and sets the property PolicyVersions. 
        /// <para>
        /// An array of <c>PolicyVersionSummary</c> objects. Contains details for the version
        /// of the policies that define the permissions for team resources.
        /// </para>
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<PolicyVersionSummary> PolicyVersions
        {
            get { return this._policyVersions; }
            set { this._policyVersions = value; }
        }

        // Check to see if PolicyVersions property is set
        internal bool IsSetPolicyVersions()
        {
            return this._policyVersions != null && (this._policyVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}