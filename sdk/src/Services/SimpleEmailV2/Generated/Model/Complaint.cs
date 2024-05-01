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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about a <c>Complaint</c> event.
    /// </summary>
    public partial class Complaint
    {
        private string _complaintFeedbackType;
        private string _complaintSubType;

        /// <summary>
        /// Gets and sets the property ComplaintFeedbackType. 
        /// <para>
        ///  The value of the <c>Feedback-Type</c> field from the feedback report received from
        /// the ISP. 
        /// </para>
        /// </summary>
        public string ComplaintFeedbackType
        {
            get { return this._complaintFeedbackType; }
            set { this._complaintFeedbackType = value; }
        }

        // Check to see if ComplaintFeedbackType property is set
        internal bool IsSetComplaintFeedbackType()
        {
            return this._complaintFeedbackType != null;
        }

        /// <summary>
        /// Gets and sets the property ComplaintSubType. 
        /// <para>
        ///  Can either be <c>null</c> or <c>OnAccountSuppressionList</c>. If the value is <c>OnAccountSuppressionList</c>,
        /// SES accepted the message, but didn't attempt to send it because it was on the account-level
        /// suppression list. 
        /// </para>
        /// </summary>
        public string ComplaintSubType
        {
            get { return this._complaintSubType; }
            set { this._complaintSubType = value; }
        }

        // Check to see if ComplaintSubType property is set
        internal bool IsSetComplaintSubType()
        {
            return this._complaintSubType != null;
        }

    }
}