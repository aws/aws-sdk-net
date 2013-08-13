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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// The Select operation returns a set of Attributes for ItemNames that match the select expression.
    /// The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB automatically adjusts the number of items
    /// returned per page to enforce this limit. For example, even if you ask to retrieve 2500 items, but each individual
    /// item is 10 kB in size, the system returns 100 items and an appropriate next token so you can get the next page of results.
    /// Operations that run longer than 5 seconds return a time-out error response or a partial or empty result set. Partial
    /// and empty result sets contains a next token which allow you to continue the operation from where it left off.
    /// Responses larger than one megabyte return a partial result set.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class SelectResult
    {
        private List<Item> itemField;
        private string nextTokenField;
        /// <summary>
        /// Gets and sets the Item property.
        /// Items represent individual objects that contain one or more attribute name-value pairs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Item")]
        public List<Item> Item
        {
            get
            {
                if (this.itemField == null)
                {
                    this.itemField = new List<Item>();
                }
                return this.itemField;
            }
            set { this.itemField = value; }
        }

        /// <summary>
        /// Sets the Item property
        /// </summary>
        /// <param name="list">Items represent individual objects that contain one or more attribute name-value pairs.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelectResult WithItem(params Item[] list)
        {
            foreach (Item item in list)
            {
                Item.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Item property is set
        /// </summary>
        /// <returns>true if Item property is set</returns>
        public bool IsSetItem()
        {
            return (Item.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// An opaque token indicating that more than MaxNumberOfItems matched, the response size exceeded 1 megabyte,
        /// or the execution time exceeded 5 seconds.
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
        /// <param name="nextToken">An opaque token indicating that more than MaxNumberOfItems matched, the response size exceeded 1 megabyte,
        /// or the execution time exceeded 5 seconds.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SelectResult WithNextToken(string nextToken)
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

    }
}
