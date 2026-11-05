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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents types of timeouts.
    /// </summary>
    public partial class HttpTimeout
    {
        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        /// An object that represents an idle timeout. An idle timeout bounds the amount of time
        /// that a connection may be idle. The default value is none.
        /// </para>
        /// </summary>
        public Duration Idle { get; set; }

        /// <summary>
        /// Checks to see if the Idle property is set.
        /// </summary>
        internal bool IsSetIdle() => this.Idle != null;

        /// <summary>
        /// Gets and sets the property PerRequest. 
        /// <para>
        /// An object that represents a per request timeout. The default value is 15 seconds.
        /// If you set a higher timeout, then make sure that the higher value is set for each
        /// App Mesh resource in a conversation. For example, if a virtual node backend uses a
        /// virtual router provider to route to another virtual node, then the timeout should
        /// be greater than 15 seconds for the source and destination virtual node and the route.
        /// </para>
        /// </summary>
        public Duration PerRequest { get; set; }

        /// <summary>
        /// Checks to see if the PerRequest property is set.
        /// </summary>
        internal bool IsSetPerRequest() => this.PerRequest != null;
    }
}
