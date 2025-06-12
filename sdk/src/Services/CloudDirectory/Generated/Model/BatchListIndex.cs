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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Lists objects attached to the specified index inside a <a>BatchRead</a> operation.
    /// For more information, see <a>ListIndex</a> and <a>BatchReadRequest$Operations</a>.
    /// </summary>
    public partial class BatchListIndex
    {
        private ObjectReference _indexReference;
        private int? _maxResults;
        private string _nextToken;
        private List<ObjectAttributeRange> _rangesOnIndexedValues = AWSConfigs.InitializeCollections ? new List<ObjectAttributeRange>() : null;

        /// <summary>
        /// Gets and sets the property IndexReference. 
        /// <para>
        /// The reference to the index to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference IndexReference
        {
            get { return this._indexReference; }
            set { this._indexReference = value; }
        }

        // Check to see if IndexReference property is set
        internal bool IsSetIndexReference()
        {
            return this._indexReference != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
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
        /// Gets and sets the property RangesOnIndexedValues. 
        /// <para>
        /// Specifies the ranges of indexed values that you want to query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ObjectAttributeRange> RangesOnIndexedValues
        {
            get { return this._rangesOnIndexedValues; }
            set { this._rangesOnIndexedValues = value; }
        }

        // Check to see if RangesOnIndexedValues property is set
        internal bool IsSetRangesOnIndexedValues()
        {
            return this._rangesOnIndexedValues != null && (this._rangesOnIndexedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}