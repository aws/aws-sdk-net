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
    /// Container for the parameters to the BatchGetSecurityControls operation.
    /// Provides details about a batch of security controls for the current Amazon Web Services
    /// account and Amazon Web Services Region.
    /// </summary>
    public partial class BatchGetSecurityControlsRequest : AmazonSecurityHubRequest
    {
        private List<string> _securityControlIds = new List<string>();

        /// <summary>
        /// Gets and sets the property SecurityControlIds. 
        /// <para>
        ///  A list of security controls (identified with <code>SecurityControlId</code>, <code>SecurityControlArn</code>,
        /// or a mix of both parameters). The security control ID or Amazon Resource Name (ARN)
        /// is the same across standards. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityControlIds
        {
            get { return this._securityControlIds; }
            set { this._securityControlIds = value; }
        }

        // Check to see if SecurityControlIds property is set
        internal bool IsSetSecurityControlIds()
        {
            return this._securityControlIds != null && this._securityControlIds.Count > 0; 
        }

    }
}