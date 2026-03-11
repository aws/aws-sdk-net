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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The retry strategy for service jobs. This defines how many times to retry a failed
    /// service job and under what conditions. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service-job-retries.html">Service
    /// job retry strategies</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class ServiceJobRetryStrategy
    {
        private int? _attempts;
        private List<ServiceJobEvaluateOnExit> _evaluateOnExit = AWSConfigs.InitializeCollections ? new List<ServiceJobEvaluateOnExit>() : null;

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// The number of times to move a service job to <c>RUNNABLE</c> status. You can specify
        /// between 1 and 10 attempts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Attempts
        {
            get { return this._attempts; }
            set { this._attempts = value; }
        }

        // Check to see if Attempts property is set
        internal bool IsSetAttempts()
        {
            return this._attempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluateOnExit. 
        /// <para>
        /// Array of <c>ServiceJobEvaluateOnExit</c> objects that specify conditions under which
        /// the service job should be retried or failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceJobEvaluateOnExit> EvaluateOnExit
        {
            get { return this._evaluateOnExit; }
            set { this._evaluateOnExit = value; }
        }

        // Check to see if EvaluateOnExit property is set
        internal bool IsSetEvaluateOnExit()
        {
            return this._evaluateOnExit != null && (this._evaluateOnExit.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}