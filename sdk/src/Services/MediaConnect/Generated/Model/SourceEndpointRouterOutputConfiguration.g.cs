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
    /// Configuration settings for a router output that is represented by a source endpoint.
    /// </summary>
    public partial class SourceEndpointRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationTransitEncryption.
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointEncryptionConfiguration DestinationTransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitEncryption property is set.
        /// </summary>
        internal bool IsSetDestinationTransitEncryption() => this.DestinationTransitEncryption != null;

        /// <summary>
        /// Gets and sets the property DestinationTransitEncryptionType. 
        /// <para>
        /// The type of transit encryption applied to the destination content that this router
        /// output sends. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SECRETS_MANAGER</c> – The encryption key or passphrase is stored in Secrets Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTOMATIC</c> – MediaConnect determines the encryption key when the endpoint connects.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointEncryptionType DestinationTransitEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitEncryptionType property is set.
        /// </summary>
        internal bool IsSetDestinationTransitEncryptionType() => this.DestinationTransitEncryptionType != null;

        /// <summary>
        /// Gets and sets the property EndpointLifecycleManagement. 
        /// <para>
        /// The entity that manages the lifecycle of the associated source endpoint. Valid values
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MANAGED</c> – MediaConnect manages the lifecycle of the associated source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNMANAGED</c> – You manage the lifecycle of the associated source endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointLifecycle EndpointLifecycleManagement { get; set; }

        /// <summary>
        /// Checks to see if the EndpointLifecycleManagement property is set.
        /// </summary>
        internal bool IsSetEndpointLifecycleManagement() => this.EndpointLifecycleManagement != null;
    }
}
