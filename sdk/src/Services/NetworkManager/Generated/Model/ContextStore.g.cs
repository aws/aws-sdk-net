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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a context store.
    /// </summary>
    public partial class ContextStore
    {
        /// <summary>
        /// Gets and sets the property ContextStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ContextStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreArn property is set.
        /// </summary>
        internal bool IsSetContextStoreArn() => this.ContextStoreArn != null;

        /// <summary>
        /// Gets and sets the property ContextStoreId. 
        /// <para>
        /// The ID of the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreId property is set.
        /// </summary>
        internal bool IsSetContextStoreId() => this.ContextStoreId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the context store was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network that the context store belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the context store. The possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The context store is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c>: The context store is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c>: The context store is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The context store is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c>: The context store is deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContextStoreState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the context store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
