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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure for the output.
    /// </summary>
    public partial class GetWorkUnitsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _queryId;
        private List<WorkUnitRange> _workUnitRanges = AWSConfigs.InitializeCollections ? new List<WorkUnitRange>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token for paginating the returned list of tokens, returned if the current
        /// segment of the list is not the last.
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
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the plan query operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkUnitRanges. 
        /// <para>
        /// A <c>WorkUnitRangeList</c> object that specifies the valid range of work unit IDs
        /// for querying the execution service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkUnitRange> WorkUnitRanges
        {
            get { return this._workUnitRanges; }
            set { this._workUnitRanges = value; }
        }

        // Check to see if WorkUnitRanges property is set
        internal bool IsSetWorkUnitRanges()
        {
            return this._workUnitRanges != null && (this._workUnitRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}