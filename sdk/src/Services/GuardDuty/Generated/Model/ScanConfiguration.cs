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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the configuration used for the malware scan.
    /// </summary>
    public partial class ScanConfiguration
    {
        private IncrementalScanDetails _incrementalScanDetails;
        private ScanConfigurationRecoveryPoint _recoveryPoint;
        private string _role;
        private TriggerDetails _triggerDetails;

        /// <summary>
        /// Gets and sets the property IncrementalScanDetails. 
        /// <para>
        /// Information about the incremental scan configuration, if applicable.
        /// </para>
        /// </summary>
        public IncrementalScanDetails IncrementalScanDetails
        {
            get { return this._incrementalScanDetails; }
            set { this._incrementalScanDetails = value; }
        }

        // Check to see if IncrementalScanDetails property is set
        internal bool IsSetIncrementalScanDetails()
        {
            return this._incrementalScanDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPoint. 
        /// <para>
        /// Information about the recovery point configuration used for the scan, if applicable.
        /// </para>
        /// </summary>
        public ScanConfigurationRecoveryPoint RecoveryPoint
        {
            get { return this._recoveryPoint; }
            set { this._recoveryPoint = value; }
        }

        // Check to see if RecoveryPoint property is set
        internal bool IsSetRecoveryPoint()
        {
            return this._recoveryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM role that should contain the required permissions
        /// for the scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Information about the entity that triggered the malware scan.
        /// </para>
        /// </summary>
        public TriggerDetails TriggerDetails
        {
            get { return this._triggerDetails; }
            set { this._triggerDetails = value; }
        }

        // Check to see if TriggerDetails property is set
        internal bool IsSetTriggerDetails()
        {
            return this._triggerDetails != null;
        }

    }
}