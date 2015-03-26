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
    /// A JSON-formatted object that contains the metadata for a support case. It is contained
    /// the response from a <a>DescribeCases</a> request. <b>CaseDetails</b> contains the
    /// following fields:
    /// 
    ///  <ol> <li> <b>CaseID.</b> The AWS Support case ID requested or returned in the call.
    /// The case ID is an alphanumeric string formatted as shown in this example: case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>.</li>
    /// <li> <b>CategoryCode.</b> The category of problem for the AWS Support case. Corresponds
    /// to the CategoryCode values returned by a call to <a>DescribeServices</a>.</li> <li>
    /// <b>DisplayId.</b> The identifier for the case on pages in the AWS Support Center.</li>
    /// <li> <b>Language.</b> The ISO 639-1 code for the language in which AWS provides support.
    /// AWS Support currently supports English ("en") and Japanese ("ja"). Language parameters
    /// must be passed explicitly for operations that take them.</li> <li> <b>RecentCommunications.</b>
    /// One or more <a>Communication</a> objects. Fields of these objects are <code>Attachments</code>,
    /// <code>Body</code>, <code>CaseId</code>, <code>SubmittedBy</code>, and <code>TimeCreated</code>.</li>
    /// <li> <b>NextToken.</b> A resumption point for pagination.</li> <li> <b>ServiceCode.</b>
    /// The identifier for the AWS service that corresponds to the service code defined in
    /// the call to <a>DescribeServices</a>.</li> <li> <b>SeverityCode. </b>The severity code
    /// assigned to the case. Contains one of the values returned by the call to <a>DescribeSeverityLevels</a>.</li>
    /// <li> <b>Status.</b> The status of the case in the AWS Support Center.</li> <li> <b>Subject.</b>
    /// The subject line of the case.</li> <li> <b>SubmittedBy.</b> The email address of the
    /// account that submitted the case.</li> <li> <b>TimeCreated.</b> The time the case was
    /// created, in ISO-8601 format.</li> </ol>
    /// </summary>
    public partial class CaseDetails
    {
        private string _caseId;
        private string _categoryCode;
        private List<string> _ccEmailAddresses = new List<string>();
        private string _displayId;
        private string _language;
        private RecentCaseCommunications _recentCommunications;
        private string _serviceCode;
        private string _severityCode;
        private string _status;
        private string _subject;
        private string _submittedBy;
        private string _timeCreated;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The AWS Support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>
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
        /// The email addresses that receive copies of communication about the case.
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
        /// Gets and sets the property DisplayId. 
        /// <para>
        /// The ID displayed for the case in the AWS Support Center. This is a numeric string.
        /// 
        /// </para>
        /// </summary>
        public string DisplayId
        {
            get { return this._displayId; }
            set { this._displayId = value; }
        }

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this._displayId != null;
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
        /// Gets and sets the property RecentCommunications. 
        /// <para>
        /// The five most recent communications between you and AWS Support Center, including
        /// the IDs of any attachments to the communications. Also includes a <code>nextToken</code>
        /// that you can use to retrieve earlier communications.
        /// </para>
        /// </summary>
        public RecentCaseCommunications RecentCommunications
        {
            get { return this._recentCommunications; }
            set { this._recentCommunications = value; }
        }

        // Check to see if RecentCommunications property is set
        internal bool IsSetRecentCommunications()
        {
            return this._recentCommunications != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the case. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line for the case in the AWS Support Center.
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

        /// <summary>
        /// Gets and sets the property SubmittedBy. 
        /// <para>
        /// The email address of the account that submitted the case.
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
        /// The time that the case was case created in the AWS Support Center. 
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