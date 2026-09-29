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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a range constant.
    /// </summary>
    public partial class RangeConstant
    {
        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum value for a range constant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum != null;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum value for a range constant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum != null;
    }
}
