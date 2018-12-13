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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeliverabilityTestReport operation.
    /// Create a new predictive inbox placement test. Predictive inbox placement tests can
    /// help you predict how your messages will be handled by various email providers around
    /// the world. When you perform a predictive inbox placement test, you provide a sample
    /// message that contains the content that you plan to send to your customers. Amazon
    /// Pinpoint then sends that message to special email addresses spread across several
    /// major email providers. After about 24 hours, the test is complete, and you can use
    /// the <code>GetDeliverabilityTestReport</code> operation to view the results of the
    /// test.
    /// </summary>
    public partial class CreateDeliverabilityTestReportRequest : AmazonPinpointEmailRequest
    {
        private EmailContent _content;
        private string _fromEmailAddress;
        private string _reportName;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The HTML body of the message that you sent when you performed the predictive inbox
        /// placement test.
        /// </para>
        /// </summary>
        public EmailContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address that the predictive inbox placement test email was sent from.
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
        /// Gets and sets the property ReportName. 
        /// <para>
        /// A unique name that helps you to identify the predictive inbox placement test when
        /// you retrieve the results.
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

    }
}