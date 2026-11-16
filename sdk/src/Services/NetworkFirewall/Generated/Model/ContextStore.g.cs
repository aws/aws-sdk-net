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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Contains details about a context store, including its unique identifier and the account
    /// that owns it.
    /// </summary>
    public partial class ContextStore
    {
        /// <summary>
        /// Gets and sets the property ContextStoreId. 
        /// <para>
        /// The unique identifier of the context store. Use this value in <c>ListResourcesInContextStore</c>
        /// to list the resources that the context store records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreId property is set.
        /// </summary>
        internal bool IsSetContextStoreId() => this.ContextStoreId != null;

        /// <summary>
        /// Gets and sets the property ContextStoreOwnerAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string ContextStoreOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetContextStoreOwnerAccountId() => this.ContextStoreOwnerAccountId != null;
    }
}
