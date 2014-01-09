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
    /// <para>A JSON-formatted object that contains the metadata for a support case. It is contained the response from a DescribeCases request.
    /// <b>CaseDetails</b> contains the following fields:</para> <ol> <li> <b>CaseID.</b> The AWS Support case ID requested or returned in the call.
    /// The case ID is an alphanumeric string formatted as shown in this example: case- <i>12345678910-2013-c4c1d2bf33c5cf47</i> .</li>
    /// <li> <b>CategoryCode.</b> The category of problem for the AWS Support case. Corresponds to the CategoryCode values returned by a call to
    /// DescribeServices.</li>
    /// <li> <b>DisplayId.</b> The identifier for the case on pages in the AWS Support Center.</li>
    /// <li> <b>Language.</b> The ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English ("en") and
    /// Japanese ("ja"). Language parameters must be passed explicitly for operations that take them.</li>
    /// <li> <b>RecentCommunications.</b> One or more Communication objects. Fields of these objects are <c>Body</c> ,
    /// <c>CaseId</c> ,
    /// <c>SubmittedBy</c> , and <c>TimeCreated</c> .</li>
    /// <li> <b>NextToken.</b> A resumption point for pagination.</li>
    /// <li> <b>ServiceCode.</b> The identifier for the AWS service that corresponds to the service code defined in the call to
    /// DescribeServices.</li>
    /// <li> <b>SeverityCode. </b> The severity code assigned to the case. Contains one of the values returned by the call to
    /// DescribeSeverityLevels.</li>
    /// <li> <b>Status.</b> The status of the case in the AWS Support Center.</li>
    /// <li> <b>Subject.</b> The subject line of the case.</li>
    /// <li> <b>SubmittedBy.</b> The email address of the account that submitted the case.</li>
    /// <li> <b>TimeCreated.</b> The time the case was created, in ISO-8601 format.</li>
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
        /// The AWS Support case ID requested or returned in the call. The case ID is an alphanumeric string formatted as shown in this example:
        /// case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>
        ///  
        /// </summary>
        public string CaseId
        {
            get { return this.caseId; }
            set { this.caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this.caseId != null;
        }

        /// <summary>
        /// The ID displayed for the case in the AWS Support Center. This is a numeric string.
        ///  
        /// </summary>
        public string DisplayId
        {
            get { return this.displayId; }
            set { this.displayId = value; }
        }

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this.displayId != null;
        }

        /// <summary>
        /// The subject line for the case in the AWS Support Center.
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
        /// The status of the case.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The code for the AWS service returned by the call to <a>DescribeServices</a>.
        ///  
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
        /// The category of problem for the AWS Support case.
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
        /// The code for the severity level returned by the call to <a>DescribeSeverityLevels</a>.
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
        /// The email address of the account that submitted the case.
        ///  
        /// </summary>
        public string SubmittedBy
        {
            get { return this.submittedBy; }
            set { this.submittedBy = value; }
        }

        // Check to see if SubmittedBy property is set
        internal bool IsSetSubmittedBy()
        {
            return this.submittedBy != null;
        }

        /// <summary>
        /// The time that the case was case created in the AWS Support Center.
        ///  
        /// </summary>
        public string TimeCreated
        {
            get { return this.timeCreated; }
            set { this.timeCreated = value; }
        }

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this.timeCreated != null;
        }

        /// <summary>
        /// The five most recent communications between you and AWS Support Center. Includes a <c>nextToken</c> to retrieve the next set of
        /// communications.
        ///  
        /// </summary>
        public RecentCaseCommunications RecentCommunications
        {
            get { return this.recentCommunications; }
            set { this.recentCommunications = value; }
        }

        // Check to see if RecentCommunications property is set
        internal bool IsSetRecentCommunications()
        {
            return this.recentCommunications != null;
        }

        /// <summary>
        /// The email addresses that receive copies of communication about the case.
        ///  
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
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English ("en") and Japanese ("ja").
        /// Language parameters must be passed explicitly for operations that take them.
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
    }
}
