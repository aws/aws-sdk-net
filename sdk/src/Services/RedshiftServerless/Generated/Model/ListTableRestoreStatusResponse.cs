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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the ListTableRestoreStatus operation.
    /// </summary>
    public partial class ListTableRestoreStatusResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TableRestoreStatus> _tableRestoreStatuses = new List<TableRestoreStatus>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your initial <code>ListTableRestoreStatus</code> operation returns a <code>nextToken</code>,
        /// you can include the returned <code>nextToken</code> in following <code>ListTableRestoreStatus</code>
        /// operations. This will returns results on the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
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
        /// Gets and sets the property TableRestoreStatuses. 
        /// <para>
        /// The array of returned <code>TableRestoreStatus</code> objects.
        /// </para>
        /// </summary>
        public List<TableRestoreStatus> TableRestoreStatuses
        {
            get { return this._tableRestoreStatuses; }
            set { this._tableRestoreStatuses = value; }
        }

        // Check to see if TableRestoreStatuses property is set
        internal bool IsSetTableRestoreStatuses()
        {
            return this._tableRestoreStatuses != null && this._tableRestoreStatuses.Count > 0; 
        }

    }
}