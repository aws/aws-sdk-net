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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The Amazon Web Services Glue connecton input.
    /// </summary>
    public partial class GlueConnectionInput
    {
        private Dictionary<string, string> _athenaProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AuthenticationConfigurationInput _authenticationConfiguration;
        private Dictionary<string, string> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private GlueConnectionType _connectionType;
        private string _description;
        private string _matchCriteria;
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;
        private Dictionary<string, string> _pythonProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sparkProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _validateCredentials;
        private List<string> _validateForComputeEnvironments = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// The Amazon Athena properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AthenaProperties
        {
            get { return this._athenaProperties; }
            set { this._athenaProperties = value; }
        }

        // Check to see if AthenaProperties property is set
        internal bool IsSetAthenaProperties()
        {
            return this._athenaProperties != null && (this._athenaProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public AuthenticationConfigurationInput AuthenticationConfiguration
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
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// The connection properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ConnectionProperties
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
        /// The connection type of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public GlueConnectionType ConnectionType
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
        /// The description of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// The match criteria of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// The physical connection requirements for the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements
        {
            get { return this._physicalConnectionRequirements; }
            set { this._physicalConnectionRequirements = value; }
        }

        // Check to see if PhysicalConnectionRequirements property is set
        internal bool IsSetPhysicalConnectionRequirements()
        {
            return this._physicalConnectionRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property PythonProperties. 
        /// <para>
        /// The Python properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PythonProperties
        {
            get { return this._pythonProperties; }
            set { this._pythonProperties = value; }
        }

        // Check to see if PythonProperties property is set
        internal bool IsSetPythonProperties()
        {
            return this._pythonProperties != null && (this._pythonProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// The Spark properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties
        {
            get { return this._sparkProperties; }
            set { this._sparkProperties = value; }
        }

        // Check to see if SparkProperties property is set
        internal bool IsSetSparkProperties()
        {
            return this._sparkProperties != null && (this._sparkProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidateCredentials. 
        /// <para>
        /// Speciefies whether to validate credentials of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public bool? ValidateCredentials
        {
            get { return this._validateCredentials; }
            set { this._validateCredentials = value; }
        }

        // Check to see if ValidateCredentials property is set
        internal bool IsSetValidateCredentials()
        {
            return this._validateCredentials.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidateForComputeEnvironments. 
        /// <para>
        /// Speciefies whether to validate for compute environments of the Amazon Web Services
        /// Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ValidateForComputeEnvironments
        {
            get { return this._validateForComputeEnvironments; }
            set { this._validateForComputeEnvironments = value; }
        }

        // Check to see if ValidateForComputeEnvironments property is set
        internal bool IsSetValidateForComputeEnvironments()
        {
            return this._validateForComputeEnvironments != null && (this._validateForComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}