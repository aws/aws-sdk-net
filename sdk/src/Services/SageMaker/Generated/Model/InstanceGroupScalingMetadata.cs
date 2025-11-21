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
    /// Metadata information about scaling operations for an instance group.
    /// </summary>
    public partial class InstanceGroupScalingMetadata
    {
        private string _failureMessage;
        private int? _instanceCount;
        private int? _targetCount;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message describing why the scaling operation failed, if applicable.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The current number of instances in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The desired number of instances for the group after scaling.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TargetCount
        {
            get { return this._targetCount; }
            set { this._targetCount = value; }
        }

        // Check to see if TargetCount property is set
        internal bool IsSetTargetCount()
        {
            return this._targetCount.HasValue; 
        }

    }
}