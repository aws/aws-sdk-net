/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates a new case in the AWS Support Center. This action is modeled on the behavior of the AWS Support Center <a
    /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page. Its parameters require you to specify the following information:
    /// </para> <ol> <li> <b>ServiceCode.</b> Represents a code for an AWS service. You obtain the <i>ServiceCode</i> by calling <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> . </li>
    /// <li> <b>CategoryCode</b> . Represents a category for the service defined for the ServiceCode value. You also obtain the cateogory code for
    /// a service by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> .
    /// Each AWS service defines its own set of category codes. </li>
    /// <li> <b>SeverityCode</b> . Represents a value that specifies the urgency of the case, and the time interval in which your service level
    /// agreement specifies a response from AWS Support. You obtain the SeverityCode by calling <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html" >DescribeSeverityLevels</a> .</li>
    /// <li> <b>Subject</b> . Represents the <b>Subject</b> field on the AWS Support Center <a href="https://aws.amazon.com/support/createCase"
    /// >Open a new case</a> page.</li>
    /// <li> <b>CommunicationBody</b> . Represents the <b>Description</b> field on the AWS Support Center <a
    /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page.</li>
    /// <li> <b>Language</b> . Specifies the human language in which AWS Support handles the case. The API currently supports English and
    /// Japanese.</li>
    /// <li> <b>CcEmailAddresses</b> . Represents the AWS Support Center <b>CC</b> field on the <a
    /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page. You can list email addresses to be copied on any correspondence
    /// about the case. The account that opens the case is already identified by passing the AWS Credentials in the HTTP POST method or in a method
    /// or function call from one of the programming languages supported by an <a href="http://aws.amazon.com/tools/" >AWS SDK</a> . </li>
    /// <li> <b>IssueType</b> . Indicates the type of issue for the case. You can specify either "customer-service" or "technical." If you do not
    /// indicate a value, this parameter defaults to "technical." </li>
    /// </ol> <para><b>NOTE:</b>The AWS Support API does not currently support the ability to add attachments to cases. You can, however, call
    /// AddCommunicationToCase to add information to an open case. </para> <para>A successful <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> request returns an AWS Support case
    /// number. Case numbers are used by <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCases.html"
    /// >DescribeCases</a> request to retrieve existing AWS Support support cases. </para>
    /// </summary>
    public partial class CreateCaseRequest : AmazonWebServiceRequest
    {
        private string subject;
        private string serviceCode;
        private string severityCode;
        private string categoryCode;
        private string communicationBody;
        private List<string> ccEmailAddresses = new List<string>();
        private string language;
        private string issueType;

        /// <summary>
        /// Title of the AWS Support case.
        ///  
        /// </summary>
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this.subject != null;
        }

        /// <summary>
        /// Code for the AWS service returned by the call to <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" title="DescribeServices">DescribeServices</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[0-9a-z\-_]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this.serviceCode; }
            set { this.serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this.serviceCode != null;
        }

        /// <summary>
        /// Code for the severity level returned by the call to <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html"
        /// title="DescribeSeverityLevels">DescribeSeverityLevels</a>. <note>The availability of severity levels depends on each customer's support
        /// subscription. In other words, your subscription may not necessarily require the urgent level of response time.</note>
        ///  
        /// </summary>
        public string SeverityCode
        {
            get { return this.severityCode; }
            set { this.severityCode = value; }
        }

        // Check to see if SeverityCode property is set
        internal bool IsSetSeverityCode()
        {
            return this.severityCode != null;
        }

        /// <summary>
        /// Specifies the category of problem for the AWS Support case.
        ///  
        /// </summary>
        public string CategoryCode
        {
            get { return this.categoryCode; }
            set { this.categoryCode = value; }
        }

        // Check to see if CategoryCode property is set
        internal bool IsSetCategoryCode()
        {
            return this.categoryCode != null;
        }

        /// <summary>
        /// Parameter that represents the communication body text when you create an AWS Support case by calling <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" title="CreateCase">CreateCase</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 8000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CommunicationBody
        {
            get { return this.communicationBody; }
            set { this.communicationBody = value; }
        }

        // Check to see if CommunicationBody property is set
        internal bool IsSetCommunicationBody()
        {
            return this.communicationBody != null;
        }

        /// <summary>
        /// List of email addresses that AWS Support copies on case correspondence.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> CcEmailAddresses
        {
            get { return this.ccEmailAddresses; }
            set { this.ccEmailAddresses = value; }
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this.ccEmailAddresses.Count > 0;
        }

        /// <summary>
        /// Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English and Japanese, for which
        /// the codes are <i>en</i> and <i>ja</i>, respectively. Language parameters must be passed explicitly for operations that take them.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }

        /// <summary>
        /// Field passed as a parameter in a <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html"
        /// title="CreateCase">CreateCase</a> call.
        ///  
        /// </summary>
        public string IssueType
        {
            get { return this.issueType; }
            set { this.issueType = value; }
        }

        // Check to see if IssueType property is set
        internal bool IsSetIssueType()
        {
            return this.issueType != null;
        }

    }
}
    
