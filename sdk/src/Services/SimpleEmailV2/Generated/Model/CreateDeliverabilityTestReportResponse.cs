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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
    /// Information about the predictive inbox placement test that you created.
    /// </summary>
    public partial class CreateDeliverabilityTestReportResponse : AmazonWebServiceResponse
    {
        private DeliverabilityTestStatus _deliverabilityTestStatus;
        private string _reportId;

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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReportId. 
        /// <para>
        /// A unique string that identifies the predictive inbox placement test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}