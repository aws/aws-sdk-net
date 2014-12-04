/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCase operation.
    /// Creates a new case in the AWS Support Center. This operation is modeled on the behavior
    /// of the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page. Its parameters require you to specify the following information: 
    /// 
    ///  <ol> <li> <b>IssueType.</b> The type of issue for the case. You can specify either
    /// "customer-service" or "technical." If you do not indicate a value, the default is
    /// "technical." </li> <li> <b>ServiceCode.</b> The code for an AWS service. You obtain
    /// the <code>ServiceCode</code> by calling <a>DescribeServices</a>. </li> <li> <b>CategoryCode.</b>
    /// The category for the service defined for the <code>ServiceCode</code> value. You also
    /// obtain the category code for a service by calling <a>DescribeServices</a>. Each AWS
    /// service defines its own set of category codes. </li> <li> <b>SeverityCode.</b> A value
    /// that indicates the urgency of the case, which in turn determines the response time
    /// according to your service level agreement with AWS Support. You obtain the SeverityCode
    /// by calling <a>DescribeSeverityLevels</a>.</li> <li> <b>Subject.</b> The <b>Subject</b>
    /// field on the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page.</li> <li> <b>CommunicationBody.</b> The <b>Description</b> field on
    /// the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page.</li> <li> <b>AttachmentSetId.</b> The ID of a set of attachments that
    /// has been created by using <a>AddAttachmentsToSet</a>.</li> <li> <b>Language.</b> The
    /// human language in which AWS Support handles the case. English and Japanese are currently
    /// supported.</li> <li> <b>CcEmailAddresses.</b> The AWS Support Center <b>CC</b> field
    /// on the <a href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a>
    /// page. You can list email addresses to be copied on any correspondence about the case.
    /// The account that opens the case is already identified by passing the AWS Credentials
    /// in the HTTP POST method or in a method or function call from one of the programming
    /// languages supported by an <a href="http://aws.amazon.com/tools/">AWS SDK</a>. </li>
    /// </ol> <note>
    /// <para>
    /// To add additional communication or attachments to an existing case, use <a>AddCommunicationToCase</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// A successful <a>CreateCase</a> request returns an AWS Support case number. Case numbers
    /// are used by the <a>DescribeCases</a> operation to retrieve existing AWS Support cases.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateCaseRequest : AmazonAWSSupportRequest
    {
        private string _attachmentSetId;
        private string _categoryCode;
        private List<string> _ccEmailAddresses = new List<string>();
        private string _communicationBody;
        private string _issueType;
        private string _language;
        private string _serviceCode;
        private string _severityCode;
        private string _subject;

        /// <summary>
        /// Gets and sets the property AttachmentSetId. 
        /// <para>
        /// The ID of a set of one or more attachments for the case. Create the set by using <a>AddAttachmentsToSet</a>.
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
        /// Gets and sets the property CategoryCode. 
        /// <para>
        /// The category of problem for the AWS Support case. 
        /// </para>
        /// </summary>
        public string CategoryCode
        {
            get { return this._categoryCode; }
            set { this._categoryCode = value; }
        }

        // Check to see if CategoryCode property is set
        internal bool IsSetCategoryCode()
        {
            return this._categoryCode != null;
        }

        /// <summary>
        /// Gets and sets the property CcEmailAddresses. 
        /// <para>
        /// A list of email addresses that AWS Support copies on case correspondence.
        /// </para>
        /// </summary>
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
        /// The communication body text when you create an AWS Support case by calling <a>CreateCase</a>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// The type of issue for the case. You can specify either "customer-service" or "technical."
        /// If you do not indicate a value, the default is "technical." 
        /// </para>
        /// </summary>
        public string IssueType
        {
            get { return this._issueType; }
            set { this._issueType = value; }
        }

        // Check to see if IssueType property is set
        internal bool IsSetIssueType()
        {
            return this._issueType != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently
        /// supports English ("en") and Japanese ("ja"). Language parameters must be passed explicitly
        /// for operations that take them.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The code for the AWS service returned by the call to <a>DescribeServices</a>.
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCode. 
        /// <para>
        /// The code for the severity level returned by the call to <a>DescribeSeverityLevels</a>.
        /// </para>
        ///  <note>
        /// <para>
        /// The availability of severity levels depends on each customer's support subscription.
        /// In other words, your subscription may not necessarily require the urgent level of
        /// response time.
        /// </para>
        /// </note>
        /// </summary>
        public string SeverityCode
        {
            get { return this._severityCode; }
            set { this._severityCode = value; }
        }

        // Check to see if SeverityCode property is set
        internal bool IsSetSeverityCode()
        {
            return this._severityCode != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The title of the AWS Support case.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}