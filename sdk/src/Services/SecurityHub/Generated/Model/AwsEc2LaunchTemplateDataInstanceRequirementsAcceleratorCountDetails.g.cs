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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
    /// Inferentia chips) on an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetails
    {
        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        ///  The maximum number of accelerators. If this parameter isn't specified, there's no
        /// maximum limit. To exclude accelerator-enabled instance types, set <c>Max</c> to <c>0</c>.
        /// 
        /// </para>
        /// </summary>
        public int? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        ///  The minimum number of accelerators. If this parameter isn't specified, there's no
        /// minimum limit. 
        /// </para>
        /// </summary>
        public int? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;
    }
}
