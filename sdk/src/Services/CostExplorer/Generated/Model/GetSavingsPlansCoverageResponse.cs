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
    /// This is the response object from the GetSavingsPlansCoverage operation.
    /// </summary>
    public partial class GetSavingsPlansCoverageResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SavingsPlansCoverage> _savingsPlansCoverages = AWSConfigs.InitializeCollections ? new List<SavingsPlansCoverage>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
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

        /// <summary>
        /// Gets and sets the property SavingsPlansCoverages. 
        /// <para>
        /// The amount of spend that your Savings Plans covered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SavingsPlansCoverage> SavingsPlansCoverages
        {
            get { return this._savingsPlansCoverages; }
            set { this._savingsPlansCoverages = value; }
        }

        // Check to see if SavingsPlansCoverages property is set
        internal bool IsSetSavingsPlansCoverages()
        {
            return this._savingsPlansCoverages != null && (this._savingsPlansCoverages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}