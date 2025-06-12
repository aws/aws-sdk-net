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
    /// Container for the parameters to the CreateDeliverabilityTestReport operation.
    /// Create a new predictive inbox placement test. Predictive inbox placement tests can
    /// help you predict how your messages will be handled by various email providers around
    /// the world. When you perform a predictive inbox placement test, you provide a sample
    /// message that contains the content that you plan to send to your customers. Amazon
    /// SES then sends that message to special email addresses spread across several major
    /// email providers. After about 24 hours, the test is complete, and you can use the <c>GetDeliverabilityTestReport</c>
    /// operation to view the results of the test.
    /// </summary>
    public partial class CreateDeliverabilityTestReportRequest : AmazonSimpleEmailServiceV2Request
    {
        private EmailContent _content;
        private string _fromEmailAddress;
        private string _reportName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The HTML body of the message that you sent when you performed the predictive inbox
        /// placement test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that you want to associate
        /// with the predictive inbox placement test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}