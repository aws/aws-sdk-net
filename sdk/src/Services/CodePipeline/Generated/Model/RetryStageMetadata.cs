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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
        private int? _autoStageRetryAttempt;
        private RetryTrigger _latestRetryTrigger;
        private int? _manualStageRetryAttempt;

        /// <summary>
        /// Gets and sets the property AutoStageRetryAttempt. 
        /// <para>
        /// The number of attempts for a specific stage with automatic retry on stage failure.
        /// One attempt is allowed for automatic stage retry on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? AutoStageRetryAttempt
        {
            get { return this._autoStageRetryAttempt; }
            set { this._autoStageRetryAttempt = value; }
        }

        // Check to see if AutoStageRetryAttempt property is set
        internal bool IsSetAutoStageRetryAttempt()
        {
            return this._autoStageRetryAttempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRetryTrigger. 
        /// <para>
        /// The latest trigger for a specific stage where manual or automatic retries have been
        /// made upon stage failure.
        /// </para>
        /// </summary>
        public RetryTrigger LatestRetryTrigger
        {
            get { return this._latestRetryTrigger; }
            set { this._latestRetryTrigger = value; }
        }

        // Check to see if LatestRetryTrigger property is set
        internal bool IsSetLatestRetryTrigger()
        {
            return this._latestRetryTrigger != null;
        }

        /// <summary>
        /// Gets and sets the property ManualStageRetryAttempt. 
        /// <para>
        /// The number of attempts for a specific stage where manual retries have been made upon
        /// stage failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ManualStageRetryAttempt
        {
            get { return this._manualStageRetryAttempt; }
            set { this._manualStageRetryAttempt = value; }
        }

        // Check to see if ManualStageRetryAttempt property is set
        internal bool IsSetManualStageRetryAttempt()
        {
            return this._manualStageRetryAttempt.HasValue; 
        }

    }
}