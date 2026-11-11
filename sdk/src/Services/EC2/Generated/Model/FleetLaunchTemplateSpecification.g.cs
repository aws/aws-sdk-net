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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The Amazon EC2 launch template that can be used by a Spot Fleet to configure Amazon
    /// EC2 instances. You must specify either the ID or name of the launch template in the
    /// request, but not both.
    /// 
    ///  
    /// <para>
    /// For information about launch templates, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
    /// an instance from a launch template</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class FleetLaunchTemplateSpecification
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        /// You must specify the <c>LaunchTemplateId</c> or the <c>LaunchTemplateName</c>, but
        /// not both.
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
        /// The name of the launch template.
        /// </para>
        ///  
        /// <para>
        /// You must specify the <c>LaunchTemplateName</c> or the <c>LaunchTemplateId</c>, but
        /// not both.
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
        /// The launch template version number, <c>$Latest</c>, or <c>$Default</c>. You must specify
        /// a value, otherwise the request fails.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>$Latest</c>, Amazon EC2 uses the latest version of the launch template.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>$Default</c>, Amazon EC2 uses the default version of the launch
        /// template.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
