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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains the results of the <a>DescribeSnapshots</a> operation.
    /// </summary>
    public partial class DescribeSnapshotsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Snapshot> _snapshots = AWSConfigs.InitializeCollections ? new List<Snapshot>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, more results are available. Pass this value in the <i>NextToken</i> member
        /// of a subsequent call to <a>DescribeSnapshots</a>.
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
        /// Gets and sets the property Snapshots. 
        /// <para>
        /// The list of <a>Snapshot</a> objects that were retrieved.
        /// </para>
        ///  
        /// <para>
        /// It is possible that this list contains less than the number of items specified in
        /// the <i>Limit</i> member of the request. This occurs if there are less than the requested
        /// number of items left to retrieve, or if the limitations of the operation have been
        /// exceeded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Snapshot> Snapshots
        {
            get { return this._snapshots; }
            set { this._snapshots = value; }
        }

        // Check to see if Snapshots property is set
        internal bool IsSetSnapshots()
        {
            return this._snapshots != null && (this._snapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}