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
    /// Container for the parameters to the CreateCase operation.
    /// Creates a case in the AWS Support Center. This operation is similar to how you create
    /// a case in the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page.
    /// 
    ///  
    /// <para>
    /// The AWS Support API doesn't support requesting service limit increases. You can submit
    /// a service limit increase in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Submit a request from the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the Service Quotas <a href="https://docs.aws.amazon.com/servicequotas/2019-06-24/apireference/API_RequestServiceQuotaIncrease.html">RequestServiceQuotaIncrease</a>
    /// operation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A successful <code>CreateCase</code> request returns an AWS Support case number. You
    /// can use the <a>DescribeCases</a> operation and specify the case number to get existing
    /// AWS Support cases. After you create a case, use the <a>AddCommunicationToCase</a>
    /// operation to add additional communication or attachments to an existing case.
    /// </para>
    ///  
    /// <para>
    /// The <code>caseId</code> is separate from the <code>displayId</code> that appears in
    /// the <a href="https://console.aws.amazon.com/support">AWS Support Center</a>. Use the
    /// <a>DescribeCases</a> operation to get the <code>displayId</code>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business or Enterprise support plan to use the AWS Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the AWS Support API from an account that does not have a Business or Enterprise
    /// support plan, the <code>SubscriptionRequiredException</code> error message appears.
    /// For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">AWS
    /// Support</a>.
    /// </para>
    ///  </li> </ul> </note>
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
        /// The ID of a set of one or more attachments for the case. Create the set by using the
        /// <a>AddAttachmentsToSet</a> operation.
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
        /// The category of problem for the AWS Support case. You also use the <a>DescribeServices</a>
        /// operation to get the category code for a service. Each AWS service defines its own
        /// set of category codes.
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
        /// A list of email addresses that AWS Support copies on case correspondence. AWS Support
        /// identifies the account that creates the case when you specify your AWS credentials
        /// in an HTTP POST method or use the <a href="http://aws.amazon.com/tools/">AWS SDKs</a>.
        /// 
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
        /// The communication body text that describes the issue. This text appears in the <b>Description</b>
        /// field on the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.
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

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// The type of issue for the case. You can specify <code>customer-service</code> or <code>technical</code>.
        /// If you don't specify a value, the default is <code>technical</code>.
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
        /// The language in which AWS Support handles the case. You must specify the ISO 639-1
        /// code for the <code>language</code> parameter if you want support in that language.
        /// Currently, English ("en") and Japanese ("ja") are supported.
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
        /// The code for the AWS service. You can use the <a>DescribeServices</a> operation to
        /// get the possible <code>serviceCode</code> values.
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
        /// A value that indicates the urgency of the case. This value determines the response
        /// time according to your service level agreement with AWS Support. You can use the <a>DescribeSeverityLevels</a>
        /// operation to get the possible values for <code>severityCode</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>SeverityLevel</a> and <a href="https://docs.aws.amazon.com/awssupport/latest/user/getting-started.html#choosing-severity">Choosing
        /// a Severity</a> in the <i>AWS Support User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The availability of severity levels depends on the support plan for the AWS account.
        /// </para>
        ///  </note>
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
        /// The title of the AWS Support case. The title appears in the <b>Subject</b> field on
        /// the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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