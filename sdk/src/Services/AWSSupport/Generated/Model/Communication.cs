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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// A communication associated with a support case. The communication consists of the
    /// case ID, the message body, attachment information, the submitter of the communication,
    /// and the date and time of the communication.
    /// </summary>
    public partial class Communication
    {
        private List<AttachmentDetails> _attachmentSet = AWSConfigs.InitializeCollections ? new List<AttachmentDetails>() : null;
        private string _body;
        private string _caseId;
        private string _submittedBy;
        private string _timeCreated;

        /// <summary>
        /// Gets and sets the property AttachmentSet. 
        /// <para>
        /// Information about the attachments to the case communication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentDetails> AttachmentSet
        {
            get { return this._attachmentSet; }
            set { this._attachmentSet = value; }
        }

        // Check to see if AttachmentSet property is set
        internal bool IsSetAttachmentSet()
        {
            return this._attachmentSet != null && (this._attachmentSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The text of the communication between the customer and Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8000)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>
        /// 
        /// </para>
        /// </summary>
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedBy. 
        /// <para>
        /// The identity of the account that submitted, or responded to, the support case. Customer
        /// entries include the IAM role as well as the email address (for example, "AdminRole
        /// (Role) &lt;janedoe@example.com&gt;). Entries from the Amazon Web Services Support
        /// team display "Amazon Web Services," and don't show an email address. 
        /// </para>
        /// </summary>
        public string SubmittedBy
        {
            get { return this._submittedBy; }
            set { this._submittedBy = value; }
        }

        // Check to see if SubmittedBy property is set
        internal bool IsSetSubmittedBy()
        {
            return this._submittedBy != null;
        }

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// The time the communication was created.
        /// </para>
        /// </summary>
        public string TimeCreated
        {
            get { return this._timeCreated; }
            set { this._timeCreated = value; }
        }

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this._timeCreated != null;
        }

    }
}