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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Information about a Sidewalk device that has been added to an import task.
    /// </summary>
    public partial class ImportedSidewalkDevice
    {
        private DateTime? _lastUpdateTime;
        private OnboardStatus _onboardingStatus;
        private string _onboardingStatusReason;
        private string _sidewalkManufacturingSn;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time at which the status information was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnboardingStatus. 
        /// <para>
        /// The onboarding status of the Sidewalk device in the import task.
        /// </para>
        /// </summary>
        public OnboardStatus OnboardingStatus
        {
            get { return this._onboardingStatus; }
            set { this._onboardingStatus = value; }
        }

        // Check to see if OnboardingStatus property is set
        internal bool IsSetOnboardingStatus()
        {
            return this._onboardingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OnboardingStatusReason. 
        /// <para>
        /// The reason for the onboarding status information for the Sidewalk device.
        /// </para>
        /// </summary>
        public string OnboardingStatusReason
        {
            get { return this._onboardingStatusReason; }
            set { this._onboardingStatusReason = value; }
        }

        // Check to see if OnboardingStatusReason property is set
        internal bool IsSetOnboardingStatusReason()
        {
            return this._onboardingStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing serial number (SMSN) of the Sidewalk device.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string SidewalkManufacturingSn
        {
            get { return this._sidewalkManufacturingSn; }
            set { this._sidewalkManufacturingSn = value; }
        }

        // Check to see if SidewalkManufacturingSn property is set
        internal bool IsSetSidewalkManufacturingSn()
        {
            return this._sidewalkManufacturingSn != null;
        }

    }
}