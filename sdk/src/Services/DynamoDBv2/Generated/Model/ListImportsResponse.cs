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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the ListImports operation.
    /// </summary>
    public partial class ListImportsResponse : AmazonWebServiceResponse
    {
        private List<ImportSummary> _importSummaryList = AWSConfigs.InitializeCollections ? new List<ImportSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportSummaryList. 
        /// <para>
        ///  A list of <c>ImportSummary</c> objects. 
        /// </para>
        /// </summary>
        public List<ImportSummary> ImportSummaryList
        {
            get { return this._importSummaryList; }
            set { this._importSummaryList = value; }
        }

        // Check to see if ImportSummaryList property is set
        internal bool IsSetImportSummaryList()
        {
            return this._importSummaryList != null && (this._importSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If this value is returned, there are additional results to be displayed. To retrieve
        /// them, call <c>ListImports</c> again, with <c>NextToken</c> set to this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=112, Max=1024)]
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