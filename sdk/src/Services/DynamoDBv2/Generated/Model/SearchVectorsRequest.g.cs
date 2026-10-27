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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the SearchVectors operation. Performs a vector similarity
    /// search on a vector index associated with an Amazon DynamoDB table, and returns the
    /// most similar items sorted by similarity score based on the distance function configured
    /// for the index. <para> Score interpretation depends on the distance function: </para>
    /// <ul> <li> <para> <c>COSINE</c> - Returns the items with the <i>k smallest</i> scores.
    /// Scores range from 0 (identical) to 2 (opposite). Lower scores indicate higher similarity.
    /// </para> </li> <li> <para> <c>EUCLIDEAN</c> - Returns the items with the <i>k smallest</i>
    /// scores. Scores represent the Euclidean distance between vectors. Lower scores indicate
    /// higher similarity. </para> </li> <li> <para> <c>DOT_PRODUCT</c> - Returns the items
    /// with the <i>k highest</i> scores. Higher scores indicate higher similarity. </para>
    /// </li> </ul>
    /// </summary>
    public partial class SearchVectorsRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. 
        /// <para>
        /// One or more substitution tokens for attribute names in an expression. Use the <c>#</c>
        /// character in an expression to dereference an attribute name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ExpressionAttributeNames property is set.
        /// </summary>
        internal bool IsSetExpressionAttributeNames() => this.ExpressionAttributeNames != null && (this.ExpressionAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpressionAttributeValues. 
        /// <para>
        /// One or more values that can be substituted in an expression. Use the <c>:</c> character
        /// in an expression to dereference an attribute value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> ExpressionAttributeValues { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the ExpressionAttributeValues property is set.
        /// </summary>
        internal bool IsSetExpressionAttributeValues() => this.ExpressionAttributeValues != null && (this.ExpressionAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index to search. The index must be in the <c>ACTIVE</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property ProjectionExpression. 
        /// <para>
        /// A string that identifies one or more attributes to retrieve from the index. Separate
        /// attribute names with commas. If not specified, the operation returns all attributes
        /// projected into the vector index.
        /// </para>
        ///  
        /// <para>
        /// Only attributes projected into the vector index can be retrieved.
        /// </para>
        /// </summary>
        public string ProjectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the ProjectionExpression property is set.
        /// </summary>
        internal bool IsSetProjectionExpression() => this.ProjectionExpression != null;

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ReturnConsumedCapacity property is set.
        /// </summary>
        internal bool IsSetReturnConsumedCapacity() => this.ReturnConsumedCapacity != null;

        /// <summary>
        /// Gets and sets the property SearchConditionExpression. 
        /// <para>
        /// A condition expression used to filter the vector search results. The expression can
        /// reference attributes defined in the vector index search schema, including <c>HASH</c>
        /// and <c>INLINE_FILTER</c> key elements.
        /// </para>
        ///  
        /// <para>
        /// Only the equality operator (<c>=</c>) is supported for <c>HASH</c> attributes. Comparison
        /// and range operators are supported for <c>INLINE_FILTER</c> attributes. Only top-level
        /// attributes from the search schema can be referenced.
        /// </para>
        /// </summary>
        public string SearchConditionExpression { get; set; }

        /// <summary>
        /// Checks to see if the SearchConditionExpression property is set.
        /// </summary>
        internal bool IsSetSearchConditionExpression() => this.SearchConditionExpression != null;

        /// <summary>
        /// Gets and sets the property SearchVector. 
        /// <para>
        /// The search vector to compare against the indexed vectors. Each element is a 32-bit
        /// IEEE-754 floating point number, provided in DynamoDB list format.
        /// </para>
        ///  
        /// <para>
        /// The number of dimensions must match the number of dimensions configured for the vector
        /// index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public List<AttributeValue> SearchVector { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the SearchVector property is set.
        /// </summary>
        internal bool IsSetSearchVector() => this.SearchVector != null && (this.SearchVector.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the table containing the vector index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The number of most similar results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;
    }
}
