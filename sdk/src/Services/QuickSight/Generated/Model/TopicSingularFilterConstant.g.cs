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
    /// A structure that represents a singular filter constant, used in filters to specify
    /// a single value to match against.
    /// </summary>
    public partial class TopicSingularFilterConstant
    {
        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The type of the singular filter constant. Valid values for this structure are <c>SINGULAR</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType { get; set; }

        /// <summary>
        /// Checks to see if the ConstantType property is set.
        /// </summary>
        internal bool IsSetConstantType() => this.ConstantType != null;

        /// <summary>
        /// Gets and sets the property SingularConstant. 
        /// <para>
        /// The value of the singular filter constant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string SingularConstant { get; set; }

        /// <summary>
        /// Checks to see if the SingularConstant property is set.
        /// </summary>
        internal bool IsSetSingularConstant() => this.SingularConstant != null;
    }
}
