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
    /// Describes the resource configuration for hyperparameter optimization (HPO).
    /// </summary>
    public partial class HPOResourceConfig
    {
        private string _maxNumberOfTrainingJobs;
        private string _maxParallelTrainingJobs;

        /// <summary>
        /// Gets and sets the property MaxNumberOfTrainingJobs. 
        /// <para>
        /// The maximum number of training jobs when you create a solution version. The maximum
        /// value for <c>maxNumberOfTrainingJobs</c> is <c>40</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MaxNumberOfTrainingJobs
        {
            get { return this._maxNumberOfTrainingJobs; }
            set { this._maxNumberOfTrainingJobs = value; }
        }

        // Check to see if MaxNumberOfTrainingJobs property is set
        internal bool IsSetMaxNumberOfTrainingJobs()
        {
            return this._maxNumberOfTrainingJobs != null;
        }

        /// <summary>
        /// Gets and sets the property MaxParallelTrainingJobs. 
        /// <para>
        /// The maximum number of parallel training jobs when you create a solution version. The
        /// maximum value for <c>maxParallelTrainingJobs</c> is <c>10</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MaxParallelTrainingJobs
        {
            get { return this._maxParallelTrainingJobs; }
            set { this._maxParallelTrainingJobs = value; }
        }

        // Check to see if MaxParallelTrainingJobs property is set
        internal bool IsSetMaxParallelTrainingJobs()
        {
            return this._maxParallelTrainingJobs != null;
        }

    }
}