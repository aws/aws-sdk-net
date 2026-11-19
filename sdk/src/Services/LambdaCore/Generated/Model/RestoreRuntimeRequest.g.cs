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
    /// Container for the parameters to the RestoreRuntime operation. Cancels a pending scheduled
    /// deletion, returning the resource to the ACTIVE state. Scope is determined by the RuntimeName
    /// path parameter plus an optional, mutually exclusive RuntimeVersion or RuntimeAlias
    /// query parameter: with neither, the runtime itself is restored; with RuntimeVersion,
    /// the named runtime version; with RuntimeAlias, the named runtime alias. Restoring a
    /// resource that is already ACTIVE is a no-op success. Restore only works while the target
    /// is PENDING_DELETION; once the scheduled deletion has begun executing (DELETING) or
    /// has completed, the call fails.
    /// </summary>
    public partial class RestoreRuntimeRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property RuntimeAlias. Optional. Restores the named RuntimeAlias
        /// under RuntimeName. Mutually exclusive with RuntimeVersion; supplying both is rejected
        /// with InvalidParameterValueException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuntimeAlias { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeAlias property is set.
        /// </summary>
        internal bool IsSetRuntimeAlias() => this.RuntimeAlias != null;

        /// <summary>
        /// Gets and sets the property RuntimeName. The name or ARN of the runtime to restore.
        /// When RuntimeVersion or RuntimeAlias is specified, the runtime that owns the runtime
        /// version or runtime alias to restore.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string RuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeName property is set.
        /// </summary>
        internal bool IsSetRuntimeName() => this.RuntimeName != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersion. Optional. Restores the named RuntimeVersion
        /// under RuntimeName. Mutually exclusive with RuntimeAlias; supplying both is rejected
        /// with InvalidParameterValueException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;
    }
}
