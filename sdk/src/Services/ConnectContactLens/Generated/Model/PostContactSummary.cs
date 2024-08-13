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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
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
namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// Information about the post-contact summary.
    /// </summary>
    public partial class PostContactSummary
    {
        private string _content;
        private PostContactSummaryFailureCode _failureCode;
        private PostContactSummaryStatus _status;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1762)]
        public string Content
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// If the summary failed to be generated, one of the following failure codes occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUOTA_EXCEEDED</c>: The number of concurrent analytics jobs reached your service
        /// quota.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_CONVERSATION_CONTENT</c>: The conversation needs to have at least
        /// one turn from both the participants in order to generate the summary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_SAFETY_GUIDELINES</c>: The generated summary cannot be provided because
        /// it failed to meet system safety guidelines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_ANALYSIS_CONFIGURATION</c>: This code occurs when, for example, you're
        /// using a <a href="https://docs.aws.amazon.com/connect/latest/adminguide/supported-languages.html#supported-languages-contact-lens">language</a>
        /// that isn't supported by generative AI-powered post-contact summaries. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c>: Internal system error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PostContactSummaryFailureCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the summary was successfully COMPLETED or FAILED to be generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PostContactSummaryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}