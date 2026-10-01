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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssessmentFrameworkShare operation. Updates
    /// a share request for a custom framework in Audit Manager.
    /// </summary>
    public partial class UpdateAssessmentFrameworkShareRequest : AmazonAuditManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the update action for the share request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ShareRequestAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        ///  The unique identifier for the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RequestType. 
        /// <para>
        /// Specifies whether the share request is a sent request or a received request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ShareRequestType RequestType { get; set; }

        /// <summary>
        /// Checks to see if the RequestType property is set.
        /// </summary>
        internal bool IsSetRequestType() => this.RequestType != null;
    }
}
