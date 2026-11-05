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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the process and any required context values for a specific finding.
    /// </summary>
    public partial class RuntimeDetails
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Additional information about the suspicious activity.
        /// </para>
        /// </summary>
        public RuntimeContext Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Information about the observed process.
        /// </para>
        /// </summary>
        public ProcessDetails Process { get; set; }

        /// <summary>
        /// Checks to see if the Process property is set.
        /// </summary>
        internal bool IsSetProcess() => this.Process != null;
    }
}
