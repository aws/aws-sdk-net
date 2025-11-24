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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Amazon.DynamoDBv2.Model;
using Amazon.Util;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Expressions are used for conditional deletes and filtering for query and scan operations.
    /// </summary>
    public class Expression
    {
        private Dictionary<string, string> _expressionAttributeNames = new Dictionary<string, string>(StringComparer.Ordinal);
        private Dictionary<string, DynamoDBEntry> _expressionAttributeValues = new Dictionary<string, DynamoDBEntry>(StringComparer.Ordinal);

        internal bool IsSet
        {
            get { return this.ExpressionStatement != null; }
        }

        /// <summary>
        /// Gets and sets the property ExpressionStatement. "Price > :price" is an example expression statement. 
        /// :price is a variable which gets its value from the ExpressionAttributeValues collection. If this is used
        /// for deletes then it prevents the delete from happening if the Price attribute on the item is less then the passed
        /// in price. For query and scan it will only return back items where the Price attribute is greater then passed
        /// in price.
        /// </summary>
        public string ExpressionStatement
        {
            get;
            set;
        }



        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. This collection contains attribute names from the item
        /// that should be substituted in the expression when it is evaluated. For example the expression "#C &lt; #U" will 
        /// expect the attribute names to be added to this collection.
        /// <code>
        /// expression.ExpressionAttributeNames["#C"] = "CriticRating"
        /// expression.ExpressionAttributeNames["#U"] = "UserRating"
        /// </code>
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames
        {
            get { return this._expressionAttributeNames; }
            set { this._expressionAttributeNames = value; }
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeValues. This collection contains the values to be substituted in the expression. 
        /// For example the expression "Price > :price" will contain one entry in this collection a key of ":price". 
        /// <para>
        /// DynamoDBEntry contains many common implicit cast operations so assignment can be done with the basic .NET types.
        /// In the price example shown above the value to be used for the expression can be provided using the following code snippet:
        /// <code>
        /// expression.ExpressionAttributeValues[":price"] = 3.99;
        /// </code>
        /// </para>
        /// </summary>
        public Dictionary<string, DynamoDBEntry> ExpressionAttributeValues
        {
            get { return this._expressionAttributeValues; }
            set { this._expressionAttributeValues = value; }
        }

        internal void ApplyExpression(ScanRequest request, Table table)
        {
            request.FilterExpression = this.ExpressionStatement;

            if (this.ExpressionAttributeValues?.Count > 0)
            {
                if (request.ExpressionAttributeValues == null)
                {
                    request.ExpressionAttributeValues = ConvertToAttributeValues(this.ExpressionAttributeValues, table);
                }
                else
                {
                    var reqEav = request.ExpressionAttributeValues;
                    var feav = ConvertToAttributeValues(this.ExpressionAttributeValues, table);
                    var combinedEav = Common.Combine(reqEav, feav, null);


                    if (combinedEav?.Count > 0)
                    {
                        request.ExpressionAttributeValues = combinedEav;
                    }
                }

            }

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                if (request.ExpressionAttributeNames==null)
                {
                    request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
                }
                else
                {
                    var combinedEan= Common.Combine(request.ExpressionAttributeNames,
                        this.ExpressionAttributeNames, StringComparer.Ordinal);

                    request.ExpressionAttributeNames = combinedEan;
                }
            }
        }

        internal void ApplyExpression(DeleteItemRequest request, Table table)
        {
            request.ConditionExpression = this.ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(this.ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(PutItemRequest request, Table table)
        {
            request.ConditionExpression = this.ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(this.ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(UpdateItemRequest request, Table table)
        {
            request.ConditionExpression = this.ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(this.ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(Get request, Table table)
        {
            request.ProjectionExpression = ExpressionStatement;
            request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
        }

        internal void ApplyExpression(Put request, Table table)
        {
            request.ConditionExpression = ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(Update request, Table table)
        {
            request.ConditionExpression = ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(Delete request, Table table)
        {
            request.ConditionExpression = ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }

        internal void ApplyExpression(ConditionCheck request, Table table)
        {
            request.ConditionExpression = ExpressionStatement;
            request.ExpressionAttributeValues = ConvertToAttributeValues(ExpressionAttributeValues, table);

            if (this.ExpressionAttributeNames?.Count > 0)
            {
                request.ExpressionAttributeNames = new Dictionary<string, string>(this.ExpressionAttributeNames);
            }
        }


        internal static void ApplyExpression(QueryRequest request, Table table,
            Expression keyExpression, Expression filterExpression)
        {
            if (keyExpression == null)
                keyExpression = new Expression();
            if (filterExpression == null)
                filterExpression = new Expression();

            if (!keyExpression.IsSet && !filterExpression.IsSet)
                return;

            if (keyExpression.IsSet)
                request.KeyConditionExpression = keyExpression.ExpressionStatement;
            if (filterExpression.IsSet)
                request.FilterExpression = filterExpression.ExpressionStatement;

            var kean = keyExpression.ExpressionAttributeNames;
            var fean = filterExpression.ExpressionAttributeNames;
            var combinedEan = Common.Combine(kean, fean, StringComparer.Ordinal);

            if (combinedEan?.Count > 0)
            {
                request.ExpressionAttributeNames = combinedEan;
            }

            var keav = new Document(keyExpression.ExpressionAttributeValues).ForceConversion(table.Conversion);
            var feav = new Document(filterExpression.ExpressionAttributeValues).ForceConversion(table.Conversion);
            var combinedEav = Common.Combine(keav, feav, null);

            var attributeValues = ConvertToAttributeValues(combinedEav, table);

            if (attributeValues?.Count > 0)
            {
                request.ExpressionAttributeValues = attributeValues;
            }
        }

        internal static Expression MergeUpdateExpressions(Expression right, Expression left)
        {
            if (right == null && left == null)
                return null;
            if (right == null)
                return left;
            if (left == null)
                return right;

            var keywordsOrder = new[] { "SET", "REMOVE", "ADD", "DELETE" };

            var leftSections = ParseSections(left.ExpressionStatement, keywordsOrder);
            var rightSections = ParseSections(right.ExpressionStatement, keywordsOrder);

            var mergedSections = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var keyword in keywordsOrder)
            {
                var leftPart = leftSections.ContainsKey(keyword) ? leftSections[keyword] : null;
                var rightPart = rightSections.ContainsKey(keyword) ? rightSections[keyword] : null;

                if (!string.IsNullOrEmpty(leftPart) && !string.IsNullOrEmpty(rightPart))
                {
                    mergedSections[keyword] = leftPart + ", " + rightPart;
                }
                else if (!string.IsNullOrEmpty(leftPart))
                {
                    mergedSections[keyword] = leftPart;
                }
                else if (!string.IsNullOrEmpty(rightPart))
                {
                    mergedSections[keyword] = rightPart;
                }
            }

            var mergedStatement = string.Join(" ",
                keywordsOrder.Where(k => mergedSections.ContainsKey(k))
                             .Select(k => $"{k} {mergedSections[k]}"));

            Dictionary<string, string> mergedNames;
            try
            {
                mergedNames = Common.Combine(left.ExpressionAttributeNames, right.ExpressionAttributeNames, StringComparer.Ordinal);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Failed to combine ExpressionAttributeNames due to duplicate keys with different values.", ex);
            }

            var mergedValues = Common.Combine(left.ExpressionAttributeValues, right.ExpressionAttributeValues, null);

            return new Expression
            {
                ExpressionStatement = string.IsNullOrWhiteSpace(mergedStatement) ? null : mergedStatement,
                ExpressionAttributeNames = mergedNames,
                ExpressionAttributeValues = mergedValues
            };


            static Dictionary<string, string> ParseSections(string expr, string[] keywords)
            {
                var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                if (string.IsNullOrWhiteSpace(expr))
                    return result;

                var positions = new List<(string keyword, int index)>();
                foreach (var keyword in keywords)
                {
                    int idx = expr.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);
                    if (idx >= 0)
                        positions.Add((keyword, idx));
                }
                if (positions.Count == 0)
                {
                    throw new InvalidOperationException($"Unable to parse update expression '{expr}'");
                }

                // Sort by position
                positions = positions.OrderBy(p => p.index).ToList();
                for (int i = 0; i < positions.Count; i++)
                {
                    var keyword = positions[i].keyword;
                    int start = positions[i].index + keyword.Length;
                    int end = (i + 1 < positions.Count) ? positions[i + 1].index : expr.Length;
                    string section = expr.Substring(start, end - start).Trim();
                    if (!string.IsNullOrEmpty(section))
                        result[keyword] = section;
                }
                return result;
            }
        }

        internal static Dictionary<string, AttributeValue> ConvertToAttributeValues(
            Dictionary<string, DynamoDBEntry> valueMap, Table table)
        {
            if (valueMap == null || valueMap.Count == 0)
            {
                return null;
            }

            var convertedValues = new Dictionary<string, AttributeValue>();
            foreach (var kvp in valueMap)
            {
                var attributeName = kvp.Key;
                var entry = kvp.Value;

                if (entry == null)
                    convertedValues[attributeName] = new AttributeValue { NULL = true };
                else
                {
                    if (table.StoreAsEpoch.Contains(attributeName))
                        entry = Document.DateTimeToEpochSeconds(entry, attributeName);

                    if (table.StoreAsEpochLong.Contains(attributeName))
                        entry = Document.DateTimeToEpochSecondsLong(entry, attributeName);

                    var attributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(table.Conversion, table.IsEmptyStringValueEnabled);
                    convertedValues[attributeName] = entry.ConvertToAttributeValue(attributeConversionConfig);
                }
            }

            return convertedValues;
        }
    }
}