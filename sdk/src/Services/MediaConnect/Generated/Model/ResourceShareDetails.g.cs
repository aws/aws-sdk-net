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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The cross-account sharing details for an endpoint. Endpoints are shared through Resource
    /// Access Manager (RAM). This is a union type, so exactly one of its members is set:
    /// <c>owned</c> when this account owns the endpoint and shares it with other accounts,
    /// or <c>consumed</c> when this account consumes an endpoint that another account shares.
    /// To change how an endpoint is shared, use RAM.
    /// </summary>
    public partial class ResourceShareDetails
    {
        /// <summary>
        /// Gets and sets the property Consumed. 
        /// <para>
        /// The sharing details for an endpoint that another account shares with this account
        /// through RAM.
        /// </para>
        /// </summary>
        public ConsumedResourceShareDetails Consumed { get; set; }

        /// <summary>
        /// Checks to see if the Consumed property is set.
        /// </summary>
        internal bool IsSetConsumed() => this.Consumed != null;

        /// <summary>
        /// Gets and sets the property Owned. 
        /// <para>
        /// The sharing details for an endpoint that this account owns and shares with other accounts
        /// through RAM.
        /// </para>
        /// </summary>
        public OwnedResourceShareDetails Owned { get; set; }

        /// <summary>
        /// Checks to see if the Owned property is set.
        /// </summary>
        internal bool IsSetOwned() => this.Owned != null;
    }
}
