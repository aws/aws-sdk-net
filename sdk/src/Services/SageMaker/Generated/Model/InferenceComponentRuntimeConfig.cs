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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Runtime settings for a model that is deployed with an inference component.
    /// </summary>
    public partial class InferenceComponentRuntimeConfig
    {
        private int? _copyCount;

        /// <summary>
        /// Gets and sets the property CopyCount. 
        /// <para>
        /// The number of runtime copies of the model container to deploy with the inference component.
        /// Each copy can serve inference requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? CopyCount
        {
            get { return this._copyCount; }
            set { this._copyCount = value; }
        }

        // Check to see if CopyCount property is set
        internal bool IsSetCopyCount()
        {
            return this._copyCount.HasValue; 
        }

    }
}