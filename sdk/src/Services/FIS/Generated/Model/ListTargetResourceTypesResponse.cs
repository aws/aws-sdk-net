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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FIS.Model
{
    /// <summary>
    /// This is the response object from the ListTargetResourceTypes operation.
    /// </summary>
    public partial class ListTargetResourceTypesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TargetResourceTypeSummary> _targetResourceTypes = new List<TargetResourceTypeSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property TargetResourceTypes. 
        /// <para>
        /// The target resource types.
        /// </para>
        /// </summary>
        public List<TargetResourceTypeSummary> TargetResourceTypes
        {
            get { return this._targetResourceTypes; }
            set { this._targetResourceTypes = value; }
        }

        // Check to see if TargetResourceTypes property is set
        internal bool IsSetTargetResourceTypes()
        {
            return this._targetResourceTypes != null && this._targetResourceTypes.Count > 0; 
        }

    }
}