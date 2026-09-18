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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains metadata related to a predictive inbox placement test.
    /// </summary>
    public partial class DeliverabilityTestReport
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the predictive inbox placement test was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

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
        public DeliverabilityTestStatus DeliverabilityTestStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliverabilityTestStatus property is set.
        /// </summary>
        internal bool IsSetDeliverabilityTestStatus() => this.DeliverabilityTestStatus != null;

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The sender address that you specified for the predictive inbox placement test.
        /// </para>
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// A unique string that identifies the predictive inbox placement test.
        /// </para>
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property ReportName. 
        /// <para>
        /// A name that helps you identify a predictive inbox placement test report.
        /// </para>
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        /// Checks to see if the ReportName property is set.
        /// </summary>
        internal bool IsSetReportName() => this.ReportName != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line for an email that you submitted in a predictive inbox placement test.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
