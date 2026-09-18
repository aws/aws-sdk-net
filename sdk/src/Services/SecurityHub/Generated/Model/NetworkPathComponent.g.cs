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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a network path component.
    /// </summary>
    public partial class NetworkPathComponent
    {
        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The identifier of a component in the network path.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 32.
        /// </para>
        /// </summary>
        public string ComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentId property is set.
        /// </summary>
        internal bool IsSetComponentId() => this.ComponentId != null;

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of component.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 32.
        /// </para>
        /// </summary>
        public string ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Information about the component that comes after the current component in the network
        /// path.
        /// </para>
        /// </summary>
        public NetworkHeader Egress { get; set; }

        /// <summary>
        /// Checks to see if the Egress property is set.
        /// </summary>
        internal bool IsSetEgress() => this.Egress != null;

        /// <summary>
        /// Gets and sets the property Ingress. 
        /// <para>
        /// Information about the component that comes before the current node in the network
        /// path.
        /// </para>
        /// </summary>
        public NetworkHeader Ingress { get; set; }

        /// <summary>
        /// Checks to see if the Ingress property is set.
        /// </summary>
        internal bool IsSetIngress() => this.Ingress != null;
    }
}
