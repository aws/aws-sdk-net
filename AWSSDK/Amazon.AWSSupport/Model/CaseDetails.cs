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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>JSON-formatted object that contains the metadata for a support case. It is contained the response from a DescribeCases request. This
    /// structure contains the following fields:</para> <ol> <li> <b>CaseID</b> . String that indicates the AWS Support caseID requested or returned
    /// in the call. The caseID is an alphanumeric string formatted as shown in this example CaseId: <i>case-12345678910-2013-c4c1d2bf33c5cf47</i>
    /// </li>
    /// <li> <b>CategoryCode</b> . Specifies the category of problem for the AWS Support case. Corresponds to the CategoryCode values returned by a
    /// call to DescribeServices </li>
    /// <li> <b>DisplayId</b> . String that identifies the case on pages in the AWS Support Center</li>
    /// <li> <b>Language</b> . Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English
    /// and Japanese, for which the codes are <i>en</i> and <i>ja</i> , respectively.</li>
    /// <li> <b>RecentCommunications</b> . One ore more Communication data types. Subfields of these structures are Body, CaseId, SubmittedBy, and
    /// TimeCreated.</li>
    /// <li> <b>NextToken</b> . Defines a resumption point for pagination.</li>
    /// <li> <b>ServiceCode</b> . Identifier for the AWS service that corresponds to the service code defined in the call to DescribeServices </li>
    /// <li> <b>SeverityCode. </b> Specifies the severity code assigned to the case. Contains one of the values returned by the call to
    /// DescribeSeverityLevels </li>
    /// <li> <b>Status</b> . Represents the status of your case in the AWS Support Center</li>
    /// <li> <b>Subject</b> . Represents the subject line of the case.</li>
    /// <li> <b>SubmittedBy</b> .Email address of the account that submitted the case.</li>
    /// <li> <b>TimeCreated</b> .Time the case was created, using ISO 8601 format. </li>
    /// </ol>
    /// </summary>
    public class CaseDetails
    {
        
        private string caseId;
        private string displayId;
        private string subject;
        private string status;
        private string serviceCode;
        private string categoryCode;
        private string severityCode;
        private string submittedBy;
        private string timeCreated;
        private RecentCaseCommunications recentCommunications;
        private List<string> ccEmailAddresses = new List<string>();
        private string language;

        /// <summary>
        /// String that indicates the AWS Support caseID requested or returned in the call. The caseID is an alphanumeric string formatted as shown in
        /// this example CaseId: <i>case-12345678910-2013-c4c1d2bf33c5cf47</i>
        ///  
        /// </summary>
        public string CaseId
        {
            get { return this.caseId; }
            set { this.caseId = value; }
        }

        /// <summary>
        /// Sets the CaseId property
        /// </summary>
        /// <param name="caseId">The value to set for the CaseId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithCaseId(string caseId)
        {
            this.caseId = caseId;
            return this;
        }
            

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this.caseId != null;
        }

        /// <summary>
        /// Represents the Id value displayed on pages for the case in AWS Support Center. This is a numeric string.
        ///  
        /// </summary>
        public string DisplayId
        {
            get { return this.displayId; }
            set { this.displayId = value; }
        }

        /// <summary>
        /// Sets the DisplayId property
        /// </summary>
        /// <param name="displayId">The value to set for the DisplayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithDisplayId(string displayId)
        {
            this.displayId = displayId;
            return this;
        }
            

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this.displayId != null;
        }

        /// <summary>
        /// Represents the subject line for a support case in the AWS Support Center user interface.
        ///  
        /// </summary>
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /// <summary>
        /// Sets the Subject property
        /// </summary>
        /// <param name="subject">The value to set for the Subject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithSubject(string subject)
        {
            this.subject = subject;
            return this;
        }
            

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this.subject != null;
        }

        /// <summary>
        /// Represents the status of a case submitted to AWS Support.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Code for the AWS service returned by the call to <a href="API_DescribeServices.html" title="DescribeServices">DescribeServices</a>.
        ///  
        /// </summary>
        public string ServiceCode
        {
            get { return this.serviceCode; }
            set { this.serviceCode = value; }
        }

        /// <summary>
        /// Sets the ServiceCode property
        /// </summary>
        /// <param name="serviceCode">The value to set for the ServiceCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithServiceCode(string serviceCode)
        {
            this.serviceCode = serviceCode;
            return this;
        }
            

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this.serviceCode != null;
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

        /// <summary>
        /// Sets the CategoryCode property
        /// </summary>
        /// <param name="categoryCode">The value to set for the CategoryCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithCategoryCode(string categoryCode)
        {
            this.categoryCode = categoryCode;
            return this;
        }
            

        // Check to see if CategoryCode property is set
        internal bool IsSetCategoryCode()
        {
            return this.categoryCode != null;
        }

        /// <summary>
        /// Code for the severity level returned by the call to <a href="API_DescribeSeverityLevels.html"
        /// title="DescribeSeverityLevels">DescribeSeverityLevels</a>.
        ///  
        /// </summary>
        public string SeverityCode
        {
            get { return this.severityCode; }
            set { this.severityCode = value; }
        }

        /// <summary>
        /// Sets the SeverityCode property
        /// </summary>
        /// <param name="severityCode">The value to set for the SeverityCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithSeverityCode(string severityCode)
        {
            this.severityCode = severityCode;
            return this;
        }
            

        // Check to see if SeverityCode property is set
        internal bool IsSetSeverityCode()
        {
            return this.severityCode != null;
        }

        /// <summary>
        /// Represents the email address of the account that submitted the case to support.
        ///  
        /// </summary>
        public string SubmittedBy
        {
            get { return this.submittedBy; }
            set { this.submittedBy = value; }
        }

        /// <summary>
        /// Sets the SubmittedBy property
        /// </summary>
        /// <param name="submittedBy">The value to set for the SubmittedBy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithSubmittedBy(string submittedBy)
        {
            this.submittedBy = submittedBy;
            return this;
        }
            

        // Check to see if SubmittedBy property is set
        internal bool IsSetSubmittedBy()
        {
            return this.submittedBy != null;
        }

        /// <summary>
        /// Time that the case was case created in AWS Support Center.
        ///  
        /// </summary>
        public string TimeCreated
        {
            get { return this.timeCreated; }
            set { this.timeCreated = value; }
        }

        /// <summary>
        /// Sets the TimeCreated property
        /// </summary>
        /// <param name="timeCreated">The value to set for the TimeCreated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithTimeCreated(string timeCreated)
        {
            this.timeCreated = timeCreated;
            return this;
        }
            

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this.timeCreated != null;
        }

        /// <summary>
        /// Returns up to the five most recent communications between you and AWS Support Center. Includes a <i>nextToken</i> to retrieve the next set
        /// of communications.
        ///  
        /// </summary>
        public RecentCaseCommunications RecentCommunications
        {
            get { return this.recentCommunications; }
            set { this.recentCommunications = value; }
        }

        /// <summary>
        /// Sets the RecentCommunications property
        /// </summary>
        /// <param name="recentCommunications">The value to set for the RecentCommunications property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithRecentCommunications(RecentCaseCommunications recentCommunications)
        {
            this.recentCommunications = recentCommunications;
            return this;
        }
            

        // Check to see if RecentCommunications property is set
        internal bool IsSetRecentCommunications()
        {
            return this.recentCommunications != null;
        }

        /// <summary>
        /// List of email addresses that are copied in any communication about the case.
        ///  
        /// </summary>
        public List<string> CcEmailAddresses
        {
            get { return this.ccEmailAddresses; }
            set { this.ccEmailAddresses = value; }
        }
        /// <summary>
        /// Adds elements to the CcEmailAddresses collection
        /// </summary>
        /// <param name="ccEmailAddresses">The values to add to the CcEmailAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithCcEmailAddresses(params string[] ccEmailAddresses)
        {
            foreach (string element in ccEmailAddresses)
            {
                this.ccEmailAddresses.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CcEmailAddresses collection
        /// </summary>
        /// <param name="ccEmailAddresses">The values to add to the CcEmailAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithCcEmailAddresses(IEnumerable<string> ccEmailAddresses)
        {
            foreach (string element in ccEmailAddresses)
            {
                this.ccEmailAddresses.Add(element);
            }

            return this;
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this.ccEmailAddresses.Count > 0;
        }

        /// <summary>
        /// Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English and Japanese, for which
        /// the codes are <i>en</i> and <i>ja</i>, respectively.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        /// <summary>
        /// Sets the Language property
        /// </summary>
        /// <param name="language">The value to set for the Language property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaseDetails WithLanguage(string language)
        {
            this.language = language;
            return this;
        }
            

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }
    }
}
