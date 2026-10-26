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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about the provisioned concurrency configuration for a function alias or version.
    /// </summary>
    public partial class ProvisionedConcurrencyConfigListItem
    {
        /// <summary>
        /// Gets and sets the property AllocatedProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency allocated. When a weighted alias is used during
        /// linear and canary deployments, this value fluctuates depending on the amount of concurrency
        /// that is provisioned for the function versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AllocatedProvisionedConcurrentExecutions { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedProvisionedConcurrentExecutions property is set.
        /// </summary>
        internal bool IsSetAllocatedProvisionedConcurrentExecutions() => this.AllocatedProvisionedConcurrentExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableProvisionedConcurrentExecutions { get; set; }

        /// <summary>
        /// Checks to see if the AvailableProvisionedConcurrentExecutions property is set.
        /// </summary>
        internal bool IsSetAvailableProvisionedConcurrentExecutions() => this.AvailableProvisionedConcurrentExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alias or version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that a user last updated the configuration, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601 format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property RequestedProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? RequestedProvisionedConcurrentExecutions { get; set; }

        /// <summary>
        /// Checks to see if the RequestedProvisionedConcurrentExecutions property is set.
        /// </summary>
        internal bool IsSetRequestedProvisionedConcurrentExecutions() => this.RequestedProvisionedConcurrentExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the allocation process.
        /// </para>
        /// </summary>
        public ProvisionedConcurrencyStatusEnum Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// For failed allocations, the reason that provisioned concurrency could not be allocated.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
