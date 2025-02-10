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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListIndexedRecoveryPoints operation.
    /// </summary>
    public partial class ListIndexedRecoveryPointsResponse : AmazonWebServiceResponse
    {
        private List<IndexedRecoveryPoint> _indexedRecoveryPoints = AWSConfigs.InitializeCollections ? new List<IndexedRecoveryPoint>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IndexedRecoveryPoints. 
        /// <para>
        /// This is a list of recovery points that have an associated index, belonging to the
        /// specified account.
        /// </para>
        /// </summary>
        public List<IndexedRecoveryPoint> IndexedRecoveryPoints
        {
            get { return this._indexedRecoveryPoints; }
            set { this._indexedRecoveryPoints = value; }
        }

        // Check to see if IndexedRecoveryPoints property is set
        internal bool IsSetIndexedRecoveryPoints()
        {
            return this._indexedRecoveryPoints != null && (this._indexedRecoveryPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned recovery points.
        /// </para>
        ///  
        /// <para>
        /// For example, if a request is made to return <c>MaxResults</c> number of indexed recovery
        /// points, <c>NextToken</c> allows you to return more items in your list starting at
        /// the location pointed to by the next token.
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