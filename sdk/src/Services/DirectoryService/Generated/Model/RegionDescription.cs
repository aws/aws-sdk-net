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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// The replicated Region information for a directory.
    /// </summary>
    public partial class RegionDescription
    {
        private int? _desiredNumberOfDomainControllers;
        private string _directoryId;
        private DateTime? _lastUpdatedDateTime;
        private DateTime? _launchTime;
        private string _regionName;
        private RegionType _regionType;
        private DirectoryStage _status;
        private DateTime? _statusLastUpdatedDateTime;
        private DirectoryVpcSettings _vpcSettings;

        /// <summary>
        /// Gets and sets the property DesiredNumberOfDomainControllers. 
        /// <para>
        /// The desired number of domain controllers in the specified Region for the specified
        /// directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? DesiredNumberOfDomainControllers
        {
            get { return this._desiredNumberOfDomainControllers; }
            set { this._desiredNumberOfDomainControllers = value; }
        }

        // Check to see if DesiredNumberOfDomainControllers property is set
        internal bool IsSetDesiredNumberOfDomainControllers()
        {
            return this._desiredNumberOfDomainControllers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the Region description was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// Specifies when the Region replication began.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Region. For example, <c>us-east-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=32)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionType. 
        /// <para>
        /// Specifies whether the Region is the primary Region or an additional Region.
        /// </para>
        /// </summary>
        public RegionType RegionType
        {
            get { return this._regionType; }
            set { this._regionType = value; }
        }

        // Check to see if RegionType property is set
        internal bool IsSetRegionType()
        {
            return this._regionType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication process for the specified Region.
        /// </para>
        /// </summary>
        public DirectoryStage Status
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
        /// Gets and sets the property StatusLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the Region status was last updated.
        /// </para>
        /// </summary>
        public DateTime? StatusLastUpdatedDateTime
        {
            get { return this._statusLastUpdatedDateTime; }
            set { this._statusLastUpdatedDateTime = value; }
        }

        // Check to see if StatusLastUpdatedDateTime property is set
        internal bool IsSetStatusLastUpdatedDateTime()
        {
            return this._statusLastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSettings.
        /// </summary>
        public DirectoryVpcSettings VpcSettings
        {
            get { return this._vpcSettings; }
            set { this._vpcSettings = value; }
        }

        // Check to see if VpcSettings property is set
        internal bool IsSetVpcSettings()
        {
            return this._vpcSettings != null;
        }

    }
}