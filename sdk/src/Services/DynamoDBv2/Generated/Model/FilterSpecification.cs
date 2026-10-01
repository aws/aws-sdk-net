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
    /// Contains the filter criteria used to limit which items are included in an export.
    /// If you don't include this parameter, all items and attributes are exported.
    /// </summary>
    public partial class FilterSpecification
    {
        private Dictionary<string, string> _expressionAttributeNames = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, AttributeValue> _expressionAttributeValues = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _filterExpression;
        private string _keyConditionExpression;
        private string _projectionExpression;

        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. 
        /// <para>
        /// One or more substitution tokens for attribute names in an expression. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.ExpressionAttributeNames.html">Expression
        /// Attribute Names</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames
        {
            get { return this._expressionAttributeNames; }
            set { this._expressionAttributeNames = value; }
        }

        // Check to see if ExpressionAttributeNames property is set
        internal bool IsSetExpressionAttributeNames()
        {
            return this._expressionAttributeNames != null && (this._expressionAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeValues. 
        /// <para>
        /// One or more values that can be substituted in an expression. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.ExpressionAttributeValues.html">Expression
        /// Attribute Values</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> ExpressionAttributeValues
        {
            get { return this._expressionAttributeValues; }
            set { this._expressionAttributeValues = value; }
        }

        // Check to see if ExpressionAttributeValues property is set
        internal bool IsSetExpressionAttributeValues()
        {
            return this._expressionAttributeValues != null && (this._expressionAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// A condition that filters which items are included in the export. This parameter uses
        /// the same syntax as <c>FilterExpression</c> in <c>Query</c> and <c>Scan</c>. If you
        /// don't provide <c>KeyConditionExpression</c>, this expression can also reference key
        /// attributes. If you don't specify this parameter, all items are included in the export.
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property KeyConditionExpression. 
        /// <para>
        /// A condition expression that filters items by key values. The expression must test
        /// equality on a single partition key value and can optionally compare a sort key value.
        /// This parameter uses the same syntax as <c>KeyConditionExpression</c> in <c>Query</c>.
        /// When you provide this parameter, <c>FilterExpression</c> can only reference non-key
        /// attributes. If you don't specify this parameter, all items are eligible for export.
        /// </para>
        /// </summary>
        public string KeyConditionExpression
        {
            get { return this._keyConditionExpression; }
            set { this._keyConditionExpression = value; }
        }

        // Check to see if KeyConditionExpression property is set
        internal bool IsSetKeyConditionExpression()
        {
            return this._keyConditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectionExpression. 
        /// <para>
        /// The attributes you want to retrieve for items included in the export. Separate attribute
        /// names in the expression with commas. If you don't specify this parameter, all attributes
        /// are returned.
        /// </para>
        /// </summary>
        public string ProjectionExpression
        {
            get { return this._projectionExpression; }
            set { this._projectionExpression = value; }
        }

        // Check to see if ProjectionExpression property is set
        internal bool IsSetProjectionExpression()
        {
            return this._projectionExpression != null;
        }

    }
}