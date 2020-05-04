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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for the Amazon FSx for Lustre file system.
    /// </summary>
    public partial class LustreFileSystemConfiguration
    {
        private DataRepositoryConfiguration _dataRepositoryConfiguration;
        private LustreDeploymentType _deploymentType;
        private string _mountName;
        private int? _perUnitStorageThroughput;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property DataRepositoryConfiguration.
        /// </summary>
        public DataRepositoryConfiguration DataRepositoryConfiguration
        {
            get { return this._dataRepositoryConfiguration; }
            set { this._dataRepositoryConfiguration = value; }
        }

        // Check to see if DataRepositoryConfiguration property is set
        internal bool IsSetDataRepositoryConfiguration()
        {
            return this._dataRepositoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the FSX for Lustre file system.
        /// </para>
        /// </summary>
        public LustreDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property MountName. 
        /// <para>
        /// You use the <code>MountName</code> value when mounting the file system.
        /// </para>
        ///  
        /// <para>
        /// For the <code>SCRATCH_1</code> deployment type, this value is always "<code>fsx</code>".
        /// For <code>SCRATCH_2</code> and <code>PERSISTENT_1</code> deployment types, this value
        /// is a string that is unique within an AWS Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public string MountName
        {
            get { return this._mountName; }
            set { this._mountName = value; }
        }

        // Check to see if MountName property is set
        internal bool IsSetMountName()
        {
            return this._mountName != null;
        }

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        ///  Per unit storage throughput represents the megabytes per second of read or write
        /// throughput per 1 tebibyte of storage provisioned. File system throughput capacity
        /// is equal to Storage capacity (TiB) * PerUnitStorageThroughput (MB/s/TiB). This option
        /// is only valid for <code>PERSISTENT_1</code> deployment types. Valid values are 50,
        /// 100, 200. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=200)]
        public int PerUnitStorageThroughput
        {
            get { return this._perUnitStorageThroughput.GetValueOrDefault(); }
            set { this._perUnitStorageThroughput = value; }
        }

        // Check to see if PerUnitStorageThroughput property is set
        internal bool IsSetPerUnitStorageThroughput()
        {
            return this._perUnitStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The UTC time that you want to begin your weekly maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}