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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents an actor used during penetration testing. An actor defines a user or entity
    /// that interacts with the target application, including authentication credentials and
    /// target URIs.
    /// </summary>
    public partial class Actor
    {
        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// The authentication configuration for the actor.
        /// </para>
        /// </summary>
        public Authentication Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the actor.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableEmailMfa. 
        /// <para>
        /// Whether email-based MFA is enabled for this actor.
        /// </para>
        /// </summary>
        public bool? EnableEmailMfa { get; set; }

        /// <summary>
        /// Checks to see if the EnableEmailMfa property is set.
        /// </summary>
        internal bool IsSetEnableEmailMfa() => this.EnableEmailMfa.HasValue;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier for the actor.
        /// </para>
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property MfaForwardingAddress. 
        /// <para>
        /// Server-generated email forwarding address for receiving MFA codes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MfaForwardingAddress { get; set; }

        /// <summary>
        /// Checks to see if the MfaForwardingAddress property is set.
        /// </summary>
        internal bool IsSetMfaForwardingAddress() => this.MfaForwardingAddress != null;

        /// <summary>
        /// Gets and sets the property Uris. 
        /// <para>
        /// The list of URIs that the actor targets during testing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Uris { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Uris property is set.
        /// </summary>
        internal bool IsSetUris() => this.Uris != null && (this.Uris.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
