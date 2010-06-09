/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Perform multiple PutAttribute operations in a single call. This helps you yield savings in round trips and
    /// latencies, and enables Amazon SimpleDB to optimize requests, which generally yields better throughput.
    ///
    /// Amazon SimpleDB uniquely identifies attributes in an item by their name/value combinations. For example, a
    /// single item can have the attributes { "first_name", "first_value" } and { "first_name", second_value" }. However,
    /// it cannot have two attribute instances where both the attribute name and attribute value are the same.
    ///
    /// Optionally, you can supply the Replace parameter for each individual attribute. Setting this value to true
    /// causes the new attribute value to replace the existing attribute value(s) if any exist. Otherwise, it simply
    /// inserts the attribute values. For example, if an item has the attributes { 'a', '1' }, { 'b', '2'}, and { 'b', '3' }
    /// and the requestor calls BatchPutAttributes using the attributes { 'b', '4' } with the Replace parameter set to true,
    /// the final attributes of the item are changed to { 'a', '1' } and { 'b', '4' }. This occurs because the new 'b'
    /// attribute replaces the old value.
    ///
    /// Note: You cannot specify an empty string as an item or attribute name.
    ///
    /// The operation succeeds or fails in its entirety. There are no partial puts.
    ///
    /// You can execute multiple BatchPutAttributes operations and other operations in parallel. However, large numbers of
    /// concurrent BatchPutAttributes calls can result in Service Unavailable (503) responses.
    ///
    /// This operation is vulnerable to exceeding the maximum URL size.
    ///
    /// The following limitations are enforced for this operation:
    ///
    /// * 256 attribute name-value pairs per item
    /// * 1 MB request size
    /// * 1 billion attributes per domain
    /// * 10 GB of total user data storage per domain
    /// * 25 item limit per BatchPutAttributes operation
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class BatchPutAttributesRequest
    {
        private string domainNameField;
        private List<ReplaceableItem> itemField;

        /// <summary>
        /// Gets and sets the DomainName property.
        /// The name of the domain in which to perform the operation.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainName")]
        public string DomainName
        {
            get { return this.domainNameField; }
            set { this.domainNameField = value; }
        }

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <returns>this instance</returns>
        public BatchPutAttributesRequest WithDomainName(string domainName)
        {
            this.domainNameField = domainName;
            return this;
        }

        /// <summary>
        /// Checks if DomainName property is set
        /// </summary>
        /// <returns>true if DomainName property is set</returns>
        public bool IsSetDomainName()
        {
            return this.domainNameField != null;
        }
        /// <summary>
        /// Gets and sets the Item property.
        /// Items represent individual objects that contain one or more attribute name-value pairs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Item")]
        public List<ReplaceableItem> Item
        {
            get
            {
                if (this.itemField == null)
                {
                    this.itemField = new List<ReplaceableItem>();
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
        public BatchPutAttributesRequest WithItem(params ReplaceableItem[] list)
        {
            foreach (ReplaceableItem item in list)
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

    }
}
