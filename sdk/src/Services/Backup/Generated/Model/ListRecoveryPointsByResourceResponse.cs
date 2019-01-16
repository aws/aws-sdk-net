/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListRecoveryPointsByResource operation.
    /// </summary>
    public partial class ListRecoveryPointsByResourceResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecoveryPointByResource> _recoveryPoints = new List<RecoveryPointByResource>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <code>maxResults</code> number of items, <code>NextToken</code>
        /// allows you to return more items in your list starting at the location pointed to by
        /// the next token.
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
        /// Gets and sets the property RecoveryPoints. 
        /// <para>
        /// An array of objects that contain detailed information about recovery points of the
        /// specified resource type.
        /// </para>
        /// </summary>
        public List<RecoveryPointByResource> RecoveryPoints
        {
            get { return this._recoveryPoints; }
            set { this._recoveryPoints = value; }
        }

        // Check to see if RecoveryPoints property is set
        internal bool IsSetRecoveryPoints()
        {
            return this._recoveryPoints != null && this._recoveryPoints.Count > 0; 
        }

    }
}