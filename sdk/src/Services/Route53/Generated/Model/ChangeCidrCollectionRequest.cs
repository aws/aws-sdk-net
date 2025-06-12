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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ChangeCidrCollection operation.
    /// Creates, changes, or deletes CIDR blocks within a collection. Contains authoritative
    /// IP information mapping blocks to one or multiple locations.
    /// 
    ///  
    /// <para>
    /// A change request can update multiple locations in a collection at a time, which is
    /// helpful if you want to move one or more CIDR blocks from one location to another in
    /// one transaction, without downtime. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Limits</b> 
    /// </para>
    ///  
    /// <para>
    /// The max number of CIDR blocks included in the request is 1000. As a result, big updates
    /// require multiple API calls.
    /// </para>
    ///  
    /// <para>
    ///  <b> PUT and DELETE_IF_EXISTS</b> 
    /// </para>
    ///  
    /// <para>
    /// Use <c>ChangeCidrCollection</c> to perform the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>PUT</c>: Create a CIDR block within the specified collection.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> DELETE_IF_EXISTS</c>: Delete an existing CIDR block from the collection.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ChangeCidrCollectionRequest : AmazonRoute53Request
    {
        private string _id;
        private long? _collectionVersion;
        private List<CidrCollectionChange> _changes = AWSConfigs.InitializeCollections ? new List<CidrCollectionChange>() : null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The UUID of the CIDR collection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionVersion. 
        /// <para>
        /// A sequential counter that Amazon Route 53 sets to 1 when you create a collection and
        /// increments it by 1 each time you update the collection.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use <c>ListCidrCollection</c> to get the current value of <c>CollectionVersion</c>
        /// for the collection that you want to update, and then include that value with the change
        /// request. This prevents Route 53 from overwriting an intervening update: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value in the request matches the value of <c>CollectionVersion</c> in the collection,
        /// Route 53 updates the collection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <c>CollectionVersion</c> in the collection is greater than the value
        /// in the request, the collection was changed after you got the version number. Route 53
        /// does not update the collection, and it returns a <c>CidrCollectionVersionMismatch</c>
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? CollectionVersion
        {
            get { return this._collectionVersion; }
            set { this._collectionVersion = value; }
        }

        // Check to see if CollectionVersion property is set
        internal bool IsSetCollectionVersion()
        {
            return this._collectionVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        ///  Information about changes to a CIDR collection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<CidrCollectionChange> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && (this._changes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}