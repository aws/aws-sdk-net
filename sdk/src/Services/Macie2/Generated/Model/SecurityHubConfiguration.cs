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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies configuration settings that determine which findings are published to Security
    /// Hub automatically. For information about how Macie publishes findings to Security
    /// Hub, see <a href="https://docs.aws.amazon.com/macie/latest/user/securityhub-integration.html">Evaluating
    /// findings with Security Hub</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class SecurityHubConfiguration
    {
        private bool? _publishClassificationFindings;
        private bool? _publishPolicyFindings;

        /// <summary>
        /// Gets and sets the property PublishClassificationFindings. 
        /// <para>
        /// Specifies whether to publish sensitive data findings to Security Hub. If you set this
        /// value to true, Amazon Macie automatically publishes all sensitive data findings that
        /// weren't suppressed by a findings filter. The default value is false.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PublishClassificationFindings
        {
            get { return this._publishClassificationFindings; }
            set { this._publishClassificationFindings = value; }
        }

        // Check to see if PublishClassificationFindings property is set
        internal bool IsSetPublishClassificationFindings()
        {
            return this._publishClassificationFindings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublishPolicyFindings. 
        /// <para>
        /// Specifies whether to publish policy findings to Security Hub. If you set this value
        /// to true, Amazon Macie automatically publishes all new and updated policy findings
        /// that weren't suppressed by a findings filter. The default value is true.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PublishPolicyFindings
        {
            get { return this._publishPolicyFindings; }
            set { this._publishPolicyFindings = value; }
        }

        // Check to see if PublishPolicyFindings property is set
        internal bool IsSetPublishPolicyFindings()
        {
            return this._publishPolicyFindings.HasValue; 
        }

    }
}