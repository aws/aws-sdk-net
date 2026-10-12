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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A connection string profile for an Autonomous Database.
    /// </summary>
    public partial class DatabaseConnectionStringProfile
    {
        /// <summary>
        /// Gets and sets the property ConsumerGroup. 
        /// <para>
        /// The consumer group associated with the connection string profile.
        /// </para>
        /// </summary>
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerGroup property is set.
        /// </summary>
        internal bool IsSetConsumerGroup() => this.ConsumerGroup != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the connection string profile.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property HostFormat. 
        /// <para>
        /// The host name format used in the connection string.
        /// </para>
        /// </summary>
        public string HostFormat { get; set; }

        /// <summary>
        /// Checks to see if the HostFormat property is set.
        /// </summary>
        internal bool IsSetHostFormat() => this.HostFormat != null;

        /// <summary>
        /// Gets and sets the property IsRegional. 
        /// <para>
        /// Indicates whether the connection string profile is regional.
        /// </para>
        /// </summary>
        public bool? IsRegional { get; set; }

        /// <summary>
        /// Checks to see if the IsRegional property is set.
        /// </summary>
        internal bool IsSetIsRegional() => this.IsRegional.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used by the connection string profile.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SessionMode. 
        /// <para>
        /// The session mode of the connection string profile.
        /// </para>
        /// </summary>
        public string SessionMode { get; set; }

        /// <summary>
        /// Checks to see if the SessionMode property is set.
        /// </summary>
        internal bool IsSetSessionMode() => this.SessionMode != null;

        /// <summary>
        /// Gets and sets the property SyntaxFormat. 
        /// <para>
        /// The syntax format of the connection string profile.
        /// </para>
        /// </summary>
        public string SyntaxFormat { get; set; }

        /// <summary>
        /// Checks to see if the SyntaxFormat property is set.
        /// </summary>
        internal bool IsSetSyntaxFormat() => this.SyntaxFormat != null;

        /// <summary>
        /// Gets and sets the property TlsAuthentication. 
        /// <para>
        /// The TLS authentication method used by the connection string profile.
        /// </para>
        /// </summary>
        public string TlsAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the TlsAuthentication property is set.
        /// </summary>
        internal bool IsSetTlsAuthentication() => this.TlsAuthentication != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The connection string value of the profile.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
