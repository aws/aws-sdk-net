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
    /// The Amazon Web Services Glue connection.
    /// </summary>
    public partial class GlueConnection
    {
        private Dictionary<string, string> _athenaProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AuthenticationConfiguration _authenticationConfiguration;
        private List<string> _compatibleComputeEnvironments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _connectionSchemaVersion;
        private ConnectionType _connectionType;
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _lastConnectionValidationTime;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private List<string> _matchCriteria = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;
        private Dictionary<string, string> _pythonProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sparkProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ConnectionStatus _status;
        private string _statusReason;

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
        public AuthenticationConfiguration AuthenticationConfiguration
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
        /// Gets and sets the property CompatibleComputeEnvironments. 
        /// <para>
        /// The compatible compute environments of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> CompatibleComputeEnvironments
        {
            get { return this._compatibleComputeEnvironments; }
            set { this._compatibleComputeEnvironments = value; }
        }

        // Check to see if CompatibleComputeEnvironments property is set
        internal bool IsSetCompatibleComputeEnvironments()
        {
            return this._compatibleComputeEnvironments != null && (this._compatibleComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// The properties of the Amazon Web Services Glue connection.
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
        /// Gets and sets the property ConnectionSchemaVersion. 
        /// <para>
        /// The connection schema version of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ConnectionSchemaVersion
        {
            get { return this._connectionSchemaVersion; }
            set { this._connectionSchemaVersion = value; }
        }

        // Check to see if ConnectionSchemaVersion property is set
        internal bool IsSetConnectionSchemaVersion()
        {
            return this._connectionSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastConnectionValidationTime. 
        /// <para>
        /// The last validation time of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public DateTime? LastConnectionValidationTime
        {
            get { return this._lastConnectionValidationTime; }
            set { this._lastConnectionValidationTime = value; }
        }

        // Check to see if LastConnectionValidationTime property is set
        internal bool IsSetLastConnectionValidationTime()
        {
            return this._lastConnectionValidationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user who last updated the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp at which the Amazon Web Services Glue connection was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// The match criteria of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null && (this._matchCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
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
        /// The physical connection requirements of the Amazon Web Services Glue connection.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public ConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}