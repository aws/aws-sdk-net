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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMapRun operation.
    /// Updates an in-progress Map Run's configuration to include changes to the settings
    /// that control maximum concurrency and Map Run failure.
    /// </summary>
    public partial class UpdateMapRunRequest : AmazonStepFunctionsRequest
    {
        private string _mapRunArn;
        private int? _maxConcurrency;
        private long? _toleratedFailureCount;
        private float? _toleratedFailurePercentage;

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of child workflow executions that can be specified to run in parallel
        /// for the Map Run at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxConcurrency
        {
            get { return this._maxConcurrency.GetValueOrDefault(); }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The maximum number of failed items before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ToleratedFailureCount
        {
            get { return this._toleratedFailureCount.GetValueOrDefault(); }
            set { this._toleratedFailureCount = value; }
        }

        // Check to see if ToleratedFailureCount property is set
        internal bool IsSetToleratedFailureCount()
        {
            return this._toleratedFailureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The maximum percentage of failed items before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float ToleratedFailurePercentage
        {
            get { return this._toleratedFailurePercentage.GetValueOrDefault(); }
            set { this._toleratedFailurePercentage = value; }
        }

        // Check to see if ToleratedFailurePercentage property is set
        internal bool IsSetToleratedFailurePercentage()
        {
            return this._toleratedFailurePercentage.HasValue; 
        }

    }
}