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
    /// A JSON-formatted object that contains the metadata for a support case. It is contained
    /// in the response from a <a>DescribeCases</a> request. <b>CaseDetails</b> contains the
    /// following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>caseId</b> - The support case ID requested or returned in the call. The case ID
    /// is an alphanumeric string formatted as shown in this example: case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>categoryCode</b> - The category of problem for the support case. Corresponds to
    /// the <code>CategoryCode</code> values returned by a call to <a>DescribeServices</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>displayId</b> - The identifier for the case on pages in the Amazon Web Services
    /// Support Center.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>language</b> - The language in which Amazon Web Services Support handles the case.
    /// Amazon Web Services Support currently supports English ("en") and Japanese ("ja").
    /// You must specify the ISO 639-1 code for the <code>language</code> parameter if you
    /// want support in that language.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>nextToken</b> - A resumption point for pagination.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>recentCommunications</b> - One or more <a>Communication</a> objects. Fields of
    /// these objects are <code>attachments</code>, <code>body</code>, <code>caseId</code>,
    /// <code>submittedBy</code>, and <code>timeCreated</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>serviceCode</b> - The identifier for the Amazon Web Services service that corresponds
    /// to the service code defined in the call to <a>DescribeServices</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>severityCode</b> - The severity code assigned to the case. Contains one of the
    /// values returned by the call to <a>DescribeSeverityLevels</a>. The possible values
    /// are: <code>low</code>, <code>normal</code>, <code>high</code>, <code>urgent</code>,
    /// and <code>critical</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>status</b> - The status of the case in the Amazon Web Services Support Center.
    /// Valid values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>opened</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>pending-customer-action</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>reopened</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>resolved</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>unassigned</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>work-in-progress</code> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>subject</b> - The subject line of the case.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>submittedBy</b> - The email address of the account that submitted the case.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>timeCreated</b> - The time the case was created, in ISO-8601 format.
    /// </para>
    ///  </li> </ul>
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
        /// Gets and sets the property CategoryCode. 
        /// <para>
        /// The category of problem for the support case.
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
        /// Gets and sets the property DisplayId. 
        /// <para>
        /// The ID displayed for the case in the Amazon Web Services Support Center. This is a
        /// numeric string.
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
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports English ("en") and Japanese ("ja"). You must specify the
        /// ISO 639-1 code for the <code>language</code> parameter if you want support in that
        /// language.
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
        /// The five most recent communications between you and Amazon Web Services Support Center,
        /// including the IDs of any attachments to the communications. Also includes a <code>nextToken</code>
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
        /// The code for the Amazon Web Services service. You can get a list of codes and the
        /// corresponding service names by calling <a>DescribeServices</a>.
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
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>opened</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending-customer-action</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>reopened</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resolved</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unassigned</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>work-in-progress</code> 
        /// </para>
        ///  </li> </ul>
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
        /// The subject line for the case in the Amazon Web Services Support Center.
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
        /// The time that the case was created in the Amazon Web Services Support Center.
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