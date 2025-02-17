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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A set of variables indicating the software update preferences for the gateway.
    /// </summary>
    public partial class SoftwareUpdatePreferences
    {
        private AutomaticUpdatePolicy _automaticUpdatePolicy;

        /// <summary>
        /// Gets and sets the property AutomaticUpdatePolicy. 
        /// <para>
        /// Indicates the automatic update policy for a gateway.
        /// </para>
        ///  
        /// <para>
        ///  <c>ALL_VERSIONS</c> - Enables regular gateway maintenance updates.
        /// </para>
        ///  
        /// <para>
        ///  <c>EMERGENCY_VERSIONS_ONLY</c> - Disables regular gateway maintenance updates. The
        /// gateway will still receive emergency version updates on rare occasions if necessary
        /// to remedy highly critical security or durability issues. You will be notified before
        /// an emergency version update is applied. These updates are applied during your gateway's
        /// scheduled maintenance window.
        /// </para>
        /// </summary>
        public AutomaticUpdatePolicy AutomaticUpdatePolicy
        {
            get { return this._automaticUpdatePolicy; }
            set { this._automaticUpdatePolicy = value; }
        }

        // Check to see if AutomaticUpdatePolicy property is set
        internal bool IsSetAutomaticUpdatePolicy()
        {
            return this._automaticUpdatePolicy != null;
        }

    }
}