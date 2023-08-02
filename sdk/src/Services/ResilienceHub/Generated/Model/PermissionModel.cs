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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the roles and credentials that Resilience Hub would use while creating the
    /// application, importing its resources, and running an assessment.
    /// </summary>
    public partial class PermissionModel
    {
        private List<string> _crossAccountRoleArns = new List<string>();
        private string _invokerRoleName;
        private PermissionModelType _type;

        /// <summary>
        /// Gets and sets the property CrossAccountRoleArns. 
        /// <para>
        /// Defines a list of role Amazon Resource Names (ARNs) to be used in other accounts.
        /// These ARNs are used for querying purposes while importing resources and assessing
        /// your application.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// These ARNs are required only when your resources are in other accounts and you have
        /// different role name in these accounts. Else, the invoker role name will be used in
        /// the other accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// These roles must have a trust policy with <code>iam:AssumeRole</code> permission to
        /// the invoker role in the primary account.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> CrossAccountRoleArns
        {
            get { return this._crossAccountRoleArns; }
            set { this._crossAccountRoleArns = value; }
        }

        // Check to see if CrossAccountRoleArns property is set
        internal bool IsSetCrossAccountRoleArns()
        {
            return this._crossAccountRoleArns != null && this._crossAccountRoleArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InvokerRoleName. 
        /// <para>
        /// Existing Amazon Web Services IAM role name in the primary Amazon Web Services account
        /// that will be assumed by Resilience Hub Service Principle to obtain a read-only access
        /// to your application resources while running an assessment.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have <code>iam:passRole</code> permission for this role while creating or
        /// updating the application.
        /// </para>
        ///  </note>
        /// </summary>
        public string InvokerRoleName
        {
            get { return this._invokerRoleName; }
            set { this._invokerRoleName = value; }
        }

        // Check to see if InvokerRoleName property is set
        internal bool IsSetInvokerRoleName()
        {
            return this._invokerRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Defines how Resilience Hub scans your resources. It can scan for the resources by
        /// using a pre-existing role in your Amazon Web Services account, or by using the credentials
        /// of the current IAM user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionModelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}