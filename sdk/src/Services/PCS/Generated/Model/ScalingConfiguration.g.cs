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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// Specifies the boundaries of the compute node group auto scaling.
    /// </summary>
    public partial class ScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The upper bound of the number of instances allowed in the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceCount property is set.
        /// </summary>
        internal bool IsSetMaxInstanceCount() => this.MaxInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinInstanceCount. 
        /// <para>
        /// The lower bound of the number of instances allowed in the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MinInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MinInstanceCount property is set.
        /// </summary>
        internal bool IsSetMinInstanceCount() => this.MinInstanceCount.HasValue;
    }
}
