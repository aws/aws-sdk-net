/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the AddLayerVersionPermission operation.
    /// Adds permissions to the resource-based policy of a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
    /// Lambda layer</a>. Use this action to grant layer usage permission to other accounts.
    /// You can grant permission to a single account, all AWS accounts, or all accounts in
    /// an organization.
    /// 
    ///  
    /// <para>
    /// To revoke permission, call <a>RemoveLayerVersionPermission</a> with the statement
    /// ID that you specified when you added it.
    /// </para>
    /// </summary>
    public partial class AddLayerVersionPermissionRequest : AmazonLambdaRequest
    {
        private string _action;
        private string _layerName;
        private string _organizationId;
        private string _principal;
        private string _revisionId;
        private string _statementId;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The API action that grants access to the layer. For example, <code>lambda:GetLayerVersion</code>.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
        public string LayerName
        {
            get { return this._layerName; }
            set { this._layerName = value; }
        }

        // Check to see if LayerName property is set
        internal bool IsSetLayerName()
        {
            return this._layerName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// With the principal set to <code>*</code>, grant permission to all accounts in the
        /// specified organization.
        /// </para>
        /// </summary>
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// An account ID, or <code>*</code> to grant permission to all AWS accounts.
        /// </para>
        /// </summary>
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Only update the policy if the revision ID matches the ID specified. Use this option
        /// to avoid modifying a policy that has changed since you last read it.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// An identifier that distinguishes the policy from others on the same layer version.
        /// </para>
        /// </summary>
        public string StatementId
        {
            get { return this._statementId; }
            set { this._statementId = value; }
        }

        // Check to see if StatementId property is set
        internal bool IsSetStatementId()
        {
            return this._statementId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}