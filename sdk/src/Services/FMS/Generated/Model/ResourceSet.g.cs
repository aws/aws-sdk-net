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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the resource set. This ID is returned in the responses to
        /// create and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time that the resource set was changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the resource set. You can't change the name of a resource
        /// set after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public ResourceSetStatus ResourceSetStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetStatus property is set.
        /// </summary>
        internal bool IsSetResourceSetStatus() => this.ResourceSetStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceTypeList. 
        /// <para>
        /// Determines the resources that can be associated to the resource set. Depending on
        /// your setting for max results and the number of resource sets, a single call might
        /// not return the full list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ResourceTypeList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypeList property is set.
        /// </summary>
        internal bool IsSetResourceTypeList() => this.ResourceTypeList != null && (this.ResourceTypeList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
