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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Information about the result.
    /// </summary>
    public partial class ResultData
    {
        private Document _document;
        private double? _relevanceScore;
        private string _resultId;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Document Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property RelevanceScore. 
        /// <para>
        /// The relevance score of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? RelevanceScore
        {
            get { return this._relevanceScore; }
            set { this._relevanceScore = value; }
        }

        // Check to see if RelevanceScore property is set
        internal bool IsSetRelevanceScore()
        {
            return this._relevanceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The identifier of the result data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResultId
        {
            get { return this._resultId; }
            set { this._resultId = value; }
        }

        // Check to see if ResultId property is set
        internal bool IsSetResultId()
        {
            return this._resultId != null;
        }

    }
}