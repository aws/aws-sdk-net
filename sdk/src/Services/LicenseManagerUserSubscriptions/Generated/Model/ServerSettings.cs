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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Contains settings for a specific server.
    /// </summary>
    public partial class ServerSettings
    {
        private RdsSalSettings _rdsSalSettings;

        /// <summary>
        /// Gets and sets the property RdsSalSettings. 
        /// <para>
        /// The <c>RdsSalSettings</c> resource contains settings to configure a specific Remote
        /// Desktop Services (RDS) license server.
        /// </para>
        /// </summary>
        public RdsSalSettings RdsSalSettings
        {
            get { return this._rdsSalSettings; }
            set { this._rdsSalSettings = value; }
        }

        // Check to see if RdsSalSettings property is set
        internal bool IsSetRdsSalSettings()
        {
            return this._rdsSalSettings != null;
        }

    }
}