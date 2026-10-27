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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the role binding that grants the permission defined in
    /// a Kubernetes role.
    /// </summary>
    public partial class KubernetesRoleBindingDetails
    {
        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The kind of the role. For role binding, this value will be <c>RoleBinding</c>.
        /// </para>
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// Checks to see if the Kind property is set.
        /// </summary>
        internal bool IsSetKind() => this.Kind != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>RoleBinding</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleRefKind. 
        /// <para>
        /// The type of the role being referenced. This could be either <c>Role</c> or <c>ClusterRole</c>.
        /// </para>
        /// </summary>
        public string RoleRefKind { get; set; }

        /// <summary>
        /// Checks to see if the RoleRefKind property is set.
        /// </summary>
        internal bool IsSetRoleRefKind() => this.RoleRefKind != null;

        /// <summary>
        /// Gets and sets the property RoleRefName. 
        /// <para>
        /// The name of the role being referenced. This must match the name of the <c>Role</c>
        /// or <c>ClusterRole</c> that you want to bind to.
        /// </para>
        /// </summary>
        public string RoleRefName { get; set; }

        /// <summary>
        /// Checks to see if the RoleRefName property is set.
        /// </summary>
        internal bool IsSetRoleRefName() => this.RoleRefName != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the role binding.
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
