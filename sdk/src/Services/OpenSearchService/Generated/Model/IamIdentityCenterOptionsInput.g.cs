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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Configuration settings for enabling and managing IAM Identity Center.
    /// </summary>
    public partial class IamIdentityCenterOptionsInput
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether IAM Identity Center is enabled or disabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IamIdentityCenterInstanceArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamIdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIamIdentityCenterInstanceArn() => this.IamIdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleForIdentityCenterApplicationArn. 
        /// <para>
        /// The ARN of the IAM role associated with the IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamRoleForIdentityCenterApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleForIdentityCenterApplicationArn property is set.
        /// </summary>
        internal bool IsSetIamRoleForIdentityCenterApplicationArn() => this.IamRoleForIdentityCenterApplicationArn != null;
    }
}
