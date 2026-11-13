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
    /// The runtime lifecycle for the runtime or alias. Optional. Used to schedule runtime
    /// deprecation. Omitting or providing an empty object removes the existing lifecycle.
    /// </summary>
    public partial class RuntimeReleaseLifecycle
    {
        /// <summary>
        /// Gets and sets the property DeprecationDate. The date (UTC) on which the runtime or
        /// alias becomes deprecated.
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate != null;

        /// <summary>
        /// Gets and sets the property FunctionCreateBlockDate. The date (UTC) on which creating
        /// new functions that use this runtime or alias is blocked.
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string FunctionCreateBlockDate { get; set; }

        /// <summary>
        /// Checks to see if the FunctionCreateBlockDate property is set.
        /// </summary>
        internal bool IsSetFunctionCreateBlockDate() => this.FunctionCreateBlockDate != null;

        /// <summary>
        /// Gets and sets the property FunctionUpdateBlockDate. The date (UTC) on which updating
        /// existing functions that use this runtime or alias is blocked.
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string FunctionUpdateBlockDate { get; set; }

        /// <summary>
        /// Checks to see if the FunctionUpdateBlockDate property is set.
        /// </summary>
        internal bool IsSetFunctionUpdateBlockDate() => this.FunctionUpdateBlockDate != null;

        /// <summary>
        /// Gets and sets the property ReleaseState. Optional, with no default applied. DEPRECATED
        /// requires a DeprecationDate on or before today (UTC); PREVIEW and GA require a later
        /// one, or none. Reads report DEPRECATED once DeprecationDate is reached.
        /// </summary>
        public RuntimeReleaseState ReleaseState { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseState property is set.
        /// </summary>
        internal bool IsSetReleaseState() => this.ReleaseState != null;
    }
}
