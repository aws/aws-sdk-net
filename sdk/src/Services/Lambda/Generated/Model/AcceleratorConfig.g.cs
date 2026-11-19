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
    /// The accelerator resource settings for a Lambda execution environment, including the
    /// amount of accelerator memory to allocate.
    /// </summary>
    public partial class AcceleratorConfig
    {
        /// <summary>
        /// Gets and sets the property AcceleratorMemorySize. 
        /// <para>
        /// The minimum amount of memory (in GB) of each accelerator device exposed to the execution
        /// environment. Lambda might allocate more, depending on the accelerator instance types
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AcceleratorMemorySize { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorMemorySize property is set.
        /// </summary>
        internal bool IsSetAcceleratorMemorySize() => this.AcceleratorMemorySize.HasValue;
    }
}
