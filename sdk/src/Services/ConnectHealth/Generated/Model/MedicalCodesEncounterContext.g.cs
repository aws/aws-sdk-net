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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Encounter context for a medical coding job. All fields are optional.
    /// </summary>
    public partial class MedicalCodesEncounterContext
    {
        /// <summary>
        /// Gets and sets the property AfterHours. 
        /// <para>
        /// Specifies whether the encounter took place outside regular business hours.
        /// </para>
        /// </summary>
        public bool? AfterHours { get; set; }

        /// <summary>
        /// Checks to see if the AfterHours property is set.
        /// </summary>
        internal bool IsSetAfterHours() => this.AfterHours.HasValue;

        /// <summary>
        /// Gets and sets the property EncounterDate. 
        /// <para>
        /// The date of the encounter, in YYYY-MM-DD format. The date can't be more than one day
        /// after the current date in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EncounterDate { get; set; }

        /// <summary>
        /// Checks to see if the EncounterDate property is set.
        /// </summary>
        internal bool IsSetEncounterDate() => this.EncounterDate != null;

        /// <summary>
        /// Gets and sets the property EncounterDurationMinutes. 
        /// <para>
        /// The duration of the encounter, in minutes, from 1 to 1440.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1440)]
        public int? EncounterDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EncounterDurationMinutes property is set.
        /// </summary>
        internal bool IsSetEncounterDurationMinutes() => this.EncounterDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property EncounterReason. 
        /// <para>
        /// The reason for the encounter. The reason can contain letters, numbers, spaces, periods,
        /// commas, and hyphens, and can't contain only spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 256)]
        public string EncounterReason { get; set; }

        /// <summary>
        /// Checks to see if the EncounterReason property is set.
        /// </summary>
        internal bool IsSetEncounterReason() => this.EncounterReason != null;

        /// <summary>
        /// Gets and sets the property EncounterType. 
        /// <para>
        /// The type of the encounter, either in person or telehealth.
        /// </para>
        /// </summary>
        public EncounterType EncounterType { get; set; }

        /// <summary>
        /// Checks to see if the EncounterType property is set.
        /// </summary>
        internal bool IsSetEncounterType() => this.EncounterType != null;
    }
}
