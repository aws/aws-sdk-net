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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
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
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the PutAttributes operation.
    /// The PutAttributes operation creates or replaces attributes in an item. The client
    /// may specify new attributes using a combination of the <c>Attribute.X.Name</c> and
    /// <c>Attribute.X.Value</c> parameters. The client specifies the first attribute by the
    /// parameters <c>Attribute.0.Name</c> and <c>Attribute.0.Value</c>, the second attribute
    /// by the parameters <c>Attribute.1.Name</c> and <c>Attribute.1.Value</c>, and so on.
    /// 
    /// 
    ///  
    /// <para>
    ///  Attributes are uniquely identified in an item by their name/value combination. For
    /// example, a single item can have the attributes <c>{ "first_name", "first_value" }</c>
    /// and <c>{ "first_name", second_value" }</c>. However, it cannot have two attribute
    /// instances where both the <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> are
    /// the same. 
    /// </para>
    ///  
    /// <para>
    ///  Optionally, the requestor can supply the <c>Replace</c> parameter for each individual
    /// attribute. Setting this value to <c>true</c> causes the new attribute value to replace
    /// the existing attribute value(s). For example, if an item has the attributes <c>{ 'a',
    /// '1' }</c>, <c>{ 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requestor calls <c>PutAttributes</c>
    /// using the attributes <c>{ 'b', '4' }</c> with the <c>Replace</c> parameter set to
    /// true, the final attributes of the item are changed to <c>{ 'a', '1' }</c> and <c>{
    /// 'b', '4' }</c>, which replaces the previous values of the 'b' attribute with the new
    /// value. 
    /// </para>
    ///  
    /// <para>
    ///  You cannot specify an empty string as an attribute name. 
    /// </para>
    ///  
    /// <para>
    ///  Because Amazon SimpleDB makes multiple copies of client data and uses an eventual
    /// consistency update model, an immediate <a>GetAttributes</a> or <a>Select</a> operation
    /// (read) immediately after a <a>PutAttributes</a> or <a>DeleteAttributes</a> operation
    /// (write) might not return the updated data. 
    /// </para>
    ///  
    /// <para>
    ///  The following limitations are enforced for this operation: <ul> <li>256 total attribute
    /// name-value pairs per item</li> <li>One billion attributes per domain</li> <li>10 GB
    /// of total user data storage per domain</li> </ul> 
    /// </para>
    /// </summary>
    public partial class PutAttributesRequest : AmazonSimpleDBRequest
    {
        private List<ReplaceableAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<ReplaceableAttribute>() : null;
        private string _domainName;
        private UpdateCondition _expected;
        private string _itemName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutAttributesRequest() { }

        /// <summary>
        /// Instantiates PutAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item.</param>
        /// <param name="attributes">The list of attributes.</param>
        public PutAttributesRequest(string domainName, string itemName, List<ReplaceableAttribute> attributes)
        {
            _domainName = domainName;
            _itemName = itemName;
            _attributes = attributes;
        }

        /// <summary>
        /// Instantiates PutAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item.</param>
        /// <param name="attributes">The list of attributes.</param>
        /// <param name="expected">The update condition which, if specified, determines whether the specified attributes will be updated or not. The update condition must be satisfied in order for this request to be processed and the attributes to be updated.</param>
        public PutAttributesRequest(string domainName, string itemName, List<ReplaceableAttribute> attributes, UpdateCondition expected)
        {
            _domainName = domainName;
            _itemName = itemName;
            _attributes = attributes;
            _expected = expected;
        }

        /// <summary>
        /// Gets and sets the property Attributes. The list of attributes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplaceableAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain in which to perform
        /// the operation.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Expected. The update condition which, if specified, determines
        /// whether the specified attributes will be updated or not. The update condition must
        /// be satisfied in order for this request to be processed and the attributes to be updated.
        /// </summary>
        public UpdateCondition Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null;
        }

        /// <summary>
        /// Gets and sets the property ItemName. The name of the item.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        // Check to see if ItemName property is set
        internal bool IsSetItemName()
        {
            return this._itemName != null;
        }

    }
}