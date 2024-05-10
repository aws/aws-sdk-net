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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The profile notification summary.
    /// </summary>
    public partial class ProfileNotificationSummary
    {
        private string _currentProfileVersion;
        private string _latestProfileVersion;
        private string _profileArn;
        private string _profileName;
        private ProfileNotificationType _type;
        private string _workloadId;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property CurrentProfileVersion. 
        /// <para>
        /// The current profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string CurrentProfileVersion
        {
            get { return this._currentProfileVersion; }
            set { this._currentProfileVersion = value; }
        }

        // Check to see if CurrentProfileVersion property is set
        internal bool IsSetCurrentProfileVersion()
        {
            return this._currentProfileVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestProfileVersion. 
        /// <para>
        /// The latest profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string LatestProfileVersion
        {
            get { return this._latestProfileVersion; }
            set { this._latestProfileVersion = value; }
        }

        // Check to see if LatestProfileVersion property is set
        internal bool IsSetLatestProfileVersion()
        {
            return this._latestProfileVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The profile ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2084)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of notification.
        /// </para>
        /// </summary>
        public ProfileNotificationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}