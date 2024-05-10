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
    /// Container for the parameters to the BatchPutAttributes operation.
    /// The <c>BatchPutAttributes</c> operation creates or replaces attributes within one
    /// or more items. By using this operation, the client can perform multiple <a>PutAttribute</a>
    /// operation with a single call. This helps yield savings in round trips and latencies,
    /// enabling Amazon SimpleDB to optimize requests and generally produce better throughput.
    /// 
    /// 
    ///  
    /// <para>
    ///  The client may specify the item name with the <c>Item.X.ItemName</c> parameter. The
    /// client may specify new attributes using a combination of the <c>Item.X.Attribute.Y.Name</c>
    /// and <c>Item.X.Attribute.Y.Value</c> parameters. The client may specify the first attribute
    /// for the first item using the parameters <c>Item.0.Attribute.0.Name</c> and <c>Item.0.Attribute.0.Value</c>,
    /// and for the second attribute for the first item by the parameters <c>Item.0.Attribute.1.Name</c>
    /// and <c>Item.0.Attribute.1.Value</c>, and so on. 
    /// </para>
    ///  
    /// <para>
    ///  Attributes are uniquely identified within an item by their name/value combination.
    /// For example, a single item can have the attributes <c>{ "first_name", "first_value"
    /// }</c> and <c>{ "first_name", "second_value" }</c>. However, it cannot have two attribute
    /// instances where both the <c>Item.X.Attribute.Y.Name</c> and <c>Item.X.Attribute.Y.Value</c>
    /// are the same. 
    /// </para>
    ///  
    /// <para>
    ///  Optionally, the requester can supply the <c>Replace</c> parameter for each individual
    /// value. Setting this value to <c>true</c> will cause the new attribute values to replace
    /// the existing attribute values. For example, if an item <c>I</c> has the attributes
    /// <c>{ 'a', '1' }, { 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requester does a
    /// BatchPutAttributes of <c>{'I', 'b', '4' }</c> with the Replace parameter set to true,
    /// the final attributes of the item will be <c>{ 'a', '1' }</c> and <c>{ 'b', '4' }</c>,
    /// replacing the previous values of the 'b' attribute with the new value. 
    /// </para>
    ///  <important> This operation is vulnerable to exceeding the maximum URL size when making
    /// a REST request using the HTTP GET method. This operation does not support conditions
    /// using <c>Expected.X.Name</c>, <c>Expected.X.Value</c>, or <c>Expected.X.Exists</c>.
    /// </important> 
    /// <para>
    ///  You can execute multiple <c>BatchPutAttributes</c> operations and other operations
    /// in parallel. However, large numbers of concurrent <c>BatchPutAttributes</c> calls
    /// can result in Service Unavailable (503) responses. 
    /// </para>
    ///  
    /// <para>
    ///  The following limitations are enforced for this operation: <ul> <li>256 attribute
    /// name-value pairs per item</li> <li>1 MB request size</li> <li>1 billion attributes
    /// per domain</li> <li>10 GB of total user data storage per domain</li> <li>25 item limit
    /// per <c>BatchPutAttributes</c> operation</li> </ul> 
    /// </para>
    /// </summary>
    public partial class BatchPutAttributesRequest : AmazonSimpleDBRequest
    {
        private string _domainName;
        private List<ReplaceableItem> _items = AWSConfigs.InitializeCollections ? new List<ReplaceableItem>() : null;

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
        /// Gets and sets the property Items. A list of items on which to perform the operation.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplaceableItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}