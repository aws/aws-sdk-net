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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the ListCostCategoryResourceAssociations operation.
    /// </summary>
    public partial class ListCostCategoryResourceAssociationsResponse : AmazonWebServiceResponse
    {
        private List<CostCategoryResourceAssociation> _costCategoryResourceAssociations = AWSConfigs.InitializeCollections ? new List<CostCategoryResourceAssociation>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CostCategoryResourceAssociations. 
        /// <para>
        ///  A reference to a cost category association that contains information on an associated
        /// resource. 
        /// </para>
        /// </summary>
        public List<CostCategoryResourceAssociation> CostCategoryResourceAssociations
        {
            get { return this._costCategoryResourceAssociations; }
            set { this._costCategoryResourceAssociations = value; }
        }

        // Check to see if CostCategoryResourceAssociations property is set
        internal bool IsSetCostCategoryResourceAssociations()
        {
            return this._costCategoryResourceAssociations != null && (this._costCategoryResourceAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
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