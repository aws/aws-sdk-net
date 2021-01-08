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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetSlotTypeVersions operation.
    /// Gets information about all versions of a slot type.
    /// 
    ///  
    /// <para>
    /// The <code>GetSlotTypeVersions</code> operation returns a <code>SlotTypeMetadata</code>
    /// object for each version of a slot type. For example, if a slot type has three numbered
    /// versions, the <code>GetSlotTypeVersions</code> operation returns four <code>SlotTypeMetadata</code>
    /// objects in the response, one for each numbered version and one for the <code>$LATEST</code>
    /// version. 
    /// </para>
    ///  
    /// <para>
    /// The <code>GetSlotTypeVersions</code> operation always returns at least one version,
    /// the <code>$LATEST</code> version.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:GetSlotTypeVersions</code> action.
    /// </para>
    /// </summary>
    public partial class GetSlotTypeVersionsRequest : AmazonLexModelBuildingServiceRequest
    {
        private int? _maxResults;
        private string _name;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of slot type versions to return in the response. The default is
        /// 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type for which versions should be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for fetching the next page of slot type versions. If the response
        /// to this call is truncated, Amazon Lex returns a pagination token in the response.
        /// To fetch the next page of versions, specify the pagination token in the next request.
        /// 
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