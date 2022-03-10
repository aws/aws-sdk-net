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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the GetCallAnalyticsJob operation.
    /// Retrieves information about a call analytics job.
    /// 
    ///  
    /// <para>
    /// To view the job's status, refer to the <code>CallAnalyticsJobStatus</code> field.
    /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
    /// transcript at the URI specified in the <code>TranscriptFileUri</code> field. If you
    /// enabled personally identifiable information (PII) redaction, the redacted transcript
    /// appears in the <code>RedactedTranscriptFileUri</code> field.
    /// </para>
    /// </summary>
    public partial class GetCallAnalyticsJobRequest : AmazonTranscribeServiceRequest
    {
        private string _callAnalyticsJobName;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobName. 
        /// <para>
        /// The name of the analytics job you want information about. This value is case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string CallAnalyticsJobName
        {
            get { return this._callAnalyticsJobName; }
            set { this._callAnalyticsJobName = value; }
        }

        // Check to see if CallAnalyticsJobName property is set
        internal bool IsSetCallAnalyticsJobName()
        {
            return this._callAnalyticsJobName != null;
        }

    }
}