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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the VDM settings that apply to emails that you send using the
    /// configuration set.
    /// </summary>
    public partial class VdmOptions
    {
        /// <summary>
        /// Gets and sets the property DashboardOptions. 
        /// <para>
        /// Specifies additional settings for your VDM configuration as applicable to the Dashboard.
        /// </para>
        /// </summary>
        public DashboardOptions DashboardOptions { get; set; }

        /// <summary>
        /// Checks to see if the DashboardOptions property is set.
        /// </summary>
        internal bool IsSetDashboardOptions() => this.DashboardOptions != null;

        /// <summary>
        /// Gets and sets the property GuardianOptions. 
        /// <para>
        /// Specifies additional settings for your VDM configuration as applicable to the Guardian.
        /// </para>
        /// </summary>
        public GuardianOptions GuardianOptions { get; set; }

        /// <summary>
        /// Checks to see if the GuardianOptions property is set.
        /// </summary>
        internal bool IsSetGuardianOptions() => this.GuardianOptions != null;
    }
}
