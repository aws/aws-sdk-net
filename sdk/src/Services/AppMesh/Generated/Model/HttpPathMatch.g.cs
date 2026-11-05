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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the path to match in the request.
    /// </summary>
    public partial class HttpPathMatch
    {
        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// The exact path to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Exact { get; set; }

        /// <summary>
        /// Checks to see if the Exact property is set.
        /// </summary>
        internal bool IsSetExact() => this.Exact != null;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regex used to match the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;
    }
}
