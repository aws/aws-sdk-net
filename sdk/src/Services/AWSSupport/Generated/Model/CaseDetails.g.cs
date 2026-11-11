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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A JSON-formatted object that contains the metadata for a support case. It is contained
    /// in the response from a <a>DescribeCases</a> request. <b>CaseDetails</b> contains the
    /// following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>caseId</b> - The support case ID requested or returned in the call. The case ID
    /// is an alphanumeric string formatted as shown in this example: case-<i>12345678910-exen-2025-c4c1d2bf33c5cf47</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>categoryCode</b> - The category of problem for the support case. Corresponds to
    /// the <c>CategoryCode</c> values returned by a call to <a>DescribeServices</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>displayId</b> - The identifier for the case on pages in the Amazon Web Services
    /// Support Center.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>language</b> - The language in which Amazon Web Services Support handles the case.
    /// Amazon Web Services Support currently supports Chinese (“zh”), English ("en"), Japanese
    /// ("ja") , Chinese ("zh"), Spanish ("es"), Portuguese ("pt"), French ("fr"), Korean
    /// (“ko”), and Turkish ("tr"). You must specify the ISO 639-1 code for the <c>language</c>
    /// parameter if you want support in that language.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>nextToken</b> - A resumption point for pagination.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>recentCommunications</b> - One or more <a>Communication</a> objects. Fields of
    /// these objects are <c>attachments</c>, <c>body</c>, <c>caseId</c>, <c>submittedBy</c>,
    /// and <c>timeCreated</c>.
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
    /// are: <c>low</c>, <c>normal</c>, <c>high</c>, <c>urgent</c>, and <c>critical</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>status</b> - The status of the case in the Amazon Web Services Support Center.
    /// Valid values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>all-open</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>customer-action-completed</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>opened</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>pending-customer-action</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>reopened</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>resolved</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>unassigned</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>work-in-progress</c> 
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
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-exen-2025-c4c1d2bf33c5cf47</i>
        /// 
        /// </para>
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property CategoryCode. 
        /// <para>
        /// The category of problem for the support case.
        /// </para>
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Checks to see if the CategoryCode property is set.
        /// </summary>
        internal bool IsSetCategoryCode() => this.CategoryCode != null;

        /// <summary>
        /// Gets and sets the property CcEmailAddresses. 
        /// <para>
        /// The email addresses that receive copies of communication about the case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> CcEmailAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CcEmailAddresses property is set.
        /// </summary>
        internal bool IsSetCcEmailAddresses() => this.CcEmailAddresses != null && (this.CcEmailAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayId. 
        /// <para>
        /// The ID displayed for the case in the Amazon Web Services Support Center. This is a
        /// numeric string.
        /// </para>
        /// </summary>
        public string DisplayId { get; set; }

        /// <summary>
        /// Checks to see if the DisplayId property is set.
        /// </summary>
        internal bool IsSetDisplayId() => this.DisplayId != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports Chinese (“zh”), English ("en"), Japanese ("ja") , Chinese
        /// ("zh"), Spanish ("es"), Portuguese ("pt"), French ("fr"), Korean (“ko”), and Turkish
        /// ("tr"). You must specify the ISO 639-1 code for the <c>language</c> parameter if you
        /// want support in that language.
        /// </para>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property RecentCommunications. 
        /// <para>
        /// The five most recent communications between you and Amazon Web Services Support Center,
        /// including the IDs of any attachments to the communications. Also includes a <c>nextToken</c>
        /// that you can use to retrieve earlier communications.
        /// </para>
        /// </summary>
        public RecentCaseCommunications RecentCommunications { get; set; }

        /// <summary>
        /// Checks to see if the RecentCommunications property is set.
        /// </summary>
        internal bool IsSetRecentCommunications() => this.RecentCommunications != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The code for the Amazon Web Services service. You can get a list of codes and the
        /// corresponding service names by calling <a>DescribeServices</a>.
        /// </para>
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property SeverityCode. 
        /// <para>
        /// The code for the severity level returned by the call to <a>DescribeSeverityLevels</a>.
        /// </para>
        /// </summary>
        public string SeverityCode { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCode property is set.
        /// </summary>
        internal bool IsSetSeverityCode() => this.SeverityCode != null;

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
        ///  <c>all-open</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>customer-action-completed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>opened</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-customer-action</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reopened</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolved</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unassigned</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>work-in-progress</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line for the case in the Amazon Web Services Support Center.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubmittedBy. 
        /// <para>
        /// The email address of the account that submitted the case.
        /// </para>
        /// </summary>
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBy property is set.
        /// </summary>
        internal bool IsSetSubmittedBy() => this.SubmittedBy != null;

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// The time that the case was created in the Amazon Web Services Support Center.
        /// </para>
        /// </summary>
        public string TimeCreated { get; set; }

        /// <summary>
        /// Checks to see if the TimeCreated property is set.
        /// </summary>
        internal bool IsSetTimeCreated() => this.TimeCreated != null;
    }
}
