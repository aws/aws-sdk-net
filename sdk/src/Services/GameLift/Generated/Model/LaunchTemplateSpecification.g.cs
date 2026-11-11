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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// An Amazon Elastic Compute Cloud launch template that contains configuration settings
    /// and game server code to be deployed to all instances in a game server group. The launch
    /// template is specified when creating a new game server group.
    /// </summary>
    public partial class LaunchTemplateSpecification
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// A unique identifier for an existing Amazon EC2 launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateId property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateId() => this.LaunchTemplateId != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// A readable identifier for an existing Amazon EC2 launch template. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateName property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateName() => this.LaunchTemplateName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Amazon EC2 launch template to use. If no version is specified,
        /// the default version will be used. With Amazon EC2, you can specify a default version
        /// for a launch template. If none is set, the default is the first version created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
