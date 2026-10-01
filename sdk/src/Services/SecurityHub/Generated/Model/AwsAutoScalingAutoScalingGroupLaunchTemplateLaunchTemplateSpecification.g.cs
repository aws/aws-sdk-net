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
    /// Details about the launch template to use.
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupLaunchTemplateLaunchTemplateSpecification
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The identifier of the launch template. You must specify either <c>LaunchTemplateId</c>
        /// or <c>LaunchTemplateName</c>.
        /// </para>
        /// </summary>
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateId property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateId() => this.LaunchTemplateId != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// The name of the launch template. You must specify either <c>LaunchTemplateId</c> or
        /// <c>LaunchTemplateName</c>.
        /// </para>
        /// </summary>
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateName property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateName() => this.LaunchTemplateName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Identifies the version of the launch template. You can specify a version identifier,
        /// or use the values <c>$Latest</c> or <c>$Default</c>.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
