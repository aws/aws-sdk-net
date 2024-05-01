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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that contains metadata related to a predictive inbox placement test.
    /// </summary>
    public partial class DeliverabilityTestReport
    {
        private DateTime? _createDate;
        private DeliverabilityTestStatus _deliverabilityTestStatus;
        private string _fromEmailAddress;
        private string _reportId;
        private string _reportName;
        private string _subject;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the predictive inbox placement test was created, in Unix time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliverabilityTestStatus. 
        /// <para>
        /// The status of the predictive inbox placement test. If the status is <c>IN_PROGRESS</c>,
        /// then the predictive inbox placement test is currently running. Predictive inbox placement
        /// tests are usually complete within 24 hours of creating the test. If the status is
        /// <c>COMPLETE</c>, then the test is finished, and you can use the <c>GetDeliverabilityTestReport</c>
        /// to view the results of the test.
        /// </para>
        /// </summary>
        public DeliverabilityTestStatus DeliverabilityTestStatus
        {
            get { return this._deliverabilityTestStatus; }
            set { this._deliverabilityTestStatus = value; }
        }

        // Check to see if DeliverabilityTestStatus property is set
        internal bool IsSetDeliverabilityTestStatus()
        {
            return this._deliverabilityTestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The sender address that you specified for the predictive inbox placement test.
        /// </para>
        /// </summary>
        public string FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// A unique string that identifies the predictive inbox placement test.
        /// </para>
        /// </summary>
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

        /// <summary>
        /// Gets and sets the property ReportName. 
        /// <para>
        /// A name that helps you identify a predictive inbox placement test report.
        /// </para>
        /// </summary>
        public string ReportName
        {
            get { return this._reportName; }
            set { this._reportName = value; }
        }

        // Check to see if ReportName property is set
        internal bool IsSetReportName()
        {
            return this._reportName != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line for an email that you submitted in a predictive inbox placement test.
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