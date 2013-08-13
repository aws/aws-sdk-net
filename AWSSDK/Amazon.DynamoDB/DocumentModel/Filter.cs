/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// Abstract filter class
    /// </summary>
    public abstract class Filter
    {
        // Creates a list of AttributeValues from a list of Primitives
        protected static List<AttributeValue> ConvertToAttributeValues(params DynamoDBEntry[] values)
        {
            List<AttributeValue> attributes = new List<AttributeValue>();
            foreach (DynamoDBEntry value in values)
            {
                AttributeValue nativeValue = value.ConvertToAttributeValue();
                if (nativeValue != null)
                {
                    attributes.Add(nativeValue);
                }
            }
            return attributes;
        }
    }

    /// <summary>
    /// Filter for use with scan operations
    /// </summary>
    public class ScanFilter : Filter
    {
        #region Private members

        private Dictionary<String, Condition> conditions = new Dictionary<string, Condition>();

        #endregion

        #region Conversions

        /// <summary>
        /// Converts filter to a map of conditions
        /// </summary>
        /// <returns>Map from attribute name to condition</returns>
        public Dictionary<string, Condition> ToConditions()
        {
            return new Dictionary<string,Condition>(conditions);
        }

        /// <summary>
        /// Creates a ScanFilter from a conditions map
        /// </summary>
        /// <param name="conditions">Map from attribute name to condition</param>
        /// <returns>Equivalent ScanFilter</returns>
        public static ScanFilter FromConditions(Dictionary<string, Condition> conditions)
        {
            ScanFilter ret = new ScanFilter();
            ret.conditions = conditions;
            return ret;
        }
        /// <summary>
        /// Implicitly converts ScanFilter to map of conditions
        /// </summary>
        /// <param name="f">ScanFilter to convert</param>
        /// <returns>Map from attribute name to condition</returns>
        public static implicit operator Dictionary<string, Condition>(ScanFilter f)
        {
            return f.ToConditions();
        }
        /// <summary>
        /// Implicitly converts map of conditions to ScanFilter
        /// </summary>
        /// <param name="conditions">Map from attribute name to condition</param>
        /// <returns>Equivalent ScanFilter</returns>
        public static implicit operator ScanFilter(Dictionary<string, Condition> conditions)
        {
            return ScanFilter.FromConditions(conditions);
        }

        #endregion

        #region Add methods

        /// <summary>
        /// Adds a condition for a specified attribute.
        /// 
        /// If a condition for the attribute already exists,
        /// it will be replaced with the new condition.
        /// </summary>
        /// <param name="attributeName">Target attribute name</param>
        /// <param name="condition">Condition to be added</param>
        public void AddCondition(string attributeName, Condition condition)
        {
            conditions[attributeName] = condition;
        }

        /// <summary>
        /// Adds a condition for a specified attribute that consists
        /// of an operator and any number of AttributeValues.
        /// </summary>
        /// <param name="attributeName">Target attribute name</param>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">AttributeValues to compare to</param>
        public void AddCondition(string attributeName, ScanOperator op, List<AttributeValue> values)
        {
            AddCondition(attributeName,
                new Condition
                {
                    ComparisonOperator = EnumToStringMapper.Convert(op),
                    AttributeValueList = values
                });
        }

        /// <summary>
        /// Adds a condition for a specified attribute that consists
        /// of an operator and any number of values
        /// </summary>
        /// <param name="attributeName">Target attribute name</param>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">Values to compare to</param>
        public void AddCondition(string attributeName, ScanOperator op, params DynamoDBEntry[] values)
        {
            AddCondition(attributeName,
                new Condition
                {
                    ComparisonOperator = EnumToStringMapper.Convert(op),
                    AttributeValueList = ConvertToAttributeValues(values)
                });
        }

        #endregion
    }

    /// <summary>
    /// Filter for use with range (query) searches
    /// </summary>
    public class RangeFilter : Filter
    {
        #region Properties

        /// <summary>
        /// Condition to test with the filter
        /// </summary>
        public Condition Condition
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs RangeFilter with no condition
        /// </summary>
        public RangeFilter()
        { }

        /// <summary>
        /// Constructs RangeFilter with the specified condition
        /// </summary>
        /// <param name="cond"></param>
        public RangeFilter(Condition cond)
        {
            Condition = cond;
        }

        /// <summary>
        /// Constructs RangeFilter with the specified comparison
        /// operator and comparison values
        /// </summary>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">Values to compare against</param>
        public RangeFilter(QueryOperator op, params Primitive[] values)
            : this(op, ConvertToAttributeValues(values))
        {
        }

        /// <summary>
        /// Constructs RangeFilter with the specified comparison
        /// operator and comparison values
        /// </summary>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">Values to compare against</param>
        public RangeFilter(QueryOperator op, List<AttributeValue> values)
        {
            Condition = new Condition
            {
                ComparisonOperator = EnumToStringMapper.Convert(op),
                AttributeValueList = values
            };
        }

        #endregion
    }
}
