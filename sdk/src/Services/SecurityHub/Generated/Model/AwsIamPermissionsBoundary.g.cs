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
    /// Information about the policy used to set the permissions boundary for an IAM principal.
    /// </summary>
    public partial class AwsIamPermissionsBoundary
    {
        /// <summary>
        /// Gets and sets the property PermissionsBoundaryArn. 
        /// <para>
        /// The ARN of the policy used to set the permissions boundary.
        /// </para>
        /// </summary>
        public string PermissionsBoundaryArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundaryArn property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundaryArn() => this.PermissionsBoundaryArn != null;

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryType. 
        /// <para>
        /// The usage type for the permissions boundary.
        /// </para>
        /// </summary>
        public string PermissionsBoundaryType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundaryType property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundaryType() => this.PermissionsBoundaryType != null;
    }
}
