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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The self-upgrade configuration for the Quick Suite account.
    /// </summary>
    public partial class SelfUpgradeConfiguration
    {
        private SelfUpgradeStatus _selfUpgradeStatus;

        /// <summary>
        /// Gets and sets the property SelfUpgradeStatus. 
        /// <para>
        /// Status set for the self-upgrade configuration for the Quick Suite account. It can
        /// contain the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO_APPROVAL</c>: All the self-upgrade requests will be auto approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN_APPROVAL</c>: All the self-upgrade requests will require admin approval.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SelfUpgradeStatus SelfUpgradeStatus
        {
            get { return this._selfUpgradeStatus; }
            set { this._selfUpgradeStatus = value; }
        }

        // Check to see if SelfUpgradeStatus property is set
        internal bool IsSetSelfUpgradeStatus()
        {
            return this._selfUpgradeStatus != null;
        }

    }
}