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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceShare operation.
    /// Creates a resource share. You must provide a list of the Amazon Resource Names (ARNs)
    /// for the resources you want to share. You must also specify who you want to share the
    /// resources with, and the permissions that you grant them.
    /// 
    ///  <note> 
    /// <para>
    /// Sharing a resource makes it available for use by principals outside of the Amazon
    /// Web Services account that created the resource. Sharing doesn't change any permissions
    /// or quotas that apply to the resource in the account that created it.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateResourceShareRequest : AmazonRAMRequest
    {
        private bool? _allowExternalPrincipals;
        private string _clientToken;
        private string _name;
        private List<string> _permissionArns = new List<string>();
        private List<string> _principals = new List<string>();
        private List<string> _resourceArns = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AllowExternalPrincipals. 
        /// <para>
        /// Indicates whether principals outside your organization in Organizations can be associated
        /// with a resource share.
        /// </para>
        /// </summary>
        public bool AllowExternalPrincipals
        {
            get { return this._allowExternalPrincipals.GetValueOrDefault(); }
            set { this._allowExternalPrincipals = value; }
        }

        // Check to see if AllowExternalPrincipals property is set
        internal bool IsSetAllowExternalPrincipals()
        {
            return this._allowExternalPrincipals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PermissionArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the permissions to associate with the resource
        /// share. If you do not specify an ARN for the permission, RAM automatically attaches
        /// the default version of the permission for each resource type. Only one permission
        /// can be associated with each resource type in a resource share.
        /// </para>
        /// </summary>
        public List<string> PermissionArns
        {
            get { return this._permissionArns; }
            set { this._permissionArns = value; }
        }

        // Check to see if PermissionArns property is set
        internal bool IsSetPermissionArns()
        {
            return this._permissionArns != null && this._permissionArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The principals to associate with the resource share. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Resource Name (ARN) of an organization in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an organizational unit (OU) in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM role
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM user
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Not all resource types can be shared with IAM roles and IAM users. For more information,
        /// see <a href="https://docs.aws.amazon.com/ram/latest/userguide/permissions.html#permissions-rbp-supported-resource-types">Sharing
        /// with IAM roles and IAM users</a> in the <i>Resource Access Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARNs of the resources to associate with the resource share.
        /// </para>
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}