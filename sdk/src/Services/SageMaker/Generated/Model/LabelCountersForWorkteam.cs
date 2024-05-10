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
    /// Provides counts for human-labeled tasks in the labeling job.
    /// </summary>
    public partial class LabelCountersForWorkteam
    {
        private int? _humanLabeled;
        private int? _pendingHuman;
        private int? _total;

        /// <summary>
        /// Gets and sets the property HumanLabeled. 
        /// <para>
        /// The total number of data objects labeled by a human worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? HumanLabeled
        {
            get { return this._humanLabeled; }
            set { this._humanLabeled = value; }
        }

        // Check to see if HumanLabeled property is set
        internal bool IsSetHumanLabeled()
        {
            return this._humanLabeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingHuman. 
        /// <para>
        /// The total number of data objects that need to be labeled by a human worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PendingHuman
        {
            get { return this._pendingHuman; }
            set { this._pendingHuman = value; }
        }

        // Check to see if PendingHuman property is set
        internal bool IsSetPendingHuman()
        {
            return this._pendingHuman.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of tasks in the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}