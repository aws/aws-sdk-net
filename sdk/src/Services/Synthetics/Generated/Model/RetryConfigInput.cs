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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains information about the canary's retry configuration.
    /// 
    ///  <note> 
    /// <para>
    /// The default account level concurrent execution limit from Lambda is 1000. When you
    /// have more than 1000 canaries, it's possible there are more than 1000 Lambda invocations
    /// due to retries and the console might hang. For more information on the Lambda execution
    /// limit, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-concurrency.html#:~:text=As%20your%20functions%20receive%20more,functions%20in%20an%20AWS%20Region">Understanding
    /// Lambda function scaling</a>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// For canary with <c>MaxRetries = 2</c>, you need to set the <c>CanaryRunConfigInput.TimeoutInSeconds</c>
    /// to less than 600 seconds to avoid validation errors.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RetryConfigInput
    {
        private int? _maxRetries;

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of retries. The value must be less than or equal to 2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public int? MaxRetries
        {
            get { return this._maxRetries; }
            set { this._maxRetries = value; }
        }

        // Check to see if MaxRetries property is set
        internal bool IsSetMaxRetries()
        {
            return this._maxRetries.HasValue; 
        }

    }
}