/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// to gather findings from AWS Config, Amazon GuardDuty, Amazon Inspector, and Amazon
    /// Macie.
    /// </para>
    ///  
    /// <para>
    /// When you use the <code>EnableSecurityHub</code> operation to enable Security Hub,
    /// you also automatically enable the CIS AWS Foundations standard. You do not enable
    /// the Payment Card Industry Data Security Standard (PCI DSS) standard. To enable a standard,
    /// use the <code> <a>BatchEnableStandards</a> </code> operation. To disable a standard,
    /// use the <code> <a>BatchDisableStandards</a> </code> operation.
    /// </para>
    ///  
    /// <para>
    /// To learn more, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">Setting
    /// Up AWS Security Hub</a> in the <i>AWS Security Hub User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableSecurityHubRequest : AmazonSecurityHubRequest
    {
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the Hub resource when you enable Security Hub.
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