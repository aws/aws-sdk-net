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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amaon Redshift lineage sync configuration.
    /// </summary>
    public partial class RedshiftLineageSyncConfigurationOutput
    {
        private bool? _enabled;
        private string _lineageJobId;
        private LineageSyncSchedule _schedule;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the Amaon Redshift lineage sync configuration is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineageJobId. 
        /// <para>
        /// The lineage job ID of the Amaon Redshift lineage sync configuration.
        /// </para>
        /// </summary>
        public string LineageJobId
        {
            get { return this._lineageJobId; }
            set { this._lineageJobId = value; }
        }

        // Check to see if LineageJobId property is set
        internal bool IsSetLineageJobId()
        {
            return this._lineageJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of teh Amaon Redshift lineage sync configuration.
        /// </para>
        /// </summary>
        public LineageSyncSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

    }
}