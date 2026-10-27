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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the sign-in credentials for the container image registry of an Amazon Lightsail
    /// account.
    /// </summary>
    public partial class ContainerServiceRegistryLogin
    {
        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp of when the container image registry sign-in credentials expire.
        /// </para>
        ///  
        /// <para>
        /// The log in credentials expire 12 hours after they are created, at which point you
        /// will need to create a new set of log in credentials using the <c>CreateContainerServiceRegistryLogin</c>
        /// action.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The container service registry password to use to push container images to the container
        /// image registry of a Lightsail account
        /// </para>
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Registry. 
        /// <para>
        /// The address to use to push container images to the container image registry of a Lightsail
        /// account.
        /// </para>
        /// </summary>
        public string Registry { get; set; }

        /// <summary>
        /// Checks to see if the Registry property is set.
        /// </summary>
        internal bool IsSetRegistry() => this.Registry != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The container service registry username to use to push container images to the container
        /// image registry of a Lightsail account.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
