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
    /// Provides details about a security control for which a response couldn't be returned.
    /// </summary>
    public partial class UnprocessedSecurityControl
    {
        private UnprocessedErrorCode _errorCode;
        private string _errorReason;
        private string _securityControlId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code for the unprocessed security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnprocessedErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        ///  The reason why the security control was unprocessed. 
        /// </para>
        /// </summary>
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The control (identified with <code>SecurityControlId</code>, <code>SecurityControlArn</code>,
        /// or a mix of both parameters) for which a response couldn't be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

    }
}