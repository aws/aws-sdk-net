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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeFleetAdvisorSchemaObjectSummary operation.
    /// </summary>
    public partial class DescribeFleetAdvisorSchemaObjectSummaryResponse : AmazonWebServiceResponse
    {
        private List<FleetAdvisorSchemaObjectResponse> _fleetAdvisorSchemaObjects = AWSConfigs.InitializeCollections ? new List<FleetAdvisorSchemaObjectResponse>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetAdvisorSchemaObjects. 
        /// <para>
        /// A collection of <c>FleetAdvisorSchemaObjectResponse</c> objects.
        /// </para>
        /// </summary>
        public List<FleetAdvisorSchemaObjectResponse> FleetAdvisorSchemaObjects
        {
            get { return this._fleetAdvisorSchemaObjects; }
            set { this._fleetAdvisorSchemaObjects = value; }
        }

        // Check to see if FleetAdvisorSchemaObjects property is set
        internal bool IsSetFleetAdvisorSchemaObjects()
        {
            return this._fleetAdvisorSchemaObjects != null && (this._fleetAdvisorSchemaObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>NextToken</c> is returned, there are more results available. The value of <c>NextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. 
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