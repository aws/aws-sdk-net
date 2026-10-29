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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Request for which contact failed to be generated.
    /// </summary>
    public partial class FailedRequest
    {
        /// <summary>
        /// Gets and sets the property FailureReasonCode. 
        /// <para>
        /// Reason code for the failure.
        /// </para>
        /// </summary>
        public FailureReasonCode FailureReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureReasonCode property is set.
        /// </summary>
        internal bool IsSetFailureReasonCode() => this.FailureReasonCode != null;

        /// <summary>
        /// Gets and sets the property FailureReasonMessage. 
        /// <para>
        /// Why the request to create a contact failed.
        /// </para>
        /// </summary>
        public string FailureReasonMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureReasonMessage property is set.
        /// </summary>
        internal bool IsSetFailureReasonMessage() => this.FailureReasonMessage != null;

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// Request identifier provided in the API call in the ContactDataRequest to create a
        /// contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 80)]
        public string RequestIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RequestIdentifier property is set.
        /// </summary>
        internal bool IsSetRequestIdentifier() => this.RequestIdentifier != null;
    }
}
