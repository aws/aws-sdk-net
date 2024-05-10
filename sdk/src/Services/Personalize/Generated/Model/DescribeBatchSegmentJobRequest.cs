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
    /// Container for the parameters to the DescribeBatchSegmentJob operation.
    /// Gets the properties of a batch segment job including name, Amazon Resource Name (ARN),
    /// status, input and output configurations, and the ARN of the solution version used
    /// to generate segments.
    /// </summary>
    public partial class DescribeBatchSegmentJobRequest : AmazonPersonalizeRequest
    {
        private string _batchSegmentJobArn;

        /// <summary>
        /// Gets and sets the property BatchSegmentJobArn. 
        /// <para>
        /// The ARN of the batch segment job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string BatchSegmentJobArn
        {
            get { return this._batchSegmentJobArn; }
            set { this._batchSegmentJobArn = value; }
        }

        // Check to see if BatchSegmentJobArn property is set
        internal bool IsSetBatchSegmentJobArn()
        {
            return this._batchSegmentJobArn != null;
        }

    }
}