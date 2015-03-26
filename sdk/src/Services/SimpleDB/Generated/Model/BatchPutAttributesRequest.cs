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

/*
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutAttributes operation.
    /// The <code>BatchPutAttributes</code> operation creates or replaces attributes within
    /// one or more items. By using this operation, the client can perform multiple <a>PutAttribute</a>
    /// operation with a single call. This helps yield savings in round trips and latencies,
    /// enabling Amazon SimpleDB to optimize requests and generally produce better throughput.
    /// 
    /// 
    ///  
    /// <para>
    ///  The client may specify the item name with the <code>Item.X.ItemName</code> parameter.
    /// The client may specify new attributes using a combination of the <code>Item.X.Attribute.Y.Name</code>
    /// and <code>Item.X.Attribute.Y.Value</code> parameters. The client may specify the first
    /// attribute for the first item using the parameters <code>Item.0.Attribute.0.Name</code>
    /// and <code>Item.0.Attribute.0.Value</code>, and for the second attribute for the first
    /// item by the parameters <code>Item.0.Attribute.1.Name</code> and <code>Item.0.Attribute.1.Value</code>,
    /// and so on. 
    /// </para>
    ///  
    /// <para>
    ///  Attributes are uniquely identified within an item by their name/value combination.
    /// For example, a single item can have the attributes <code>{ "first_name", "first_value"
    /// }</code> and <code>{ "first_name", "second_value" }</code>. However, it cannot have
    /// two attribute instances where both the <code>Item.X.Attribute.Y.Name</code> and <code>Item.X.Attribute.Y.Value</code>
    /// are the same. 
    /// </para>
    ///  
    /// <para>
    ///  Optionally, the requester can supply the <code>Replace</code> parameter for each
    /// individual value. Setting this value to <code>true</code> will cause the new attribute
    /// values to replace the existing attribute values. For example, if an item <code>I</code>
    /// has the attributes <code>{ 'a', '1' }, { 'b', '2'}</code> and <code>{ 'b', '3' }</code>
    /// and the requester does a BatchPutAttributes of <code>{'I', 'b', '4' }</code> with
    /// the Replace parameter set to true, the final attributes of the item will be <code>{
    /// 'a', '1' }</code> and <code>{ 'b', '4' }</code>, replacing the previous values of
    /// the 'b' attribute with the new value. 
    /// </para>
    ///  <important> This operation is vulnerable to exceeding the maximum URL size when making
    /// a REST request using the HTTP GET method. This operation does not support conditions
    /// using <code>Expected.X.Name</code>, <code>Expected.X.Value</code>, or <code>Expected.X.Exists</code>.
    /// </important> 
    /// <para>
    ///  You can execute multiple <code>BatchPutAttributes</code> operations and other operations
    /// in parallel. However, large numbers of concurrent <code>BatchPutAttributes</code>
    /// calls can result in Service Unavailable (503) responses. 
    /// </para>
    ///  
    /// <para>
    ///  The following limitations are enforced for this operation: <ul> <li>256 attribute
    /// name-value pairs per item</li> <li>1 MB request size</li> <li>1 billion attributes
    /// per domain</li> <li>10 GB of total user data storage per domain</li> <li>25 item limit
    /// per <code>BatchPutAttributes</code> operation</li> </ul> 
    /// </para>
    /// </summary>
    public partial class BatchPutAttributesRequest : AmazonSimpleDBRequest
    {
        private string _domainName;
        private List<ReplaceableItem> _items = new List<ReplaceableItem>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BatchPutAttributesRequest() { }

        /// <summary>
        /// Instantiates BatchPutAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which the attributes are being stored.</param>
        /// <param name="items">A list of items on which to perform the operation.</param>
        public BatchPutAttributesRequest(string domainName, List<ReplaceableItem> items)
        {
            _domainName = domainName;
            _items = items;
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain in which the attributes
        /// are being stored.
        /// </summary>
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
        /// Gets and sets the property Items. A list of items on which to perform the operation.
        /// </summary>
        public List<ReplaceableItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

    }
}