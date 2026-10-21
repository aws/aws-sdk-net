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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A key-value filter pair used in container association monitoring configurations to
    /// narrow which containers are tracked. The key must match exactly. The value can be
    /// an exact value or a wildcard pattern.
    /// </summary>
    public partial class ContainerAttribute
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The attribute key to filter on. For Amazon EKS, specify <c>namespace</c> to filter
        /// by namespace, or specify a Kubernetes label key. For Amazon ECS, specify a container
        /// instance attribute name. Keys don't support wildcards.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are letters, numbers, spaces, hyphens (<c>-</c>), underscores (<c>_</c>),
        /// periods (<c>.</c>), forward slashes (<c>/</c>), and colons (<c>:</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The attribute value to match. You can specify an exact value, such as <c>payments-api</c>,
        /// or a wildcard pattern, such as <c>payments-*</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are letters, numbers, spaces, hyphens (<c>-</c>), underscores (<c>_</c>),
        /// periods (<c>.</c>), forward slashes (<c>/</c>), colons (<c>:</c>), asterisks (<c>*</c>),
        /// and backslashes (<c>\</c>).
        /// </para>
        ///  
        /// <para>
        /// Network Firewall evaluates the value using the following rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An asterisk (<c>*</c>) matches zero or more characters. For example, <c>payments-*</c>
        /// matches <c>payments-</c>, <c>payments-api</c>, and <c>payments-api-v2</c>, and <c>*-prod</c>
        /// matches <c>web-prod</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The pattern must match the entire value. For example, <c>payments-*</c> doesn't match
        /// <c>my-payments-api</c>. To match a value that contains <c>payments</c> anywhere, use
        /// <c>*payments*</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matching is case sensitive. For example, <c>Payments-*</c> doesn't match <c>payments-api</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To match a literal asterisk, escape it with a backslash (<c>\*</c>). To match a literal
        /// backslash, use <c>\\</c>. A backslash followed by any other character matches a literal
        /// backslash followed by that character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A wildcard pattern matches only containers that have the attribute. For example, a
        /// filter with key <c>app</c> and value <c>*</c> matches every container that has an
        /// <c>app</c> label, but doesn't match a container without an <c>app</c> label.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A value that doesn't contain <c>*</c> or <c>\</c> matches only that exact value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A value can contain at most 10 unescaped asterisks. Escaped asterisks (<c>\*</c>)
        /// don't count toward this limit. A value can't end with a single unescaped backslash.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
