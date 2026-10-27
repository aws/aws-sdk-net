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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The current account setting for a resource.
    /// </summary>
    public partial class Setting
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Amazon ECS resource name.
        /// </para>
        /// </summary>
        public SettingName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal. It can be a user, role, or the root user. If this field
        /// is omitted, the authenticated user is assumed.
        /// </para>
        /// </summary>
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether Amazon Web Services manages the account setting, or if the user
        /// manages it.
        /// </para>
        ///  
        /// <para>
        ///  <c>aws_managed</c> account settings are read-only, as Amazon Web Services manages
        /// such on the customer's behalf. Currently, the <c>guardDutyActivate</c> account setting
        /// is the only one Amazon Web Services manages.
        /// </para>
        /// </summary>
        public SettingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Determines whether the account setting is on or off for the specified resource.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
