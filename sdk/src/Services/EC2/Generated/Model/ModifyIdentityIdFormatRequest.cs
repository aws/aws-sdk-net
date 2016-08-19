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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIdentityIdFormat operation.
    /// Modifies the ID format of a resource for the specified IAM user, IAM role, or root
    /// user. You can specify that resources should receive longer IDs (17-character IDs)
    /// when they are created. The following resource types support longer IDs: <code>instance</code>
    /// | <code>reservation</code> | <code>snapshot</code> | <code>volume</code>. For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
    /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// This setting applies to the principal specified in the request; it does not apply
    /// to the principal that makes the request. 
    /// </para>
    ///  
    /// <para>
    /// Resources created with longer IDs are visible to all IAM roles and users, regardless
    /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
    /// command for the resource type.
    /// </para>
    /// </summary>
    public partial class ModifyIdentityIdFormatRequest : AmazonEC2Request
    {
        private string _principalArn;
        private string _resource;
        private bool? _useLongIds;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal, which can be an IAM user, IAM role, or the root user.
        /// </para>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The type of resource: <code>instance</code> | <code>reservation</code> | <code>snapshot</code>
        /// | <code>volume</code> 
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property UseLongIds. 
        /// <para>
        /// Indicates whether the resource should use longer IDs (17-character IDs)
        /// </para>
        /// </summary>
        public bool UseLongIds
        {
            get { return this._useLongIds.GetValueOrDefault(); }
            set { this._useLongIds = value; }
        }

        // Check to see if UseLongIds property is set
        internal bool IsSetUseLongIds()
        {
            return this._useLongIds.HasValue; 
        }

    }
}