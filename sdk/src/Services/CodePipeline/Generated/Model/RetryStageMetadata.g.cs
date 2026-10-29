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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The details of a specific automatic retry on stage failure, including the attempt
    /// number and trigger.
    /// </summary>
    public partial class RetryStageMetadata
    {
        /// <summary>
        /// Gets and sets the property AutoStageRetryAttempt. 
        /// <para>
        /// The number of attempts for a specific stage with automatic retry on stage failure.
        /// One attempt is allowed for automatic stage retry on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? AutoStageRetryAttempt { get; set; }

        /// <summary>
        /// Checks to see if the AutoStageRetryAttempt property is set.
        /// </summary>
        internal bool IsSetAutoStageRetryAttempt() => this.AutoStageRetryAttempt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRetryTrigger. 
        /// <para>
        /// The latest trigger for a specific stage where manual or automatic retries have been
        /// made upon stage failure.
        /// </para>
        /// </summary>
        public RetryTrigger LatestRetryTrigger { get; set; }

        /// <summary>
        /// Checks to see if the LatestRetryTrigger property is set.
        /// </summary>
        internal bool IsSetLatestRetryTrigger() => this.LatestRetryTrigger != null;

        /// <summary>
        /// Gets and sets the property ManualStageRetryAttempt. 
        /// <para>
        /// The number of attempts for a specific stage where manual retries have been made upon
        /// stage failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ManualStageRetryAttempt { get; set; }

        /// <summary>
        /// Checks to see if the ManualStageRetryAttempt property is set.
        /// </summary>
        internal bool IsSetManualStageRetryAttempt() => this.ManualStageRetryAttempt.HasValue;
    }
}
