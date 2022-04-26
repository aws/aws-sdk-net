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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// The metadata for a feature. For example, the metadata might indicate that a feature
    /// is turned on or off on a specific DB instance.
    /// </summary>
    public partial class FeatureMetadata
    {
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the feature on the DB instance. Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> - The feature is enabled on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> - The feature is disabled on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNSUPPORTED</code> - The feature isn't supported on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED_PENDING_REBOOT</code> - The feature is enabled on the instance but
        /// requires a reboot to take effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED_PENDING_REBOOT</code> - The feature is disabled on the instance but
        /// requires a reboot to take effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN</code> - The feature status couldn't be determined.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FeatureStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}