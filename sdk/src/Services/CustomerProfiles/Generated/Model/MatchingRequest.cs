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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The flag that enables the matching process of duplicate profiles.
    /// </summary>
    public partial class MatchingRequest
    {
        private AutoMerging _autoMerging;
        private bool? _enabled;
        private ExportingConfig _exportingConfig;
        private JobSchedule _jobSchedule;

        /// <summary>
        /// Gets and sets the property AutoMerging. 
        /// <para>
        /// Configuration information about the auto-merging process.
        /// </para>
        /// </summary>
        public AutoMerging AutoMerging
        {
            get { return this._autoMerging; }
            set { this._autoMerging = value; }
        }

        // Check to see if AutoMerging property is set
        internal bool IsSetAutoMerging()
        {
            return this._autoMerging != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the matching process of duplicate profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExportingConfig. 
        /// <para>
        /// Configuration information for exporting Identity Resolution results, for example,
        /// to an S3 bucket.
        /// </para>
        /// </summary>
        public ExportingConfig ExportingConfig
        {
            get { return this._exportingConfig; }
            set { this._exportingConfig = value; }
        }

        // Check to see if ExportingConfig property is set
        internal bool IsSetExportingConfig()
        {
            return this._exportingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobSchedule. 
        /// <para>
        /// The day and time when do you want to start the Identity Resolution Job every week.
        /// </para>
        /// </summary>
        public JobSchedule JobSchedule
        {
            get { return this._jobSchedule; }
            set { this._jobSchedule = value; }
        }

        // Check to see if JobSchedule property is set
        internal bool IsSetJobSchedule()
        {
            return this._jobSchedule != null;
        }

    }
}