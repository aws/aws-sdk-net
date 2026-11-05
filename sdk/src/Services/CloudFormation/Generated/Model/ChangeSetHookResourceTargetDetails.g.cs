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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Specifies <c>RESOURCE</c> type target details for activated Hooks.
    /// </summary>
    public partial class ChangeSetHookResourceTargetDetails
    {
        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The resource's logical ID, which is defined in the stack's template.
        /// </para>
        /// </summary>
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceAction. 
        /// <para>
        /// Specifies the action of the resource.
        /// </para>
        /// </summary>
        public ChangeAction ResourceAction { get; set; }

        /// <summary>
        /// Checks to see if the ResourceAction property is set.
        /// </summary>
        internal bool IsSetResourceAction() => this.ResourceAction != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of CloudFormation resource, such as <c>AWS::S3::Bucket</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
