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
    /// This is the response object from the ListLFTagExpressions operation.
    /// </summary>
    public partial class ListLFTagExpressionsResponse : AmazonWebServiceResponse
    {
        private List<LFTagExpression> _lfTagExpressions = AWSConfigs.InitializeCollections ? new List<LFTagExpression>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LFTagExpressions. 
        /// <para>
        /// Logical expressions composed of one more LF-Tag key-value pairs.
        /// </para>
        /// </summary>
        public List<LFTagExpression> LFTagExpressions
        {
            get { return this._lfTagExpressions; }
            set { this._lfTagExpressions = value; }
        }

        // Check to see if LFTagExpressions property is set
        internal bool IsSetLFTagExpressions()
        {
            return this._lfTagExpressions != null && (this._lfTagExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve this list.
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