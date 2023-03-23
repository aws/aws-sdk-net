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
    /// Container for the parameters to the DescribeAutoMLJobV2 operation.
    /// Returns information about an Amazon SageMaker AutoML V2 job.
    /// 
    ///  <note> 
    /// <para>
    /// This API action is callable through SageMaker Canvas only. Calling it directly from
    /// the CLI or an SDK results in an error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeAutoMLJobV2Request : AmazonSageMakerRequest
    {
        private string _autoMLJobName;

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Requests information about an AutoML V2 job using its unique name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

    }
}