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
    /// Container for the parameters to the GetAttributes operation.
    /// Returns all of the attributes associated with the specified item. Optionally, the
    /// attributes returned can be limited to one or more attributes by specifying an attribute
    /// name parameter. 
    /// 
    ///  
    /// <para>
    ///  If the item does not exist on the replica that was accessed for this operation, an
    /// empty set is returned. The system does not return an error as it cannot guarantee
    /// the item does not exist on other replicas. 
    /// </para>
    /// </summary>
    public partial class GetAttributesRequest : AmazonSimpleDBRequest
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _consistentRead;
        private string _domainName;
        private string _itemName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetAttributesRequest() { }

        /// <summary>
        /// Instantiates GetAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item.</param>
        public GetAttributesRequest(string domainName, string itemName)
        {
            _domainName = domainName;
            _itemName = itemName;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. The names of the attributes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConsistentRead. Determines whether or not strong consistency
        /// should be enforced when data is read from SimpleDB. If <c>true</c>, any data previously
        /// written to SimpleDB will be returned. Otherwise, results will be consistent eventually,
        /// and the client may not see data that was written immediately before your read.
        /// </summary>
        public bool? ConsistentRead
        {
            get { return this._consistentRead; }
            set { this._consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this._consistentRead.HasValue; 
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