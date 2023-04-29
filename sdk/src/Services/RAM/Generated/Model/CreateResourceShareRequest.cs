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
    /// Creates a resource share. You can provide a list of the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// Resource Names (ARNs)</a> for the resources that you want to share, a list of principals
    /// you want to share the resources with, and the permissions to grant those principals.
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
        /// Specifies whether principals outside your organization in Organizations can be associated
        /// with a resource share. A value of <code>true</code> lets you share with individual
        /// Amazon Web Services accounts that are <i>not</i> in your organization. A value of
        /// <code>false</code> only has meaning if your account is a member of an Amazon Web Services
        /// Organization. The default value is <code>true</code>.
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
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <code>ClientToken</code>, but with different
        /// parameters, the retry fails with an <code>IdempotentParameterMismatch</code> error.
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
        /// Specifies the name of the resource share.
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
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> of the RAM permission to associate with the resource share.
        /// If you do not specify an ARN for the permission, RAM automatically attaches the default
        /// version of the permission for each resource type. You can associate only one permission
        /// with each resource type included in the resource share.
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
        /// Specifies a list of one or more principals to associate with the resource share.
        /// </para>
        ///  
        /// <para>
        /// You can include the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account ID, for example: <code>123456789012</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an organization in Organizations, for example: <code>organizations::123456789012:organization/o-exampleorgid</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an organizational unit (OU) in Organizations, for example: <code>organizations::123456789012:ou/o-exampleorgid/ou-examplerootid-exampleouid123</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM role, for example: <code>iam::123456789012:role/rolename</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM user, for example: <code>iam::123456789012user/username</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Not all resource types can be shared with IAM roles and users. For more information,
        /// see <a href="https://docs.aws.amazon.com/ram/latest/userguide/permissions.html#permissions-rbp-supported-resource-types">Sharing
        /// with IAM roles and users</a> in the <i>Resource Access Manager User Guide</i>.
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
        /// Specifies a list of one or more ARNs of the resources to associate with the resource
        /// share.
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
        /// Specifies one or more tags to attach to the resource share itself. It doesn't attach
        /// the tags to the resources associated with the resource share.
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