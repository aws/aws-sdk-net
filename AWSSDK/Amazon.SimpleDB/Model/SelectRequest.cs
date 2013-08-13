/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using Attribute = Amazon.SimpleDB.Model.Attribute;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// The Select operation returns a set of Attributes for ItemNames that match the select expression. Select is similar to
    /// the standard SQL SELECT statement. The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB
    /// automatically adjusts the number of items returned per page to enforce this limit. For example, even if you ask to
    /// retrieve 2500 items, but each individual item is 10 kB in size, the system returns 100 items and an appropriate next
    /// token so you can get the next page of results.
    ///
    /// Operations that run longer than 5 seconds return a time-out error response or a partial or empty result set. Partial
    /// and empty result sets contains a next token which allow you to continue the operation from where it left off.
    ///
    /// Responses larger than one megabyte return a partial result set.
    ///
    /// Your application should not excessively retry queries that return RequestTimeout errors. If you receive too many
    /// RequestTimeout errors, reduce the complexity of your query expression.
    ///
    /// When designing your application, keep in mind that Amazon SimpleDB does not guarantee how attributes are ordered in
    /// the returned response.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class SelectRequest : SDBRequest
    {
        private string selectExpressionField;
        private string nextTokenField;
        private bool? consistentReadField;

        /// <summary>
        /// Gets and sets the SelectExpression property.
        /// This section describes Select, a function that takes query expressions similar to the standard SQL SELECT statement.
        /// See http://docs.amazonwebservices.com/AmazonSimpleDB/latest/DeveloperGuide/UsingSelect.html for more information
        /// on building expressions.
        /// </summary>
        [XmlElementAttribute(ElementName = "SelectExpression")]
        public string SelectExpression
        {
            get { return this.selectExpressionField; }
            set { this.selectExpressionField = value; }
        }

        /// <summary>
        /// Sets the SelectExpression property
        /// </summary>
        /// <param name="selectExpression">This section describes Select, a function that takes query expressions similar to the standard SQL SELECT statement.
        /// See http://docs.amazonwebservices.com/AmazonSimpleDB/latest/DeveloperGuide/UsingSelect.html for more information
        /// on building expressions.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelectRequest WithSelectExpression(string selectExpression)
        {
            this.selectExpressionField = selectExpression;
            return this;
        }

        /// <summary>
        /// Checks if SelectExpression property is set
        /// </summary>
        /// <returns>true if SelectExpression property is set</returns>
        public bool IsSetSelectExpression()
        {
            return this.selectExpressionField != null;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// String that tells Amazon SimpleDB where to start the next list of item names.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">String that tells Amazon SimpleDB where to start the next list of item names.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelectRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

        /// <summary>
        /// Gets and sets the ConsistentRead property.
        /// If set to true, this flag ensures that the most recently written data is
        /// returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConsistentRead")]
        public bool ConsistentRead
        {
            get { return this.consistentReadField.GetValueOrDefault(); }
            set { this.consistentReadField = value; }
        }

        /// <summary>
        /// Sets the ConsistentRead property
        /// </summary>
        /// <param name="consistentRead">If set to true, this flag ensures that the most recently written data is
        /// returned.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelectRequest WithConsistentRead(bool consistentRead)
        {
            this.consistentReadField = consistentRead;
            return this;
        }

        /// <summary>
        /// Checks if ConsistentRead property is set
        /// </summary>
        /// <returns>true if ConsistentRead property is set</returns>
        public bool IsSetConsistentRead()
        {
            return this.consistentReadField.HasValue;
        }

    }
}
