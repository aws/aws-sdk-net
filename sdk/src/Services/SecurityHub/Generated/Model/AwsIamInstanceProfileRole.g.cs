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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a role associated with an instance profile.
    /// </summary>
    public partial class AwsIamInstanceProfileRole
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the role.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The policy that grants an entity permission to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string AssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the AssumeRolePolicyDocument property is set.
        /// </summary>
        internal bool IsSetAssumeRolePolicyDocument() => this.AssumeRolePolicyDocument != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the role was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the role.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The identifier of the role.
        /// </para>
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// Checks to see if the RoleId property is set.
        /// </summary>
        internal bool IsSetRoleId() => this.RoleId != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role.
        /// </para>
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;
    }
}
