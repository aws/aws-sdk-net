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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private string _kind;
        private string _name;
        private string _roleRefKind;
        private string _roleRefName;
        private string _uid;

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The kind of the role. For role binding, this value will be <c>RoleBinding</c>.
        /// </para>
        /// </summary>
        public string Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>RoleBinding</c>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleRefKind. 
        /// <para>
        /// The type of the role being referenced. This could be either <c>Role</c> or <c>ClusterRole</c>.
        /// </para>
        /// </summary>
        public string RoleRefKind
        {
            get { return this._roleRefKind; }
            set { this._roleRefKind = value; }
        }

        // Check to see if RoleRefKind property is set
        internal bool IsSetRoleRefKind()
        {
            return this._roleRefKind != null;
        }

        /// <summary>
        /// Gets and sets the property RoleRefName. 
        /// <para>
        /// The name of the role being referenced. This must match the name of the <c>Role</c>
        /// or <c>ClusterRole</c> that you want to bind to.
        /// </para>
        /// </summary>
        public string RoleRefName
        {
            get { return this._roleRefName; }
            set { this._roleRefName = value; }
        }

        // Check to see if RoleRefName property is set
        internal bool IsSetRoleRefName()
        {
            return this._roleRefName != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the role binding.
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

    }
}