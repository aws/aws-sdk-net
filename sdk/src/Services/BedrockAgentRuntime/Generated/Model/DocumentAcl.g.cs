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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The access control list for a document, containing allow and deny membership lists.
    /// Each list specifies conditions that determine which users and groups are granted or
    /// denied access.
    /// </summary>
    public partial class DocumentAcl
    {
        /// <summary>
        /// Gets and sets the property AllowList. 
        /// <para>
        /// The list of principals allowed access to the document.
        /// </para>
        /// </summary>
        public DocumentAclMembership AllowList { get; set; }

        /// <summary>
        /// Checks to see if the AllowList property is set.
        /// </summary>
        internal bool IsSetAllowList() => this.AllowList != null;

        /// <summary>
        /// Gets and sets the property DenyList. 
        /// <para>
        /// The list of principals denied access to the document.
        /// </para>
        /// </summary>
        public DocumentAclMembership DenyList { get; set; }

        /// <summary>
        /// Checks to see if the DenyList property is set.
        /// </summary>
        internal bool IsSetDenyList() => this.DenyList != null;
    }
}
