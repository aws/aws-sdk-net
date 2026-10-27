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
    /// Details about a durable execution context.
    /// </summary>
    public partial class ContextDetails
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Details about the context failure.
        /// </para>
        /// </summary>
        public ErrorObject Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ReplayChildren. 
        /// <para>
        /// Whether the state data of child operations of this completed context should be included
        /// in the invoke payload and <c>GetDurableExecutionState</c> response.
        /// </para>
        /// </summary>
        public bool? ReplayChildren { get; set; }

        /// <summary>
        /// Checks to see if the ReplayChildren property is set.
        /// </summary>
        internal bool IsSetReplayChildren() => this.ReplayChildren.HasValue;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The response payload from the context.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 6291456)]
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;
    }
}
