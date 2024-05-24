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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _componentId;
        private string _componentType;
        private NetworkHeader _egress;
        private NetworkHeader _ingress;

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
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

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
        public string ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null;
        }

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Information about the component that comes after the current component in the network
        /// path.
        /// </para>
        /// </summary>
        public NetworkHeader Egress
        {
            get { return this._egress; }
            set { this._egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this._egress != null;
        }

        /// <summary>
        /// Gets and sets the property Ingress. 
        /// <para>
        /// Information about the component that comes before the current node in the network
        /// path.
        /// </para>
        /// </summary>
        public NetworkHeader Ingress
        {
            get { return this._ingress; }
            set { this._ingress = value; }
        }

        // Check to see if Ingress property is set
        internal bool IsSetIngress()
        {
            return this._ingress != null;
        }

    }
}