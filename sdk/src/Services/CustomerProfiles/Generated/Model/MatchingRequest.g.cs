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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AutoMerging. 
        /// <para>
        /// Configuration information about the auto-merging process.
        /// </para>
        /// </summary>
        public AutoMerging AutoMerging { get; set; }

        /// <summary>
        /// Checks to see if the AutoMerging property is set.
        /// </summary>
        internal bool IsSetAutoMerging() => this.AutoMerging != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the matching process of duplicate profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExportingConfig. 
        /// <para>
        /// Configuration information for exporting Identity Resolution results, for example,
        /// to an S3 bucket.
        /// </para>
        /// </summary>
        public ExportingConfig ExportingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExportingConfig property is set.
        /// </summary>
        internal bool IsSetExportingConfig() => this.ExportingConfig != null;

        /// <summary>
        /// Gets and sets the property JobSchedule. 
        /// <para>
        /// The day and time when do you want to start the Identity Resolution Job every week.
        /// </para>
        /// </summary>
        public JobSchedule JobSchedule { get; set; }

        /// <summary>
        /// Checks to see if the JobSchedule property is set.
        /// </summary>
        internal bool IsSetJobSchedule() => this.JobSchedule != null;
    }
}
