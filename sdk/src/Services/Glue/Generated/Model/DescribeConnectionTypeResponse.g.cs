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
    /// This is the response object from the DescribeConnectionType operation.
    /// </summary>
    public partial class DescribeConnectionTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AthenaConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Athena compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> AthenaConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the AthenaConnectionProperties property is set.
        /// </summary>
        internal bool IsSetAthenaConnectionProperties() => this.AthenaConnectionProperties != null && (this.AthenaConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The type of authentication used for the connection.
        /// </para>
        /// </summary>
        public AuthConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The supported authentication types, data interface types (compute environments), and
        /// data operations of the connector.
        /// </para>
        /// </summary>
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentConfigurations. 
        /// <para>
        /// The compute environments that are supported by the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComputeEnvironmentConfiguration> ComputeEnvironmentConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComputeEnvironmentConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ComputeEnvironmentConfigurations property is set.
        /// </summary>
        internal bool IsSetComputeEnvironmentConfigurations() => this.ComputeEnvironmentConfigurations != null && (this.ComputeEnvironmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// Returns properties that can be set when creating a connection in the <c>ConnectionInput.ConnectionProperties</c>.
        /// <c>ConnectionOptions</c> defines parameters that can be set in a Spark ETL script
        /// in the connection options map passed to a dataframe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> ConnectionOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the ConnectionOptions property is set.
        /// </summary>
        internal bool IsSetConnectionOptions() => this.ConnectionOptions != null && (this.ConnectionOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// Connection properties which are common across compute environments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> ConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the ConnectionProperties property is set.
        /// </summary>
        internal bool IsSetConnectionProperties() => this.ConnectionProperties != null && (this.ConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The name of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// Physical requirements for a connection, such as VPC, Subnet and Security Group specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> PhysicalConnectionRequirements { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the PhysicalConnectionRequirements property is set.
        /// </summary>
        internal bool IsSetPhysicalConnectionRequirements() => this.PhysicalConnectionRequirements != null && (this.PhysicalConnectionRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PythonConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Python compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> PythonConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the PythonConnectionProperties property is set.
        /// </summary>
        internal bool IsSetPythonConnectionProperties() => this.PythonConnectionProperties != null && (this.PythonConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestConfiguration. 
        /// <para>
        /// HTTP request and response configuration, validation endpoint, and entity configurations
        /// for REST based data source.
        /// </para>
        /// </summary>
        public RestConfiguration RestConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RestConfiguration property is set.
        /// </summary>
        internal bool IsSetRestConfiguration() => this.RestConfiguration != null;

        /// <summary>
        /// Gets and sets the property SparkConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Spark compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> SparkConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Checks to see if the SparkConnectionProperties property is set.
        /// </summary>
        internal bool IsSetSparkConnectionProperties() => this.SparkConnectionProperties != null && (this.SparkConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
