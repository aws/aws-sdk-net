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
    /// The VDM attributes that apply to your Amazon SES account.
    /// </summary>
    public partial class VdmAttributes
    {
        /// <summary>
        /// Gets and sets the property DashboardAttributes. 
        /// <para>
        /// Specifies additional settings for your VDM configuration as applicable to the Dashboard.
        /// </para>
        /// </summary>
        public DashboardAttributes DashboardAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DashboardAttributes property is set.
        /// </summary>
        internal bool IsSetDashboardAttributes() => this.DashboardAttributes != null;

        /// <summary>
        /// Gets and sets the property GuardianAttributes. 
        /// <para>
        /// Specifies additional settings for your VDM configuration as applicable to the Guardian.
        /// </para>
        /// </summary>
        public GuardianAttributes GuardianAttributes { get; set; }

        /// <summary>
        /// Checks to see if the GuardianAttributes property is set.
        /// </summary>
        internal bool IsSetGuardianAttributes() => this.GuardianAttributes != null;

        /// <summary>
        /// Gets and sets the property VdmEnabled. 
        /// <para>
        /// Specifies the status of your VDM configuration. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Amazon SES enables VDM for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Amazon SES disables VDM for your account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FeatureStatus VdmEnabled { get; set; }

        /// <summary>
        /// Checks to see if the VdmEnabled property is set.
        /// </summary>
        internal bool IsSetVdmEnabled() => this.VdmEnabled != null;
    }
}
