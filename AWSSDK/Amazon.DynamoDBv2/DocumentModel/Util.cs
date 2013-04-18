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
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// An enumeration of all supported return value directives
    /// </summary>
    public enum ReturnValues
    {
        None,
        AllOldAttributes,
        AllNewAttributes,
        UpdatedOldAttributes,
        UpdatedNewAttributes
    }

    /// <summary>
    /// An enumeration of all supported scan operator directives
    /// </summary>
    public enum ScanOperator
    {
        Equal,
        NotEqual,
        LessThanOrEqual,
        LessThan,
        GreaterThanOrEqual,
        GreaterThan,
        IsNotNull,
        IsNull,
        Contains,
        NotContains,
        BeginsWith,
        In,
        Between
    }

    /// <summary>
    /// An enumeration of all supported query operator directives
    /// </summary>
    public enum QueryOperator
    {
        Equal,
        LessThanOrEqual,
        LessThan,
        GreaterThanOrEqual,
        GreaterThan,
        BeginsWith,
        Between
    }

    /// <summary>
    /// An enumeration of all supported Select values for Query and Scan.
    /// Value of Count will force service to return the number of items,
    /// not the items themselves.
    /// </summary>
    public enum SelectValues
    {
        Count,
        SpecificAttributes,
        AllAttributes,
        AllProjectedAttributes
    }

    internal enum ProjectionTypeValues
    {
        All,
        Include,
        KeysOnly
    }

    internal enum ReturnConsumedCapacityValues
    {
        None,
        Total
    }

    internal enum ReturnItemCollectionMetricsValues
    {
        None,
        All
    }

    public class KeyDescription
    {
        public DynamoDBEntryType Type { get; internal set; }
        public bool IsHash { get; internal set; }
    }

    internal class Key : Dictionary<string, AttributeValue>
    {
        public Key(IDictionary<string, AttributeValue> values)
            : base(values)
        {
        }

        public Key()
            : base()
        { }
    }

    internal static class EnumToStringMapper
    {
        public static string Convert(ReturnConsumedCapacityValues value)
        {
            switch(value)
            {
                case ReturnConsumedCapacityValues.None:
                    return "NONE";
                case ReturnConsumedCapacityValues.Total:
                    return "TOTAL";
                default:
                    throw new ArgumentOutOfRangeException("Invalid ReturnConsumedCapacityValues value");
            }
        }

        public static string Convert(ReturnItemCollectionMetricsValues value)
        {
            switch (value)
            {
                case ReturnItemCollectionMetricsValues.None:
                    return "NONE";
                case ReturnItemCollectionMetricsValues.All:
                    return "ALL";
                default:
                    throw new ArgumentOutOfRangeException("Invalid ReturnItemCollectionMetricsValues value");
            }
        }

        public static string Convert(ProjectionTypeValues value)
        {
            switch (value)
            {
                case ProjectionTypeValues.All:
                    return "ALL";
                case ProjectionTypeValues.Include:
                    return "INCLUDE";
                case ProjectionTypeValues.KeysOnly:
                    return "KEYS_ONLY";
                default:
                    throw new ArgumentOutOfRangeException("Invalid ProjectionTypeValues value");
            }
        }

        public static string Convert(SelectValues value)
        {
            switch (value)
            {
                case SelectValues.Count:
                    return "COUNT";
                case SelectValues.AllAttributes:
                    return "ALL_ATTRIBUTES";
                case SelectValues.AllProjectedAttributes:
                    return "ALL_PROJECTED_ATTRIBUTES";
                case SelectValues.SpecificAttributes:
                    return "SPECIFIC_ATTRIBUTES";
                default:
                    throw new ArgumentOutOfRangeException("Invalid SelectValues value");
            }
        }


        public static string Convert(ReturnValues value)
        {
            switch (value)
            {
                case ReturnValues.None:
                    return "NONE";
                case ReturnValues.AllOldAttributes:
                    return "ALL_OLD";
                case ReturnValues.AllNewAttributes:
                    return "ALL_NEW";
                case ReturnValues.UpdatedOldAttributes:
                    return "UPDATED_OLD";
                case ReturnValues.UpdatedNewAttributes:
                    return "UPDATED_NEW";
                default:
                    throw new ArgumentOutOfRangeException("Invalid ReturnValues value");
            }
        }

        public static string Convert(ScanOperator value)
        {
            switch (value)
            {
                case ScanOperator.Equal:
                    return "EQ";
                case ScanOperator.NotEqual:
                    return "NE";
                case ScanOperator.LessThanOrEqual:
                    return "LE";
                case ScanOperator.LessThan:
                    return "LT";
                case ScanOperator.GreaterThanOrEqual:
                    return "GE";
                case ScanOperator.GreaterThan:
                    return "GT";
                case ScanOperator.IsNotNull:
                    return "NOT_NULL";
                case ScanOperator.IsNull:
                    return "NULL";
                case ScanOperator.Contains:
                    return "CONTAINS";
                case ScanOperator.NotContains:
                    return "NOT_CONTAINS";
                case ScanOperator.BeginsWith:
                    return "BEGINS_WITH";
                case ScanOperator.In:
                    return "IN";
                case ScanOperator.Between:
                    return "BETWEEN";
                default:
                    throw new ArgumentOutOfRangeException("Invalid ScanOperator value");
            }
        }

        public static string Convert(QueryOperator value)
        {
            switch(value)
            {
                case QueryOperator.Equal:
                    return "EQ";
                case QueryOperator.LessThanOrEqual:
                    return "LE";
                case QueryOperator.LessThan:
                    return "LT";
                case QueryOperator.GreaterThanOrEqual:
                    return "GE";
                case QueryOperator.GreaterThan:
                    return "GT";
                case QueryOperator.BeginsWith:
                    return "BEGINS_WITH";
                case QueryOperator.Between:
                    return "BETWEEN";
                default:
                    throw new ArgumentOutOfRangeException("Invalid QueryOperator value");
            }
        }
    }
 
    internal enum SearchType
    {
        Scan,
        Query
    }
}