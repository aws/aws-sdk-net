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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement to match against labels that have been added to the web request by
    /// rules that have already run in the web ACL. 
    /// 
    ///  
    /// <para>
    /// The label match statement provides the label or namespace string to search for. The
    /// label string can represent a part or all of the fully qualified label name that had
    /// been added to the web request. Fully qualified labels have a prefix, optional namespaces,
    /// and label name. The prefix identifies the rule group or web ACL context of the rule
    /// that added the label. If you do not provide the fully qualified name in your label
    /// match string, WAF performs the search for labels that were added in the same context
    /// as the label match statement. 
    /// </para>
    /// </summary>
    public partial class LabelMatchStatement
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The string to match against. The setting you provide for this depends on the match
        /// statement's <c>Scope</c> setting: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <c>Scope</c> indicates <c>LABEL</c>, then this specification must include the
        /// name and can include any number of preceding namespace specifications and prefix up
        /// to providing the fully qualified label name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>Scope</c> indicates <c>NAMESPACE</c>, then this specification can include
        /// any number of contiguous namespace strings, and can include the entire label namespace
        /// prefix from the rule group or web ACL where the label originates.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Labels are case sensitive and components of a label must be separated by colon, for
        /// example <c>NS1:NS2:name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specify whether you want to match using the label name or just the namespace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelMatchScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
