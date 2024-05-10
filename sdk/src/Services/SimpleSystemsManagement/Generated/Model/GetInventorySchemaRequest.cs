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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetInventorySchema operation.
    /// Return a list of inventory type names for the account, or return a list of attribute
    /// names for a specific Inventory item type.
    /// </summary>
    public partial class GetInventorySchemaRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _aggregator;
        private int? _maxResults;
        private string _nextToken;
        private bool? _subType;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Aggregator. 
        /// <para>
        /// Returns inventory schemas that support aggregation. For example, this call returns
        /// the <c>AWS:InstanceInformation</c> type, because it supports aggregation based on
        /// the <c>PlatformName</c>, <c>PlatformType</c>, and <c>PlatformVersion</c> attributes.
        /// </para>
        /// </summary>
        public bool? Aggregator
        {
            get { return this._aggregator; }
            set { this._aggregator = value; }
        }

        // Check to see if Aggregator property is set
        internal bool IsSetAggregator()
        {
            return this._aggregator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=200)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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
        /// Gets and sets the property SubType. 
        /// <para>
        /// Returns the sub-type schema for a specified inventory type.
        /// </para>
        /// </summary>
        public bool? SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The type of inventory item to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}