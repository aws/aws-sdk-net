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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// A set of resources to include in a policy.
    /// </summary>
    public partial class ResourceSet
    {
        private string _description;
        private string _id;
        private DateTime? _lastUpdateTime;
        private string _name;
        private ResourceSetStatus _resourceSetStatus;
        private List<string> _resourceTypeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the resource set. This ID is returned in the responses to
        /// create and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time that the resource set was changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the resource set. You can't change the name of a resource
        /// set after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSetStatus. 
        /// <para>
        /// Indicates whether the resource set is in or out of an admin's Region scope.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The administrator can manage and delete the resource set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUT_OF_ADMIN_SCOPE</c> - The administrator can view the resource set, but they
        /// can't edit or delete the resource set. Existing protections stay in place. Any new
        /// resource that come into scope of the resource set won't be protected.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceSetStatus ResourceSetStatus
        {
            get { return this._resourceSetStatus; }
            set { this._resourceSetStatus = value; }
        }

        // Check to see if ResourceSetStatus property is set
        internal bool IsSetResourceSetStatus()
        {
            return this._resourceSetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeList. 
        /// <para>
        /// Determines the resources that can be associated to the resource set. Depending on
        /// your setting for max results and the number of resource sets, a single call might
        /// not return the full list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ResourceTypeList
        {
            get { return this._resourceTypeList; }
            set { this._resourceTypeList = value; }
        }

        // Check to see if ResourceTypeList property is set
        internal bool IsSetResourceTypeList()
        {
            return this._resourceTypeList != null && (this._resourceTypeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// An optional token that you can use for optimistic locking. Firewall Manager returns
        /// a token to your requests that access the resource set. The token marks the state of
        /// the resource set resource at the time of the request. Update tokens are not allowed
        /// when creating a resource set. After creation, each subsequent update call to the resource
        /// set requires the update token. 
        /// </para>
        ///  
        /// <para>
        /// To make an unconditional change to the resource set, omit the token in your update
        /// request. Without the token, Firewall Manager performs your updates regardless of whether
        /// the resource set has changed since you last retrieved it.
        /// </para>
        ///  
        /// <para>
        /// To make a conditional change to the resource set, provide the token in your update
        /// request. Firewall Manager uses the token to ensure that the resource set hasn't changed
        /// since you last retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the resource set again to get a current copy of it with
        /// a new token. Reapply your changes as needed, then try the operation again using the
        /// new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}