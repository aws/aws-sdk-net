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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSecurityHub operation.
    /// Enables Security Hub for your account in the current Region or the Region you specify
    /// in the request.
    /// 
    ///  
    /// <para>
    /// When you enable Security Hub, you grant to Security Hub the permissions necessary
    /// to gather findings from other services that are integrated with Security Hub.
    /// </para>
    ///  
    /// <para>
    /// When you use the <code>EnableSecurityHub</code> operation to enable Security Hub,
    /// you also automatically enable the following standards:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Center for Internet Security (CIS) Amazon Web Services Foundations Benchmark v1.2.0
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services Foundational Security Best Practices
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Other standards are not automatically enabled. 
    /// </para>
    ///  
    /// <para>
    /// To opt out of automatically enabled standards, set <code>EnableDefaultStandards</code>
    /// to <code>false</code>.
    /// </para>
    ///  
    /// <para>
    /// After you enable Security Hub, to enable a standard, use the <code>BatchEnableStandards</code>
    /// operation. To disable a standard, use the <code>BatchDisableStandards</code> operation.
    /// </para>
    ///  
    /// <para>
    /// To learn more, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">setup
    /// information</a> in the <i>Security Hub User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableSecurityHubRequest : AmazonSecurityHubRequest
    {
        private bool? _enableDefaultStandards;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EnableDefaultStandards. 
        /// <para>
        /// Whether to enable the security standards that Security Hub has designated as automatically
        /// enabled. If you do not provide a value for <code>EnableDefaultStandards</code>, it
        /// is set to <code>true</code>. To not enable the automatically enabled standards, set
        /// <code>EnableDefaultStandards</code> to <code>false</code>.
        /// </para>
        /// </summary>
        public bool EnableDefaultStandards
        {
            get { return this._enableDefaultStandards.GetValueOrDefault(); }
            set { this._enableDefaultStandards = value; }
        }

        // Check to see if EnableDefaultStandards property is set
        internal bool IsSetEnableDefaultStandards()
        {
            return this._enableDefaultStandards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the hub resource when you enable Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}