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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the ListTransformers operation.
    /// </summary>
    public partial class ListTransformersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TransformerSummary> _transformers = AWSConfigs.InitializeCollections ? new List<TransformerSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When additional results are obtained from the command, a <c>NextToken</c> parameter
        /// is returned in the output. You can then pass the <c>NextToken</c> parameter in a subsequent
        /// command to continue listing additional resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Transformers. 
        /// <para>
        /// Returns an array of one or more transformer objects.
        /// </para>
        ///  
        /// <para>
        /// For each transformer, a <c>TransformerSummary</c> object is returned. The <c>TransformerSummary</c>
        /// contains all the details for a specific transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TransformerSummary> Transformers
        {
            get { return this._transformers; }
            set { this._transformers = value; }
        }

        // Check to see if Transformers property is set
        internal bool IsSetTransformers()
        {
            return this._transformers != null && (this._transformers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}