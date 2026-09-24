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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The physical endpoints of a connection.
    /// </summary>
    public partial class PhysicalEndpoint
    {
        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location of a connection.
        /// </para>
        /// </summary>
        public AwsLocation AwsLocation { get; set; }

        /// <summary>
        /// Checks to see if the AwsLocation property is set.
        /// </summary>
        internal bool IsSetAwsLocation() => this.AwsLocation != null;

        /// <summary>
        /// Gets and sets the property EnableTrustedIdentityPropagation. 
        /// <para>
        /// Specified whether trusted identity propagation for the connection is enabled.
        /// </para>
        /// </summary>
        public bool? EnableTrustedIdentityPropagation { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrustedIdentityPropagation property is set.
        /// </summary>
        internal bool IsSetEnableTrustedIdentityPropagation() => this.EnableTrustedIdentityPropagation.HasValue;

        /// <summary>
        /// Gets and sets the property GlueConnection. 
        /// <para>
        /// The Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public GlueConnection GlueConnection { get; set; }

        /// <summary>
        /// Checks to see if the GlueConnection property is set.
        /// </summary>
        internal bool IsSetGlueConnection() => this.GlueConnection != null;

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Amazon Web Services Glue connection name.
        /// </para>
        /// </summary>
        public string GlueConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the GlueConnectionName property is set.
        /// </summary>
        internal bool IsSetGlueConnectionName() => this.GlueConnectionName != null;

        /// <summary>
        /// Gets and sets the property GlueConnectionNames. 
        /// <para>
        /// The Amazon Web Services Glue connection names in the physical endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> GlueConnectionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlueConnectionNames property is set.
        /// </summary>
        internal bool IsSetGlueConnectionNames() => this.GlueConnectionNames != null && (this.GlueConnectionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
