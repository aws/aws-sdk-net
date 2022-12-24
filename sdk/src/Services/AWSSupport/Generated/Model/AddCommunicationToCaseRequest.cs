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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the AddCommunicationToCase operation.
    /// Adds additional customer communication to an Amazon Web Services Support case. Use
    /// the <code>caseId</code> parameter to identify the case to which to add communication.
    /// You can list a set of email addresses to copy on the communication by using the <code>ccEmailAddresses</code>
    /// parameter. The <code>communicationBody</code> value contains the text of the communication.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AddCommunicationToCaseRequest : AmazonAWSSupportRequest
    {
        private string _attachmentSetId;
        private string _caseId;
        private List<string> _ccEmailAddresses = new List<string>();
        private string _communicationBody;

        /// <summary>
        /// Gets and sets the property AttachmentSetId. 
        /// <para>
        /// The ID of a set of one or more attachments for the communication to add to the case.
        /// Create the set by calling <a>AddAttachmentsToSet</a> 
        /// </para>
        /// </summary>
        public string AttachmentSetId
        {
            get { return this._attachmentSetId; }
            set { this._attachmentSetId = value; }
        }

        // Check to see if AttachmentSetId property is set
        internal bool IsSetAttachmentSetId()
        {
            return this._attachmentSetId != null;
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
        /// Gets and sets the property CcEmailAddresses. 
        /// <para>
        /// The email addresses in the CC line of an email to be added to the support case.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> CcEmailAddresses
        {
            get { return this._ccEmailAddresses; }
            set { this._ccEmailAddresses = value; }
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this._ccEmailAddresses != null && this._ccEmailAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CommunicationBody. 
        /// <para>
        /// The body of an email communication to add to the support case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8000)]
        public string CommunicationBody
        {
            get { return this._communicationBody; }
            set { this._communicationBody = value; }
        }

        // Check to see if CommunicationBody property is set
        internal bool IsSetCommunicationBody()
        {
            return this._communicationBody != null;
        }

    }
}