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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// An object containing configuration for a compute environment (such as Spark, Python
    /// or Athena) returned by the <c>DescribeConnectionType</c> API.
    /// </summary>
    public partial class ComputeEnvironmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The type of compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeEnvironment ComputeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the ComputeEnvironment property is set.
        /// </summary>
        internal bool IsSetComputeEnvironment() => this.ComputeEnvironment != null;

        /// <summary>
        /// Gets and sets the property ConnectionOptionNameOverrides. 
        /// <para>
        /// The connection option name overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> ConnectionOptionNameOverrides { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionOptionNameOverrides property is set.
        /// </summary>
        internal bool IsSetConnectionOptionNameOverrides() => this.ConnectionOptionNameOverrides != null && (this.ConnectionOptionNameOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// The parameters used as connection options for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, Property> ConnectionOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the ConnectionOptions property is set.
        /// </summary>
        internal bool IsSetConnectionOptions() => this.ConnectionOptions != null && (this.ConnectionOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionPropertiesRequiredOverrides. 
        /// <para>
        /// The connection properties that are required as overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ConnectionPropertiesRequiredOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionPropertiesRequiredOverrides property is set.
        /// </summary>
        internal bool IsSetConnectionPropertiesRequiredOverrides() => this.ConnectionPropertiesRequiredOverrides != null && (this.ConnectionPropertiesRequiredOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionPropertyNameOverrides. 
        /// <para>
        /// The connection property name overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> ConnectionPropertyNameOverrides { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionPropertyNameOverrides property is set.
        /// </summary>
        internal bool IsSetConnectionPropertyNameOverrides() => this.ConnectionPropertyNameOverrides != null && (this.ConnectionPropertyNameOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the compute environment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhysicalConnectionPropertiesRequired. 
        /// <para>
        /// Indicates whether <c>PhysicalConnectionProperties</c> are required for the compute
        /// environment.
        /// </para>
        /// </summary>
        public bool? PhysicalConnectionPropertiesRequired { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalConnectionPropertiesRequired property is set.
        /// </summary>
        internal bool IsSetPhysicalConnectionPropertiesRequired() => this.PhysicalConnectionPropertiesRequired.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedAuthenticationTypes. 
        /// <para>
        /// The supported authentication types for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SupportedAuthenticationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedAuthenticationTypes property is set.
        /// </summary>
        internal bool IsSetSupportedAuthenticationTypes() => this.SupportedAuthenticationTypes != null && (this.SupportedAuthenticationTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
