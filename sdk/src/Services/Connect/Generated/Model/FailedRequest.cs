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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private FailureReasonCode _failureReasonCode;
        private string _failureReasonMessage;
        private string _requestIdentifier;

        /// <summary>
        /// Gets and sets the property FailureReasonCode. 
        /// <para>
        /// Reason code for the failure.
        /// </para>
        /// </summary>
        public FailureReasonCode FailureReasonCode
        {
            get { return this._failureReasonCode; }
            set { this._failureReasonCode = value; }
        }

        // Check to see if FailureReasonCode property is set
        internal bool IsSetFailureReasonCode()
        {
            return this._failureReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasonMessage. 
        /// <para>
        /// Why the request to create a contact failed.
        /// </para>
        /// </summary>
        public string FailureReasonMessage
        {
            get { return this._failureReasonMessage; }
            set { this._failureReasonMessage = value; }
        }

        // Check to see if FailureReasonMessage property is set
        internal bool IsSetFailureReasonMessage()
        {
            return this._failureReasonMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// Request identifier provided in the API call in the ContactDataRequest to create a
        /// contact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=80)]
        public string RequestIdentifier
        {
            get { return this._requestIdentifier; }
            set { this._requestIdentifier = value; }
        }

        // Check to see if RequestIdentifier property is set
        internal bool IsSetRequestIdentifier()
        {
            return this._requestIdentifier != null;
        }

    }
}