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
    /// Describes a launch template version.
    /// </summary>
    public partial class LaunchTemplateVersion
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that created the version.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Indicates whether the version is the default version.
        /// </para>
        /// </summary>
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersion property is set.
        /// </summary>
        internal bool IsSetDefaultVersion() => this.DefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTemplateData. 
        /// <para>
        /// Information about the launch template.
        /// </para>
        /// </summary>
        public ResponseLaunchTemplateData LaunchTemplateData { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateData property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateData() => this.LaunchTemplateData != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
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
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateName property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateName() => this.LaunchTemplateName != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The entity that manages the launch template.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// The description for the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
