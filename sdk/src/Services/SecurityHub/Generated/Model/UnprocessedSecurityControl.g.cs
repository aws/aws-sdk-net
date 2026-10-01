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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a security control for which a response couldn't be returned.
    /// </summary>
    public partial class UnprocessedSecurityControl
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code for the unprocessed security control. The <c>NOT_FOUND</c> value has
        /// been deprecated and replaced by the <c>RESOURCE_NOT_FOUND</c> value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UnprocessedErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        ///  The reason why the security control was unprocessed. 
        /// </para>
        /// </summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReason property is set.
        /// </summary>
        internal bool IsSetErrorReason() => this.ErrorReason != null;

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The control (identified with <c>SecurityControlId</c>, <c>SecurityControlArn</c>,
        /// or a mix of both parameters) for which a response couldn't be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityControlId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityControlId property is set.
        /// </summary>
        internal bool IsSetSecurityControlId() => this.SecurityControlId != null;
    }
}
