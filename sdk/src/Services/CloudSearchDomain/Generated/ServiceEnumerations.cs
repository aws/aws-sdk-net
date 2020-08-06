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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
        /// Constant ApplicationJson for ContentType
        /// </summary>
        public static readonly ContentType ApplicationJson = new ContentType("application/json");
        /// <summary>
        /// Constant ApplicationXml for ContentType
        /// </summary>
        public static readonly ContentType ApplicationXml = new ContentType("application/xml");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryParser(string value)
        {
            return FindValue(value);
        }
    }

}