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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about an engine version.
    /// </summary>
    public partial class DBEngineVersion
    {
        /// <summary>
        /// Gets and sets the property DBEngineDescription. 
        /// <para>
        /// The description of the database engine.
        /// </para>
        /// </summary>
        public string DBEngineDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineDescription property is set.
        /// </summary>
        internal bool IsSetDBEngineDescription() => this.DBEngineDescription != null;

        /// <summary>
        /// Gets and sets the property DBEngineVersionDescription. 
        /// <para>
        /// The description of the database engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineVersionDescription property is set.
        /// </summary>
        internal bool IsSetDBEngineVersionDescription() => this.DBEngineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the parameter group family for the database engine.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupFamily() => this.DBParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ExportableLogTypes. 
        /// <para>
        /// The types of logs that the database engine has available for export to Amazon CloudWatch
        /// Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportableLogTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExportableLogTypes property is set.
        /// </summary>
        internal bool IsSetExportableLogTypes() => this.ExportableLogTypes != null && (this.ExportableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ServerlessV2FeaturesSupport ServerlessV2FeaturesSupport { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2FeaturesSupport property is set.
        /// </summary>
        internal bool IsSetServerlessV2FeaturesSupport() => this.ServerlessV2FeaturesSupport != null;

        /// <summary>
        /// Gets and sets the property SupportedCACertificateIdentifiers. 
        /// <para>
        /// A list of the supported CA certificate identifiers.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/ca_cert_rotation.html">Updating
        /// Your Amazon DocumentDB TLS Certificates</a> and <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/security.encryption.ssl.html">
        /// Encrypting Data in Transit</a> in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedCACertificateIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedCACertificateIdentifiers property is set.
        /// </summary>
        internal bool IsSetSupportedCACertificateIdentifiers() => this.SupportedCACertificateIdentifiers != null && (this.SupportedCACertificateIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsCertificateRotationWithoutRestart. 
        /// <para>
        /// Indicates whether the engine version supports rotating the server certificate without
        /// rebooting the DB instance.
        /// </para>
        /// </summary>
        public bool? SupportsCertificateRotationWithoutRestart { get; set; }

        /// <summary>
        /// Checks to see if the SupportsCertificateRotationWithoutRestart property is set.
        /// </summary>
        internal bool IsSetSupportsCertificateRotationWithoutRestart() => this.SupportsCertificateRotationWithoutRestart.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsLogExportsToCloudwatchLogs. 
        /// <para>
        /// A value that indicates whether the engine version supports exporting the log types
        /// specified by <c>ExportableLogTypes</c> to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? SupportsLogExportsToCloudwatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLogExportsToCloudwatchLogs property is set.
        /// </summary>
        internal bool IsSetSupportsLogExportsToCloudwatchLogs() => this.SupportsLogExportsToCloudwatchLogs.HasValue;

        /// <summary>
        /// Gets and sets the property ValidUpgradeTarget. 
        /// <para>
        /// A list of engine versions that this database engine version can be upgraded to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeTarget> ValidUpgradeTarget { get; set; } = AWSConfigs.InitializeCollections ? new List<UpgradeTarget>() : null;

        /// <summary>
        /// Checks to see if the ValidUpgradeTarget property is set.
        /// </summary>
        internal bool IsSetValidUpgradeTarget() => this.ValidUpgradeTarget != null && (this.ValidUpgradeTarget.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
