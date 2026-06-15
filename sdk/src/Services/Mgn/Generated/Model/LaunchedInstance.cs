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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Launched instance.
    /// </summary>
    public partial class LaunchedInstance
    {
        private string _ec2InstanceID;
        private FirstBoot _firstBoot;
        private string _jobid;
        private List<LastKnownCheck> _lastKnownChecks = AWSConfigs.InitializeCollections ? new List<LastKnownCheck>() : null;
        private LastKnownCheckStatus _lastKnownFsxChecksStatus;

        /// <summary>
        /// Gets and sets the property Ec2InstanceID. 
        /// <para>
        /// Launched instance EC2 ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Ec2InstanceID
        {
            get { return this._ec2InstanceID; }
            set { this._ec2InstanceID = value; }
        }

        // Check to see if Ec2InstanceID property is set
        internal bool IsSetEc2InstanceID()
        {
            return this._ec2InstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property FirstBoot. 
        /// <para>
        /// Launched instance first boot.
        /// </para>
        /// </summary>
        public FirstBoot FirstBoot
        {
            get { return this._firstBoot; }
            set { this._firstBoot = value; }
        }

        // Check to see if FirstBoot property is set
        internal bool IsSetFirstBoot()
        {
            return this._firstBoot != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// Launched instance Job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property LastKnownChecks. 
        /// <para>
        /// Launched instance last known checks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<LastKnownCheck> LastKnownChecks
        {
            get { return this._lastKnownChecks; }
            set { this._lastKnownChecks = value; }
        }

        // Check to see if LastKnownChecks property is set
        internal bool IsSetLastKnownChecks()
        {
            return this._lastKnownChecks != null && (this._lastKnownChecks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastKnownFsxChecksStatus. 
        /// <para>
        /// Launched instance last known FSx checks status.
        /// </para>
        /// </summary>
        public LastKnownCheckStatus LastKnownFsxChecksStatus
        {
            get { return this._lastKnownFsxChecksStatus; }
            set { this._lastKnownFsxChecksStatus = value; }
        }

        // Check to see if LastKnownFsxChecksStatus property is set
        internal bool IsSetLastKnownFsxChecksStatus()
        {
            return this._lastKnownFsxChecksStatus != null;
        }

    }
}