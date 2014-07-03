/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.CloudSearchDomain
{

    /// <summary>
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant Applicationjson for ContentType
        /// </summary>
        public static readonly ContentType Applicationjson = new ContentType("application/json");
        /// <summary>
        /// Constant Applicationxml for ContentType
        /// </summary>
        public static readonly ContentType Applicationxml = new ContentType("application/xml");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentType FindValue(string value)
        {
            return FindValue<ContentType>(value);
        }

        public static implicit operator ContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryParser.
    /// </summary>
    public class QueryParser : ConstantClass
    {

        /// <summary>
        /// Constant Dismax for QueryParser
        /// </summary>
        public static readonly QueryParser Dismax = new QueryParser("dismax");
        /// <summary>
        /// Constant Lucene for QueryParser
        /// </summary>
        public static readonly QueryParser Lucene = new QueryParser("lucene");
        /// <summary>
        /// Constant Simple for QueryParser
        /// </summary>
        public static readonly QueryParser Simple = new QueryParser("simple");
        /// <summary>
        /// Constant Structured for QueryParser
        /// </summary>
        public static readonly QueryParser Structured = new QueryParser("structured");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public QueryParser(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryParser FindValue(string value)
        {
            return FindValue<QueryParser>(value);
        }

        public static implicit operator QueryParser(string value)
        {
            return FindValue(value);
        }
    }

}