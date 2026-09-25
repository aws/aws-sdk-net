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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Information about a Sidewalk device that has been added to an import task.
    /// </summary>
    public partial class ImportedSidewalkDevice
    {
        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time at which the status information was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property OnboardingStatus. 
        /// <para>
        /// The onboarding status of the Sidewalk device in the import task.
        /// </para>
        /// </summary>
        public OnboardStatus OnboardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the OnboardingStatus property is set.
        /// </summary>
        internal bool IsSetOnboardingStatus() => this.OnboardingStatus != null;

        /// <summary>
        /// Gets and sets the property OnboardingStatusReason. 
        /// <para>
        /// The reason for the onboarding status information for the Sidewalk device.
        /// </para>
        /// </summary>
        public string OnboardingStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the OnboardingStatusReason property is set.
        /// </summary>
        internal bool IsSetOnboardingStatusReason() => this.OnboardingStatusReason != null;

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing serial number (SMSN) of the Sidewalk device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SidewalkManufacturingSn { get; set; }

        /// <summary>
        /// Checks to see if the SidewalkManufacturingSn property is set.
        /// </summary>
        internal bool IsSetSidewalkManufacturingSn() => this.SidewalkManufacturingSn != null;
    }
}
