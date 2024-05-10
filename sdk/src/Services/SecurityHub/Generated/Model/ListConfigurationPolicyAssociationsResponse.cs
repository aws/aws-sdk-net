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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the ListConfigurationPolicyAssociations operation.
    /// </summary>
    public partial class ListConfigurationPolicyAssociationsResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationPolicyAssociationSummary> _configurationPolicyAssociationSummaries = AWSConfigs.InitializeCollections ? new List<ConfigurationPolicyAssociationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyAssociationSummaries. 
        /// <para>
        ///  An object that contains the details of each configuration policy association that’s
        /// returned in a <c>ListConfigurationPolicyAssociations</c> request. 
        /// </para>
        /// </summary>
        public List<ConfigurationPolicyAssociationSummary> ConfigurationPolicyAssociationSummaries
        {
            get { return this._configurationPolicyAssociationSummaries; }
            set { this._configurationPolicyAssociationSummaries = value; }
        }

        // Check to see if ConfigurationPolicyAssociationSummaries property is set
        internal bool IsSetConfigurationPolicyAssociationSummaries()
        {
            return this._configurationPolicyAssociationSummaries != null && (this._configurationPolicyAssociationSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The <c>NextToken</c> value to include in the next <c>ListConfigurationPolicyAssociations</c>
        /// request. When the results of a <c>ListConfigurationPolicyAssociations</c> request
        /// exceed <c>MaxResults</c>, this value can be used to retrieve the next page of results.
        /// This value is <c>null</c> when there are no more results to return. 
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