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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
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
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a resource-based permission policy to the Amazon Web Services Migration Hub
    /// Refactor Spaces environment. The policy must contain the same actions and condition
    /// statements as the <c>arn:aws:ram::aws:permission/AWSRAMDefaultPermissionRefactorSpacesEnvironment</c>
    /// permission in Resource Access Manager. The policy must not contain new lines or blank
    /// lines.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A JSON-formatted string for an Amazon Web Services resource-based policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to which the policy is being attached.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}