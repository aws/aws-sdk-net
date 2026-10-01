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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The size of the generated audience. Must match one of the sizes in the configured
    /// audience model.
    /// </summary>
    public partial class AudienceSize
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether the audience size is defined in absolute terms or as a percentage. You can
        /// use the <c>ABSOLUTE</c> <a>AudienceSize</a> to configure out audience sizes using
        /// the count of identifiers in the output. You can use the <c>Percentage</c> <a>AudienceSize</a>
        /// to configure sizes in the range 1-100 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AudienceSizeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specify an audience size value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20000000)]
        public int? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
