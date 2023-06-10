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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Account.Model
{
    /// <summary>
    /// This is a structure that expresses the Region for a given account, consisting of a
    /// name and opt-in status.
    /// </summary>
    public partial class Region
    {
        private string _regionName;
        private RegionOptStatus _regionOptStatus;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region code of a given Region (for example, <code>us-east-1</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionOptStatus. 
        /// <para>
        /// One of potential statuses a Region can undergo (Enabled, Enabling, Disabled, Disabling,
        /// Enabled_By_Default).
        /// </para>
        /// </summary>
        public RegionOptStatus RegionOptStatus
        {
            get { return this._regionOptStatus; }
            set { this._regionOptStatus = value; }
        }

        // Check to see if RegionOptStatus property is set
        internal bool IsSetRegionOptStatus()
        {
            return this._regionOptStatus != null;
        }

    }
}