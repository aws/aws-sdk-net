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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An Amazon SNS data source used for streaming labeling jobs.
    /// </summary>
    public partial class LabelingJobSnsDataSource
    {
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon SNS input topic Amazon Resource Name (ARN). Specify the ARN of the input
        /// topic you will use to send new data objects to a streaming labeling job.
        /// </para>
        ///  
        /// <para>
        /// If you specify an input topic for <code>SnsTopicArn</code> in <code>InputConfig</code>,
        /// you must specify a value for <code>SnsTopicArn</code> in <code>OutputConfig</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}