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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration for creating an Autonomous Database as a refreshable clone.
    /// </summary>
    public partial class CloneToRefreshableConfiguration
    {
        private int? _autoRefreshFrequencyInSeconds;
        private int? _autoRefreshPointLagInSeconds;
        private CloneType _cloneType;
        private OpenMode _openMode;
        private RefreshableMode _refreshableMode;
        private string _sourceAutonomousDatabaseId;
        private DateTime? _timeOfAutoRefreshStart;

        /// <summary>
        /// Gets and sets the property AutoRefreshFrequencyInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the refreshable clone is automatically refreshed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3600, Max=604800)]
        public int? AutoRefreshFrequencyInSeconds
        {
            get { return this._autoRefreshFrequencyInSeconds; }
            set { this._autoRefreshFrequencyInSeconds = value; }
        }

        // Check to see if AutoRefreshFrequencyInSeconds property is set
        internal bool IsSetAutoRefreshFrequencyInSeconds()
        {
            return this._autoRefreshFrequencyInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoRefreshPointLagInSeconds. 
        /// <para>
        /// The time lag, in seconds, between the refreshable clone and its source database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=604800)]
        public int? AutoRefreshPointLagInSeconds
        {
            get { return this._autoRefreshPointLagInSeconds; }
            set { this._autoRefreshPointLagInSeconds = value; }
        }

        // Check to see if AutoRefreshPointLagInSeconds property is set
        internal bool IsSetAutoRefreshPointLagInSeconds()
        {
            return this._autoRefreshPointLagInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloneType. 
        /// <para>
        /// The type of clone to create.
        /// </para>
        /// </summary>
        public CloneType CloneType
        {
            get { return this._cloneType; }
            set { this._cloneType = value; }
        }

        // Check to see if CloneType property is set
        internal bool IsSetCloneType()
        {
            return this._cloneType != null;
        }

        /// <summary>
        /// Gets and sets the property OpenMode. 
        /// <para>
        /// The mode in which to open the refreshable clone, either read-only or read/write.
        /// </para>
        /// </summary>
        public OpenMode OpenMode
        {
            get { return this._openMode; }
            set { this._openMode = value; }
        }

        // Check to see if OpenMode property is set
        internal bool IsSetOpenMode()
        {
            return this._openMode != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshableMode. 
        /// <para>
        /// The refresh mode of the refreshable clone, either automatic or manual.
        /// </para>
        /// </summary>
        public RefreshableMode RefreshableMode
        {
            get { return this._refreshableMode; }
            set { this._refreshableMode = value; }
        }

        // Check to see if RefreshableMode property is set
        internal bool IsSetRefreshableMode()
        {
            return this._refreshableMode != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the source Autonomous Database to create the refreshable
        /// clone from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string SourceAutonomousDatabaseId
        {
            get { return this._sourceAutonomousDatabaseId; }
            set { this._sourceAutonomousDatabaseId = value; }
        }

        // Check to see if SourceAutonomousDatabaseId property is set
        internal bool IsSetSourceAutonomousDatabaseId()
        {
            return this._sourceAutonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOfAutoRefreshStart. 
        /// <para>
        /// The date and time at which the automatic refresh of the refreshable clone starts.
        /// </para>
        /// </summary>
        public DateTime? TimeOfAutoRefreshStart
        {
            get { return this._timeOfAutoRefreshStart; }
            set { this._timeOfAutoRefreshStart = value; }
        }

        // Check to see if TimeOfAutoRefreshStart property is set
        internal bool IsSetTimeOfAutoRefreshStart()
        {
            return this._timeOfAutoRefreshStart.HasValue; 
        }

    }
}