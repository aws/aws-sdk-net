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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRuntimeAlias operation. Schedules a runtime
    /// alias to be deleted. Runtime aliases scheduled for deletion enter the PENDING_DELETION
    /// state and can be restored during the scheduled deletion window. Function invokes fail
    /// for functions using runtime aliases that are deleted or pending deletion.
    /// </summary>
    public partial class DeleteRuntimeAliasRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Name. The name of the runtime alias to delete.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecoveryWindowInDays. Optional. The waiting period, in
        /// days (7-30), before the runtime alias is permanently deleted.
        /// </summary>
        [AWSProperty(Min = 7, Max = 30)]
        public int? RecoveryWindowInDays { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryWindowInDays property is set.
        /// </summary>
        internal bool IsSetRecoveryWindowInDays() => this.RecoveryWindowInDays.HasValue;

        /// <summary>
        /// Gets and sets the property RuntimeName. The name or ARN of the runtime.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string RuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeName property is set.
        /// </summary>
        internal bool IsSetRuntimeName() => this.RuntimeName != null;
    }
}
