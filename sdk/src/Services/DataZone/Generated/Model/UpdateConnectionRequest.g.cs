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
    /// Container for the parameters to the UpdateConnection operation. Updates a connection.
    /// In Amazon DataZone, a connection enables you to connect your resources (domains, projects,
    /// and environments) to external resources and services.
    /// </summary>
    public partial class UpdateConnectionRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location where a connection is to be updated.
        /// </para>
        /// </summary>
        public AwsLocation AwsLocation { get; set; }

        /// <summary>
        /// Checks to see if the AwsLocation property is set.
        /// </summary>
        internal bool IsSetAwsLocation() => this.AwsLocation != null;

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
        /// The description of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where a connection is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the connection to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Props. 
        /// <para>
        /// The connection props.
        /// </para>
        /// </summary>
        public ConnectionPropertiesPatch Props { get; set; }

        /// <summary>
        /// Checks to see if the Props property is set.
        /// </summary>
        internal bool IsSetProps() => this.Props != null;
    }
}
