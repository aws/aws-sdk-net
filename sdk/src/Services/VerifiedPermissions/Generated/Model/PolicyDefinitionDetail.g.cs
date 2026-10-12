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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A structure that describes a policy definition. It must always have either an <c>static</c>
    /// or a <c>templateLinked</c> element.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_GetPolicy.html">GetPolicy</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class PolicyDefinitionDetail
    {
        /// <summary>
        /// Gets and sets the property Static. 
        /// <para>
        /// Information about a static policy that wasn't created with a policy template.
        /// </para>
        /// </summary>
        public StaticPolicyDefinitionDetail Static { get; set; }

        /// <summary>
        /// Checks to see if the Static property is set.
        /// </summary>
        internal bool IsSetStatic() => this.Static != null;

        /// <summary>
        /// Gets and sets the property TemplateLinked. 
        /// <para>
        /// Information about a template-linked policy that was created by instantiating a policy
        /// template.
        /// </para>
        /// </summary>
        public TemplateLinkedPolicyDefinitionDetail TemplateLinked { get; set; }

        /// <summary>
        /// Checks to see if the TemplateLinked property is set.
        /// </summary>
        internal bool IsSetTemplateLinked() => this.TemplateLinked != null;
    }
}
