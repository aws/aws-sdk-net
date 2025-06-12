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
    /// Represents the output of a <c>BatchGetItem</c> operation.
    /// </summary>
    public partial class BatchGetItemResponse : AmazonWebServiceResponse
    {
        private List<ConsumedCapacity> _consumedCapacity = AWSConfigs.InitializeCollections ? new List<ConsumedCapacity>() : null;
        private Dictionary<string, List<Dictionary<string, AttributeValue>>> _responses = AWSConfigs.InitializeCollections ? new Dictionary<string, List<Dictionary<string, AttributeValue>>>() : null;
        private Dictionary<string, KeysAndAttributes> _unprocessedKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, KeysAndAttributes>() : null;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The read capacity units consumed by the entire <c>BatchGetItem</c> operation.
        /// </para>
        ///  
        /// <para>
        /// Each element consists of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TableName</c> - The table that consumed the provisioned throughput.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CapacityUnits</c> - The total number of capacity units consumed.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConsumedCapacity> ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null && (this._consumedCapacity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Responses. 
        /// <para>
        /// A map of table name or table ARN to a list of items. Each object in <c>Responses</c>
        /// consists of a table name or ARN, along with a map of attribute data consisting of
        /// the data type and attribute value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<Dictionary<string, AttributeValue>>> Responses
        {
            get { return this._responses; }
            set { this._responses = value; }
        }

        // Check to see if Responses property is set
        internal bool IsSetResponses()
        {
            return this._responses != null && (this._responses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedKeys. 
        /// <para>
        /// A map of tables and their respective keys that were not processed with the current
        /// response. The <c>UnprocessedKeys</c> value is in the same form as <c>RequestItems</c>,
        /// so the value can be provided directly to a subsequent <c>BatchGetItem</c> operation.
        /// For more information, see <c>RequestItems</c> in the Request Parameters section.
        /// </para>
        ///  
        /// <para>
        /// Each element consists of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Keys</c> - An array of primary key attribute values that define specific items
        /// in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProjectionExpression</c> - One or more attributes to be retrieved from the table
        /// or index. By default, all attributes are returned. If a requested attribute is not
        /// found, it does not appear in the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConsistentRead</c> - The consistency of a read operation. If set to <c>true</c>,
        /// then a strongly consistent read is used; otherwise, an eventually consistent read
        /// is used.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If there are no unprocessed keys remaining, the response contains an empty <c>UnprocessedKeys</c>
        /// map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public Dictionary<string, KeysAndAttributes> UnprocessedKeys
        {
            get { return this._unprocessedKeys; }
            set { this._unprocessedKeys = value; }
        }

        // Check to see if UnprocessedKeys property is set
        internal bool IsSetUnprocessedKeys()
        {
            return this._unprocessedKeys != null && (this._unprocessedKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}