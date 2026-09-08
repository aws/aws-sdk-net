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
    /// A candidate instance type preference in a processing <c>InstancePreferences</c> list.
    /// </summary>
    public partial class ProcessingInstancePreference
    {
        private int? _instanceCount;
        private ProcessingInstanceType _instanceType;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances to launch if this instance type is selected. Specify the instance
        /// count for the processing job in one of the following two ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <b>Per preference</b> – Set <c>InstanceCount</c> on every preference in the <c>InstancePreferences</c>
        /// list and don't set <c>ProcessingClusterConfig$InstanceCount</c>. Use this when each
        /// instance type needs a different number of instances to deliver equivalent compute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>One count for the job</b> – Set <c>ProcessingClusterConfig$InstanceCount</c> and
        /// omit it from every preference. Amazon SageMaker applies this to all instance types
        /// in the list.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For example, in a list of five preferences, either all five specify <c>InstanceCount</c>
        /// or none of them do. Amazon SageMaker rejects requests that set <c>InstanceCount</c>
        /// on only some preferences, that set it both per preference and in <c>ProcessingClusterConfig</c>,
        /// or that omit it in both places.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type. An instance type can appear only once in an <c>InstancePreferences</c>
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}