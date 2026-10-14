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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains configurations for the tested state.
    /// </summary>
    public partial class TestStateConfiguration
    {
        /// <summary>
        /// Gets and sets the property ErrorCausedByState. 
        /// <para>
        /// The name of the state from which an error originates when an error is mocked for a
        /// Map or Parallel state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 80)]
        public string ErrorCausedByState { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCausedByState property is set.
        /// </summary>
        internal bool IsSetErrorCausedByState() => this.ErrorCausedByState != null;

        /// <summary>
        /// Gets and sets the property MapItemReaderData. 
        /// <para>
        /// The data read by ItemReader in Distributed Map states as found in its original source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string MapItemReaderData { get; set; }

        /// <summary>
        /// Checks to see if the MapItemReaderData property is set.
        /// </summary>
        internal bool IsSetMapItemReaderData() => this.MapItemReaderData != null;

        /// <summary>
        /// Gets and sets the property MapIterationFailureCount. 
        /// <para>
        /// The number of Map state iterations that failed during the Map state invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MapIterationFailureCount { get; set; }

        /// <summary>
        /// Checks to see if the MapIterationFailureCount property is set.
        /// </summary>
        internal bool IsSetMapIterationFailureCount() => this.MapIterationFailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property RetrierRetryCount. 
        /// <para>
        /// The number of retry attempts that have occurred for the state's Retry that applies
        /// to the mocked error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RetrierRetryCount { get; set; }

        /// <summary>
        /// Checks to see if the RetrierRetryCount property is set.
        /// </summary>
        internal bool IsSetRetrierRetryCount() => this.RetrierRetryCount.HasValue;
    }
}
