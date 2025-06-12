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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private Dictionary<string, Property> _athenaConnectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private AuthConfiguration _authenticationConfiguration;
        private Capabilities _capabilities;
        private Dictionary<string, ComputeEnvironmentConfiguration> _computeEnvironmentConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, ComputeEnvironmentConfiguration>() : null;
        private Dictionary<string, Property> _connectionOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Dictionary<string, Property> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private string _connectionType;
        private string _description;
        private Dictionary<string, Property> _physicalConnectionRequirements = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Dictionary<string, Property> _pythonConnectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Dictionary<string, Property> _sparkConnectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;

        /// <summary>
        /// Gets and sets the property AthenaConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Athena compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> AthenaConnectionProperties
        {
            get { return this._athenaConnectionProperties; }
            set { this._athenaConnectionProperties = value; }
        }

        // Check to see if AthenaConnectionProperties property is set
        internal bool IsSetAthenaConnectionProperties()
        {
            return this._athenaConnectionProperties != null && (this._athenaConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The type of authentication used for the connection.
        /// </para>
        /// </summary>
        public AuthConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The supported authentication types, data interface types (compute environments), and
        /// data operations of the connector.
        /// </para>
        /// </summary>
        public Capabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentConfigurations. 
        /// <para>
        /// The compute environments that are supported by the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComputeEnvironmentConfiguration> ComputeEnvironmentConfigurations
        {
            get { return this._computeEnvironmentConfigurations; }
            set { this._computeEnvironmentConfigurations = value; }
        }

        // Check to see if ComputeEnvironmentConfigurations property is set
        internal bool IsSetComputeEnvironmentConfigurations()
        {
            return this._computeEnvironmentConfigurations != null && (this._computeEnvironmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// Returns properties that can be set when creating a connection in the <c>ConnectionInput.ConnectionProperties</c>.
        /// <c>ConnectionOptions</c> defines parameters that can be set in a Spark ETL script
        /// in the connection options map passed to a dataframe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> ConnectionOptions
        {
            get { return this._connectionOptions; }
            set { this._connectionOptions = value; }
        }

        // Check to see if ConnectionOptions property is set
        internal bool IsSetConnectionOptions()
        {
            return this._connectionOptions != null && (this._connectionOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// Connection properties which are common across compute environments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && (this._connectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The name of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// Physical requirements for a connection, such as VPC, Subnet and Security Group specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> PhysicalConnectionRequirements
        {
            get { return this._physicalConnectionRequirements; }
            set { this._physicalConnectionRequirements = value; }
        }

        // Check to see if PhysicalConnectionRequirements property is set
        internal bool IsSetPhysicalConnectionRequirements()
        {
            return this._physicalConnectionRequirements != null && (this._physicalConnectionRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PythonConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Python compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> PythonConnectionProperties
        {
            get { return this._pythonConnectionProperties; }
            set { this._pythonConnectionProperties = value; }
        }

        // Check to see if PythonConnectionProperties property is set
        internal bool IsSetPythonConnectionProperties()
        {
            return this._pythonConnectionProperties != null && (this._pythonConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparkConnectionProperties. 
        /// <para>
        /// Connection properties specific to the Spark compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> SparkConnectionProperties
        {
            get { return this._sparkConnectionProperties; }
            set { this._sparkConnectionProperties = value; }
        }

        // Check to see if SparkConnectionProperties property is set
        internal bool IsSetSparkConnectionProperties()
        {
            return this._sparkConnectionProperties != null && (this._sparkConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}