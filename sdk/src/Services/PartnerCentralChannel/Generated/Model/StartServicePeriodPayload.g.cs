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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Payload for start service period handshake requests.
    /// </summary>
    public partial class StartServicePeriodPayload
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the service period.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumNoticeDays. 
        /// <para>
        /// The minimum number of days notice required for changes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string MinimumNoticeDays { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNoticeDays property is set.
        /// </summary>
        internal bool IsSetMinimumNoticeDays() => this.MinimumNoticeDays != null;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A note providing additional information about the service period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 1011)]
        public string ProgramManagementAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProgramManagementAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetProgramManagementAccountIdentifier() => this.ProgramManagementAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServicePeriodType. 
        /// <para>
        /// The type of service period being started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServicePeriodType ServicePeriodType { get; set; }

        /// <summary>
        /// Checks to see if the ServicePeriodType property is set.
        /// </summary>
        internal bool IsSetServicePeriodType() => this.ServicePeriodType != null;
    }
}
