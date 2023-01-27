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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// (Amazon SQS only) The scaling configuration for the event source. To remove the configuration,
    /// pass an empty value.
    /// </summary>
    public partial class ScalingConfig
    {
        private int? _maximumConcurrency;

        /// <summary>
        /// Gets and sets the property MaximumConcurrency. 
        /// <para>
        /// Limits the number of concurrent instances that the Amazon SQS event source can invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=1000)]
        public int MaximumConcurrency
        {
            get { return this._maximumConcurrency.GetValueOrDefault(); }
            set { this._maximumConcurrency = value; }
        }

        // Check to see if MaximumConcurrency property is set
        internal bool IsSetMaximumConcurrency()
        {
            return this._maximumConcurrency.HasValue; 
        }

    }
}