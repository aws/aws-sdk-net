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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Maps a CIDR range to a label for cost allocation reporting.
    /// </summary>
    public partial class FlexCostAllocationCidrMapping
    {
        /// <summary>
        /// Gets and sets the property CidrLabel. 
        /// <para>
        /// The label to assign to the CIDR range. The label can be up to 64 characters long.
        /// It can contain letters, numbers, hyphens (<c>-</c>), and underscores (<c>_</c>), and
        /// must start with a letter or a number. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CidrLabel { get; set; }

        /// <summary>
        /// Checks to see if the CidrLabel property is set.
        /// </summary>
        internal bool IsSetCidrLabel() => this.CidrLabel != null;

        /// <summary>
        /// Gets and sets the property CidrRange. 
        /// <para>
        /// The CIDR range. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 43)]
        public string CidrRange { get; set; }

        /// <summary>
        /// Checks to see if the CidrRange property is set.
        /// </summary>
        internal bool IsSetCidrRange() => this.CidrRange != null;
    }
}
