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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the RejectQualificationRequest operation. The <c>RejectQualificationRequest</c>
    /// operation rejects a user's request for a Qualification. <para> You can provide a text
    /// message explaining why the request was rejected. The Worker who made the request can
    /// see this message. </para>
    /// </summary>
    public partial class RejectQualificationRequestRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property QualificationRequestId. 
        /// <para>
        ///  The ID of the Qualification request, as returned by the <c>ListQualificationRequests</c>
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QualificationRequestId { get; set; }

        /// <summary>
        /// Checks to see if the QualificationRequestId property is set.
        /// </summary>
        internal bool IsSetQualificationRequestId() => this.QualificationRequestId != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A text message explaining why the request was rejected, to be shown to the Worker
        /// who made the request.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
