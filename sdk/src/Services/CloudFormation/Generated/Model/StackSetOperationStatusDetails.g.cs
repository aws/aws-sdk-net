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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Detailed information about the StackSet operation.
    /// </summary>
    public partial class StackSetOperationStatusDetails
    {
        /// <summary>
        /// Gets and sets the property FailedStackInstancesCount. 
        /// <para>
        /// The number of stack instances for which the StackSet operation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailedStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetFailedStackInstancesCount() => this.FailedStackInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// The detailed progress information for the individual stages of the StackSet operation:
        /// the role provisioning stage and the stack instances deployment stage.
        /// </para>
        /// </summary>
        public Stages Stages { get; set; }

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null;

        /// <summary>
        /// Gets and sets the property TotalAccountsCount. 
        /// <para>
        /// The total number of accounts targeted by this StackSet operation. Self-managed operations
        /// and service-managed operations that do not provision roles also report this value
        /// when it is known. CloudFormation populates this value after it resolves the target
        /// accounts. Until then, this field is not present.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAccountsCount property is set.
        /// </summary>
        internal bool IsSetTotalAccountsCount() => this.TotalAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStackInstancesCount. 
        /// <para>
        /// The total number of stack instances targeted by this StackSet operation. CloudFormation
        /// populates this value after it resolves the target stack instances. Until then, this
        /// field is not present.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalStackInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalStackInstancesCount property is set.
        /// </summary>
        internal bool IsSetTotalStackInstancesCount() => this.TotalStackInstancesCount.HasValue;
    }
}
