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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The configuration for an Iceberg orphan file deletion optimizer.
    /// </summary>
    public partial class IcebergOrphanFileDeletionConfiguration
    {
        private string _location;
        private int? _orphanFileRetentionPeriodInDays;
        private int? _runRateInHours;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Specifies a directory in which to look for files (defaults to the table's location).
        /// You may choose a sub-directory rather than the top-level table location.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OrphanFileRetentionPeriodInDays. 
        /// <para>
        /// The number of days that orphan files should be retained before file deletion. If an
        /// input is not provided, the default value 3 will be used.
        /// </para>
        /// </summary>
        public int? OrphanFileRetentionPeriodInDays
        {
            get { return this._orphanFileRetentionPeriodInDays; }
            set { this._orphanFileRetentionPeriodInDays = value; }
        }

        // Check to see if OrphanFileRetentionPeriodInDays property is set
        internal bool IsSetOrphanFileRetentionPeriodInDays()
        {
            return this._orphanFileRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunRateInHours. 
        /// <para>
        /// The interval in hours between orphan file deletion job runs. This parameter controls
        /// how frequently the orphan file deletion optimizer will run to clean up orphan files.
        /// The value must be between 3 and 168 hours (7 days). If an input is not provided, the
        /// default value 24 will be used.
        /// </para>
        /// </summary>
        public int? RunRateInHours
        {
            get { return this._runRateInHours; }
            set { this._runRateInHours = value; }
        }

        // Check to see if RunRateInHours property is set
        internal bool IsSetRunRateInHours()
        {
            return this._runRateInHours.HasValue; 
        }

    }
}