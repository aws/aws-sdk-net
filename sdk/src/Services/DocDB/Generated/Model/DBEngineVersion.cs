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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about an engine version.
    /// </summary>
    public partial class DBEngineVersion
    {
        private string _dbEngineDescription;
        private string _dbEngineVersionDescription;
        private string _dbParameterGroupFamily;
        private string _engine;
        private string _engineVersion;
        private List<string> _exportableLogTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ServerlessV2FeaturesSupport _serverlessV2FeaturesSupport;
        private List<string> _supportedCACertificateIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportsCertificateRotationWithoutRestart;
        private bool? _supportsLogExportsToCloudwatchLogs;
        private List<UpgradeTarget> _validUpgradeTarget = AWSConfigs.InitializeCollections ? new List<UpgradeTarget>() : null;

        /// <summary>
        /// Gets and sets the property DBEngineDescription. 
        /// <para>
        /// The description of the database engine.
        /// </para>
        /// </summary>
        public string DBEngineDescription
        {
            get { return this._dbEngineDescription; }
            set { this._dbEngineDescription = value; }
        }

        // Check to see if DBEngineDescription property is set
        internal bool IsSetDBEngineDescription()
        {
            return this._dbEngineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBEngineVersionDescription. 
        /// <para>
        /// The description of the database engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionDescription
        {
            get { return this._dbEngineVersionDescription; }
            set { this._dbEngineVersionDescription = value; }
        }

        // Check to see if DBEngineVersionDescription property is set
        internal bool IsSetDBEngineVersionDescription()
        {
            return this._dbEngineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the parameter group family for the database engine.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExportableLogTypes. 
        /// <para>
        /// The types of logs that the database engine has available for export to Amazon CloudWatch
        /// Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportableLogTypes
        {
            get { return this._exportableLogTypes; }
            set { this._exportableLogTypes = value; }
        }

        // Check to see if ExportableLogTypes property is set
        internal bool IsSetExportableLogTypes()
        {
            return this._exportableLogTypes != null && (this._exportableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2FeaturesSupport. 
        /// <para>
        /// Specifies any Amazon DocumentDB Serverless properties or limits that differ between
        /// Amazon DocumentDB engine versions. You can test the values of this attribute when
        /// deciding which Amazon DocumentDB version to use in a new or upgraded cluster. You
        /// can also retrieve the version of an existing cluster and check whether that version
        /// supports certain Amazon DocumentDB Serverless features before you attempt to use those
        /// features.
        /// </para>
        /// </summary>
        public ServerlessV2FeaturesSupport ServerlessV2FeaturesSupport
        {
            get { return this._serverlessV2FeaturesSupport; }
            set { this._serverlessV2FeaturesSupport = value; }
        }

        // Check to see if ServerlessV2FeaturesSupport property is set
        internal bool IsSetServerlessV2FeaturesSupport()
        {
            return this._serverlessV2FeaturesSupport != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedCACertificateIdentifiers. 
        /// <para>
        /// A list of the supported CA certificate identifiers.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/ca_cert_rotation.html">Updating
        /// Your Amazon DocumentDB TLS Certificates</a> and <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/security.encryption.ssl.html">
        /// Encrypting Data in Transit</a> in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedCACertificateIdentifiers
        {
            get { return this._supportedCACertificateIdentifiers; }
            set { this._supportedCACertificateIdentifiers = value; }
        }

        // Check to see if SupportedCACertificateIdentifiers property is set
        internal bool IsSetSupportedCACertificateIdentifiers()
        {
            return this._supportedCACertificateIdentifiers != null && (this._supportedCACertificateIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsCertificateRotationWithoutRestart. 
        /// <para>
        /// Indicates whether the engine version supports rotating the server certificate without
        /// rebooting the DB instance.
        /// </para>
        /// </summary>
        public bool? SupportsCertificateRotationWithoutRestart
        {
            get { return this._supportsCertificateRotationWithoutRestart; }
            set { this._supportsCertificateRotationWithoutRestart = value; }
        }

        // Check to see if SupportsCertificateRotationWithoutRestart property is set
        internal bool IsSetSupportsCertificateRotationWithoutRestart()
        {
            return this._supportsCertificateRotationWithoutRestart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLogExportsToCloudwatchLogs. 
        /// <para>
        /// A value that indicates whether the engine version supports exporting the log types
        /// specified by <c>ExportableLogTypes</c> to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? SupportsLogExportsToCloudwatchLogs
        {
            get { return this._supportsLogExportsToCloudwatchLogs; }
            set { this._supportsLogExportsToCloudwatchLogs = value; }
        }

        // Check to see if SupportsLogExportsToCloudwatchLogs property is set
        internal bool IsSetSupportsLogExportsToCloudwatchLogs()
        {
            return this._supportsLogExportsToCloudwatchLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUpgradeTarget. 
        /// <para>
        /// A list of engine versions that this database engine version can be upgraded to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeTarget> ValidUpgradeTarget
        {
            get { return this._validUpgradeTarget; }
            set { this._validUpgradeTarget = value; }
        }

        // Check to see if ValidUpgradeTarget property is set
        internal bool IsSetValidUpgradeTarget()
        {
            return this._validUpgradeTarget != null && (this._validUpgradeTarget.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}