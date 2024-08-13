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
    /// Specifies the maximum number of jobs that can run in parallel and the maximum number
    /// of jobs that can run.
    /// </summary>
    public partial class RecommendationJobResourceLimit
    {
        private int? _maxNumberOfTests;
        private int? _maxParallelOfTests;

        /// <summary>
        /// Gets and sets the property MaxNumberOfTests. 
        /// <para>
        /// Defines the maximum number of load tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxNumberOfTests
        {
            get { return this._maxNumberOfTests; }
            set { this._maxNumberOfTests = value; }
        }

        // Check to see if MaxNumberOfTests property is set
        internal bool IsSetMaxNumberOfTests()
        {
            return this._maxNumberOfTests.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxParallelOfTests. 
        /// <para>
        /// Defines the maximum number of parallel load tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxParallelOfTests
        {
            get { return this._maxParallelOfTests; }
            set { this._maxParallelOfTests = value; }
        }

        // Check to see if MaxParallelOfTests property is set
        internal bool IsSetMaxParallelOfTests()
        {
            return this._maxParallelOfTests.HasValue; 
        }

    }
}