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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBatchInferenceJob operation.
    /// Gets the properties of a batch inference job including name, Amazon Resource Name
    /// (ARN), status, input and output configurations, and the ARN of the solution version
    /// used to generate the recommendations.
    /// </summary>
    public partial class DescribeBatchInferenceJobRequest : AmazonPersonalizeRequest
    {
        private string _batchInferenceJobArn;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobArn. 
        /// <para>
        /// The ARN of the batch inference job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string BatchInferenceJobArn
        {
            get { return this._batchInferenceJobArn; }
            set { this._batchInferenceJobArn = value; }
        }

        // Check to see if BatchInferenceJobArn property is set
        internal bool IsSetBatchInferenceJobArn()
        {
            return this._batchInferenceJobArn != null;
        }

    }
}