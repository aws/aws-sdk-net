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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Source server CPU information.
    /// </summary>
    public partial class CPU
    {
        /// <summary>
        /// Gets and sets the property Cores. 
        /// <para>
        /// The number of CPU cores on the source server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Cores { get; set; }

        /// <summary>
        /// Checks to see if the Cores property is set.
        /// </summary>
        internal bool IsSetCores() => this.Cores.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The source server's CPU model name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;
    }
}
