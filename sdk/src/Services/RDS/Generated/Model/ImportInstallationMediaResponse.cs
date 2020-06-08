/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Contains the installation media for a DB engine that requires an on-premises customer
    /// provided license, such as Microsoft SQL Server.
    /// </summary>
    public partial class ImportInstallationMediaResponse : AmazonWebServiceResponse
    {
        private string _customAvailabilityZoneId;
        private string _engine;
        private string _engineInstallationMediaPath;
        private string _engineVersion;
        private InstallationMediaFailureCause _failureCause;
        private string _installationMediaId;
        private string _osInstallationMediaPath;
        private string _status;

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneId. 
        /// <para>
        /// The custom Availability Zone (AZ) that contains the installation media.
        /// </para>
        /// </summary>
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
        /// The DB engine.
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
        /// Gets and sets the property EngineInstallationMediaPath. 
        /// <para>
        /// The path to the installation medium for the DB engine.
        /// </para>
        /// </summary>
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
        /// The engine version of the DB engine.
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
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// If an installation media failure occurred, the cause of the failure.
        /// </para>
        /// </summary>
        public InstallationMediaFailureCause FailureCause
        {
            get { return this._failureCause; }
            set { this._failureCause = value; }
        }

        // Check to see if FailureCause property is set
        internal bool IsSetFailureCause()
        {
            return this._failureCause != null;
        }

        /// <summary>
        /// Gets and sets the property InstallationMediaId. 
        /// <para>
        /// The installation medium ID.
        /// </para>
        /// </summary>
        public string InstallationMediaId
        {
            get { return this._installationMediaId; }
            set { this._installationMediaId = value; }
        }

        // Check to see if InstallationMediaId property is set
        internal bool IsSetInstallationMediaId()
        {
            return this._installationMediaId != null;
        }

        /// <summary>
        /// Gets and sets the property OSInstallationMediaPath. 
        /// <para>
        /// The path to the installation medium for the operating system associated with the DB
        /// engine.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the installation medium.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}