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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the installed EKS add-on (GuardDuty security agent).
    /// </summary>
    public partial class AddonDetails
    {
        private string _addonStatus;
        private string _addonVersion;

        /// <summary>
        /// Gets and sets the property AddonStatus. 
        /// <para>
        /// Status of the installed EKS add-on.
        /// </para>
        /// </summary>
        public string AddonStatus
        {
            get { return this._addonStatus; }
            set { this._addonStatus = value; }
        }

        // Check to see if AddonStatus property is set
        internal bool IsSetAddonStatus()
        {
            return this._addonStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// Version of the installed EKS add-on.
        /// </para>
        /// </summary>
        public string AddonVersion
        {
            get { return this._addonVersion; }
            set { this._addonVersion = value; }
        }

        // Check to see if AddonVersion property is set
        internal bool IsSetAddonVersion()
        {
            return this._addonVersion != null;
        }

    }
}