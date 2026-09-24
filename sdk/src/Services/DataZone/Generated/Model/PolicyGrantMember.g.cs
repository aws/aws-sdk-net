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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A member of the policy grant list.
    /// </summary>
    public partial class PolicyGrantMember
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Specifies the timestamp at which policy grant member was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Specifies the user who created the policy grant member.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The details of the policy grant member.
        /// </para>
        /// </summary>
        public PolicyGrantDetail Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property GrantId. 
        /// <para>
        /// The ID of the policy grant.
        /// </para>
        /// </summary>
        public string GrantId { get; set; }

        /// <summary>
        /// Checks to see if the GrantId property is set.
        /// </summary>
        internal bool IsSetGrantId() => this.GrantId != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal of the policy grant member.
        /// </para>
        /// </summary>
        public PolicyGrantPrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;
    }
}
