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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings on protection groups with arbitrary pattern type.
    /// </summary>
    public partial class ProtectionGroupArbitraryPatternLimits
    {
        /// <summary>
        /// Gets and sets the property MaxMembers. 
        /// <para>
        /// The maximum number of resources you can specify for a single arbitrary pattern in
        /// a protection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaxMembers { get; set; }

        /// <summary>
        /// Checks to see if the MaxMembers property is set.
        /// </summary>
        internal bool IsSetMaxMembers() => this.MaxMembers.HasValue;
    }
}
