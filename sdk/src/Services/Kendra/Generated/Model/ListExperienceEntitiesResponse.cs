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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the ListExperienceEntities operation.
    /// </summary>
    public partial class ListExperienceEntitiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ExperienceEntitiesSummary> _summaryItems = AWSConfigs.InitializeCollections ? new List<ExperienceEntitiesSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token, which you can use
        /// in a later request to retrieve the next set of users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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
        /// Gets and sets the property SummaryItems. 
        /// <para>
        /// An array of summary information for one or more users or groups.
        /// </para>
        /// </summary>
        public List<ExperienceEntitiesSummary> SummaryItems
        {
            get { return this._summaryItems; }
            set { this._summaryItems = value; }
        }

        // Check to see if SummaryItems property is set
        internal bool IsSetSummaryItems()
        {
            return this._summaryItems != null && (this._summaryItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}