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
    /// This is the response object from the BatchGetSecurityControls operation.
    /// </summary>
    public partial class BatchGetSecurityControlsResponse : AmazonWebServiceResponse
    {
        private List<SecurityControl> _securityControls = new List<SecurityControl>();
        private List<UnprocessedSecurityControl> _unprocessedIds = new List<UnprocessedSecurityControl>();

        /// <summary>
        /// Gets and sets the property SecurityControls. 
        /// <para>
        ///  An array that returns the identifier, Amazon Resource Name (ARN), and other details
        /// about a security control. The same information is returned whether the request includes
        /// <code>SecurityControlId</code> or <code>SecurityControlArn</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SecurityControl> SecurityControls
        {
            get { return this._securityControls; }
            set { this._securityControls = value; }
        }

        // Check to see if SecurityControls property is set
        internal bool IsSetSecurityControls()
        {
            return this._securityControls != null && this._securityControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedIds. 
        /// <para>
        ///  A security control (identified with <code>SecurityControlId</code>, <code>SecurityControlArn</code>,
        /// or a mix of both parameters) for which details cannot be returned. 
        /// </para>
        /// </summary>
        public List<UnprocessedSecurityControl> UnprocessedIds
        {
            get { return this._unprocessedIds; }
            set { this._unprocessedIds = value; }
        }

        // Check to see if UnprocessedIds property is set
        internal bool IsSetUnprocessedIds()
        {
            return this._unprocessedIds != null && this._unprocessedIds.Count > 0; 
        }

    }
}