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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies optional parameters to add to a policy. The set of valid parameters depends
    /// on the combination of policy type and resource type.
    /// </summary>
    public partial class Parameters
    {
        private bool? _excludeBootVolume;
        private bool? _noReboot;

        /// <summary>
        /// Gets and sets the property ExcludeBootVolume. 
        /// <para>
        /// [EBS Snapshot Management – Instance policies only] Indicates whether to exclude the
        /// root volume from snapshots created using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateSnapshots.html">CreateSnapshots</a>.
        /// The default is false.
        /// </para>
        /// </summary>
        public bool ExcludeBootVolume
        {
            get { return this._excludeBootVolume.GetValueOrDefault(); }
            set { this._excludeBootVolume = value; }
        }

        // Check to see if ExcludeBootVolume property is set
        internal bool IsSetExcludeBootVolume()
        {
            return this._excludeBootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoReboot. 
        /// <para>
        /// Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted
        /// when the lifecycle policy runs. <code>true</code> indicates that targeted instances
        /// are not rebooted when the policy runs. <code>false</code> indicates that target instances
        /// are rebooted when the policy runs. The default is <code>true</code> (instances are
        /// not rebooted).
        /// </para>
        /// </summary>
        public bool NoReboot
        {
            get { return this._noReboot.GetValueOrDefault(); }
            set { this._noReboot = value; }
        }

        // Check to see if NoReboot property is set
        internal bool IsSetNoReboot()
        {
            return this._noReboot.HasValue; 
        }

    }
}