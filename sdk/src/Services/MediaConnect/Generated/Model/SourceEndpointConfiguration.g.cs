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
    /// The configuration settings for a source endpoint. This is a union type, so exactly
    /// one of its members is set, depending on the type of the source endpoint.
    /// </summary>
    public partial class SourceEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property RouterOutput. 
        /// <para>
        /// The configuration settings for a source endpoint that represents a router output.
        /// </para>
        /// </summary>
        public RouterOutputSourceEndpointConfiguration RouterOutput { get; set; }

        /// <summary>
        /// Checks to see if the RouterOutput property is set.
        /// </summary>
        internal bool IsSetRouterOutput() => this.RouterOutput != null;

        /// <summary>
        /// Gets and sets the property Standard. 
        /// <para>
        /// The configuration settings for a standard source endpoint, which represents an external
        /// source.
        /// </para>
        /// </summary>
        public StandardSourceEndpointConfiguration Standard { get; set; }

        /// <summary>
        /// Checks to see if the Standard property is set.
        /// </summary>
        internal bool IsSetStandard() => this.Standard != null;
    }
}
