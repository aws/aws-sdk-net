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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a rewrite transform. This transform matches a pattern and replaces
    /// it with the specified string.
    /// </summary>
    public partial class RewriteConfig
    {
        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression to match in the input string. The maximum length of the string
        /// is 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// The replacement string to use when rewriting the matched input. The maximum length
        /// of the string is 1,024 characters. You can specify capture groups in the regular expression
        /// (for example, $1 and $2).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Replace { get; set; }

        /// <summary>
        /// Checks to see if the Replace property is set.
        /// </summary>
        internal bool IsSetReplace() => this.Replace != null;
    }
}
