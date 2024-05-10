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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListObjectives operation.
    /// </summary>
    public partial class ListObjectivesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ObjectiveSummary> _objectives = AWSConfigs.InitializeCollections ? new List<ObjectiveSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used to fetch the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Objectives. 
        /// <para>
        /// The list of objectives that the <c>ListObjectives</c> API returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ObjectiveSummary> Objectives
        {
            get { return this._objectives; }
            set { this._objectives = value; }
        }

        // Check to see if Objectives property is set
        internal bool IsSetObjectives()
        {
            return this._objectives != null && (this._objectives.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}