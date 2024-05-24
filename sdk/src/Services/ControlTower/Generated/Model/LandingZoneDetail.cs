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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Information about the landing zone.
    /// </summary>
    public partial class LandingZoneDetail
    {
        private string _arn;
        private LandingZoneDriftStatusSummary _driftStatus;
        private string _latestAvailableVersion;
        private Amazon.Runtime.Documents.Document _manifest;
        private LandingZoneStatus _status;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the landing zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// The drift status of the landing zone.
        /// </para>
        /// </summary>
        public LandingZoneDriftStatusSummary DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAvailableVersion. 
        /// <para>
        /// The latest available version of the landing zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=10)]
        public string LatestAvailableVersion
        {
            get { return this._latestAvailableVersion; }
            set { this._latestAvailableVersion = value; }
        }

        // Check to see if LatestAvailableVersion property is set
        internal bool IsSetLatestAvailableVersion()
        {
            return this._latestAvailableVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The landing zone manifest JSON text file that specifies the landing zone configurations.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return !this._manifest.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The landing zone deployment status. One of <c>ACTIVE</c>, <c>PROCESSING</c>, <c>FAILED</c>.
        /// </para>
        /// </summary>
        public LandingZoneStatus Status
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The landing zone's current deployed version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=10)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}