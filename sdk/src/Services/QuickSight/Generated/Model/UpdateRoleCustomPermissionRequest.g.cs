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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoleCustomPermission operation. Updates
    /// the custom permissions that are associated with a role.
    /// </summary>
    public partial class UpdateRoleCustomPermissionRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that you want to create a group in. The
        /// Amazon Web Services account ID that you provide must be the same Amazon Web Services
        /// account that contains your Amazon Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// The name of the custom permission that you want to update the role with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CustomPermissionsName { get; set; }

        /// <summary>
        /// Checks to see if the CustomPermissionsName property is set.
        /// </summary>
        internal bool IsSetCustomPermissionsName() => this.CustomPermissionsName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace that contains the role that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name of role tht you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Role Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
