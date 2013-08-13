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
    /// The PutAttributes operation creates or replaces attributes in an item. Attributes are uniquely identified in an
    /// item by their name/value combination. For example, a single item can have the attributes { "first_name",
    /// "first_value" } and { "first_name", second_value" }. However, it cannot have two attribute instances where both
    /// the attribute name and attribute value are the same.
    ///
    /// Optionally, the requestor can supply the Replace parameter for each individual attribute. Setting this value to
    /// true causes the new attribute value to replace the existing attribute value(s). For example, if an item has the
    /// attributes { 'a', '1' }, { 'b', '2'} and { 'b', '3' } and the requestor calls PutAttributes using the attributes
    /// { 'b', '4' } with the Replace parameter set to true, the final attributes of the item are changed to { 'a', '1' }
    /// and { 'b', '4' }, which replaces the previous values of the 'b' attribute with the new value.
    ///
    /// Note: Using PutAttributes to replace attribute values that do not exist will not result in an error response.
    ///
    /// You cannot specify an empty string as an attribute name. Because Amazon SimpleDB makes multiple copies of your data
    /// and uses an eventual consistency update model, an immediate GetAttributes or Select request (read) immediately after a
    /// DeleteAttributes request (write) might not return the updated data.
    ///
    /// The following limitations are enforced for this operation:
    ///
    /// * 256 total attribute name-value pairs per item
    /// * One billion attributes per domain
    /// * 10 GB of total user data storage per domain
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class PutAttributesRequest : SDBRequest
    {
        private string domainNameField;
        private string itemNameField;
        private List<ReplaceableAttribute> attributeField;
        private UpdateCondition expectedField;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutAttributesRequest WithDomainName(string domainName)
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
        /// Gets and sets the ItemName property.
        /// The name of the item.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemName")]
        public string ItemName
        {
            get { return this.itemNameField; }
            set { this.itemNameField = value; }
        }

        /// <summary>
        /// Sets the ItemName property
        /// </summary>
        /// <param name="itemName">The name of the item.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutAttributesRequest WithItemName(string itemName)
        {
            this.itemNameField = itemName;
            return this;
        }

        /// <summary>
        /// Checks if ItemName property is set
        /// </summary>
        /// <returns>true if ItemName property is set</returns>
        public bool IsSetItemName()
        {
            return this.itemNameField != null;
        }
        /// <summary>
        /// Gets and sets the Attribute property.
        /// An attribute associated with an item. Similar to columns on a spreadsheet, attributes represent
        /// categories of data that can be assigned to items.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<ReplaceableAttribute> Attribute
        {
            get
            {
                if (this.attributeField == null)
                {
                    this.attributeField = new List<ReplaceableAttribute>();
                }
                return this.attributeField;
            }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="list">An attribute associated with an item. Similar to columns on a spreadsheet, attributes represent
        /// categories of data that can be assigned to items.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutAttributesRequest WithAttribute(params ReplaceableAttribute[] list)
        {
            foreach (ReplaceableAttribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Expected property.
        /// Performs the operation if the specified attribute name and value match.
        /// </summary>
        [XmlElementAttribute(ElementName = "Expected")]
        public UpdateCondition Expected
        {
            get { return this.expectedField; }
            set { this.expectedField = value; }
        }

        /// <summary>
        /// Sets the Expected property
        /// </summary>
        /// <param name="expected">Performs the operation if the specified attribute name and value match.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutAttributesRequest WithExpected(UpdateCondition expected)
        {
            this.expectedField = expected;
            return this;
        }

        /// <summary>
        /// Checks if Expected property is set
        /// </summary>
        /// <returns>true if Expected property is set</returns>
        public bool IsSetExpected()
        {
            return this.expectedField != null;
        }

    }
}
