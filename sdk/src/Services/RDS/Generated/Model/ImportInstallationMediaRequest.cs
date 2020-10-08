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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ImportInstallationMedia operation.
    /// Imports the installation media for a DB engine that requires an on-premises customer
    /// provided license, such as SQL Server.
    /// </summary>
    public partial class ImportInstallationMediaRequest : AmazonRDSRequest
    {
        private string _customAvailabilityZoneId;
        private string _engine;
        private string _engineInstallationMediaPath;
        private string _engineVersion;
        private string _osInstallationMediaPath;

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneId. 
        /// <para>
        /// The identifier of the custom Availability Zone (AZ) to import the installation media
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomAvailabilityZoneId
        {
            get { return this._customAvailabilityZoneId; }
            set { this._customAvailabilityZoneId = value; }
        }

        // Check to see if CustomAvailabilityZoneId property is set
        internal bool IsSetCustomAvailabilityZoneId()
        {
            return this._customAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to be used for this instance. 
        /// </para>
        ///  
        /// <para>
        /// The list only includes supported DB engines that require an on-premises customer provided
        /// license. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sqlserver-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EngineInstallationMediaPath. 
        /// <para>
        /// The path to the installation medium for the specified DB engine.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>SQLServerISO/en_sql_server_2016_enterprise_x64_dvd_8701793.iso</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngineInstallationMediaPath
        {
            get { return this._engineInstallationMediaPath; }
            set { this._engineInstallationMediaPath = value; }
        }

        // Check to see if EngineInstallationMediaPath property is set
        internal bool IsSetEngineInstallationMediaPath()
        {
            return this._engineInstallationMediaPath != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid engine versions, call <a>DescribeDBEngineVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following are the database engines and links to information about the major and
        /// minor versions. The list only includes DB engines that require an on-premises customer
        /// provided license.
        /// </para>
        ///  
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.VersionSupport">
        /// Microsoft SQL Server Versions on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OSInstallationMediaPath. 
        /// <para>
        /// The path to the installation medium for the operating system associated with the specified
        /// DB engine.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>WindowsISO/en_windows_server_2016_x64_dvd_9327751.iso</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OSInstallationMediaPath
        {
            get { return this._osInstallationMediaPath; }
            set { this._osInstallationMediaPath = value; }
        }

        // Check to see if OSInstallationMediaPath property is set
        internal bool IsSetOSInstallationMediaPath()
        {
            return this._osInstallationMediaPath != null;
        }

    }
}