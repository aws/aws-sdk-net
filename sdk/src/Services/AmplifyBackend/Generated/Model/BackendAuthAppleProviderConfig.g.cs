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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Describes Apple social federation configurations for allowing your app users to sign
    /// in using OAuth.
    /// </summary>
    public partial class BackendAuthAppleProviderConfig
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Describes the client_id (also called Services ID) that comes from Apple.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Describes the key_id that comes from Apple.
        /// </para>
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// Describes the private_key that comes from Apple.
        /// </para>
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// Describes the team_id that comes from Apple.
        /// </para>
        /// </summary>
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;
    }
}
