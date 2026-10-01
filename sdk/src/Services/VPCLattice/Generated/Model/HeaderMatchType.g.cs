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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes a header match type.
    /// </summary>
    public partial class HeaderMatchType
    {
        /// <summary>
        /// Gets and sets the property Contains. 
        /// <para>
        /// A contains type match.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Contains { get; set; }

        /// <summary>
        /// Checks to see if the Contains property is set.
        /// </summary>
        internal bool IsSetContains() => this.Contains != null;

        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// An exact type match.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Exact { get; set; }

        /// <summary>
        /// Checks to see if the Exact property is set.
        /// </summary>
        internal bool IsSetExact() => this.Exact != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix type match. Matches the value with the prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
