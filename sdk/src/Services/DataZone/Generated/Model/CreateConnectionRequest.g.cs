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
    /// Container for the parameters to the CreateConnection operation. Creates a new connection.
    /// In Amazon DataZone, a connection enables you to connect your resources (domains, projects,
    /// and environments) to external resources and services.
    /// </summary>
    public partial class CreateConnectionRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location where the connection is created.
        /// </para>
        /// </summary>
        public AwsLocation AwsLocation { get; set; }

        /// <summary>
        /// Checks to see if the AwsLocation property is set.
        /// </summary>
        internal bool IsSetAwsLocation() => this.AwsLocation != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// The configurations of the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A connection description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where the connection is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnableTrustedIdentityPropagation. 
        /// <para>
        /// Specifies whether the trusted identity propagation is enabled.
        /// </para>
        /// </summary>
        public bool? EnableTrustedIdentityPropagation { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrustedIdentityPropagation property is set.
        /// </summary>
        internal bool IsSetEnableTrustedIdentityPropagation() => this.EnableTrustedIdentityPropagation.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment where the connection is created.
        /// </para>
        /// </summary>
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The connection name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Props. 
        /// <para>
        /// The connection props.
        /// </para>
        /// </summary>
        public ConnectionPropertiesInput Props { get; set; }

        /// <summary>
        /// Checks to see if the Props property is set.
        /// </summary>
        internal bool IsSetProps() => this.Props != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the connection.
        /// </para>
        /// </summary>
        public ConnectionScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
