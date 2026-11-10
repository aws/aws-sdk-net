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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyInstanceCpuOptions operation.
    /// </summary>
    public partial class ModifyInstanceCpuOptionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CoreCount. 
        /// <para>
        /// The number of CPU cores that are running for the specified instance after the update.
        /// </para>
        /// </summary>
        public int? CoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CoreCount property is set.
        /// </summary>
        internal bool IsSetCoreCount() => this.CoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that was updated.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NestedVirtualization. 
        /// <para>
        /// Indicates whether nested virtualization has been enabled or disabled.
        /// </para>
        /// </summary>
        public NestedVirtualizationSpecification NestedVirtualization { get; set; }

        /// <summary>
        /// Checks to see if the NestedVirtualization property is set.
        /// </summary>
        internal bool IsSetNestedVirtualization() => this.NestedVirtualization != null;

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads that are running per CPU core for the specified instance after
        /// the update.
        /// </para>
        /// </summary>
        public int? ThreadsPerCore { get; set; }

        /// <summary>
        /// Checks to see if the ThreadsPerCore property is set.
        /// </summary>
        internal bool IsSetThreadsPerCore() => this.ThreadsPerCore.HasValue;
    }
}
