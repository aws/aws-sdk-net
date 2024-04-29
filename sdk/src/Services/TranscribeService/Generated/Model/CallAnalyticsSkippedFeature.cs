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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Represents a skipped analytics feature during the analysis of a call analytics job.
    /// 
    ///  
    /// <para>
    /// The <c>Feature</c> field indicates the type of analytics feature that was skipped.
    /// </para>
    ///  
    /// <para>
    /// The <c>Message</c> field contains additional information or a message explaining why
    /// the analytics feature was skipped.
    /// </para>
    ///  
    /// <para>
    /// The <c>ReasonCode</c> field provides a code indicating the reason why the analytics
    /// feature was skipped.
    /// </para>
    /// </summary>
    public partial class CallAnalyticsSkippedFeature
    {
        private CallAnalyticsFeature _feature;
        private string _message;
        private CallAnalyticsSkippedReasonCode _reasonCode;

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// Indicates the type of analytics feature that was skipped during the analysis of a
        /// call analytics job.
        /// </para>
        /// </summary>
        public CallAnalyticsFeature Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Contains additional information or a message explaining why a specific analytics feature
        /// was skipped during the analysis of a call analytics job.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// Provides a code indicating the reason why a specific analytics feature was skipped
        /// during the analysis of a call analytics job.
        /// </para>
        /// </summary>
        public CallAnalyticsSkippedReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

    }
}