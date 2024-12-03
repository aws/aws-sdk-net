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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents a launch template to use in place of the default launch
    /// template. You must specify either the launch template ID or launch template name in
    /// the request, but not both.
    /// 
    ///  
    /// <para>
    /// If security groups are specified using both the <c>securityGroupIds</c> parameter
    /// of <c>CreateComputeEnvironment</c> and the launch template, the values in the <c>securityGroupIds</c>
    /// parameter of <c>CreateComputeEnvironment</c> will be used.
    /// </para>
    ///  
    /// <para>
    /// You can define up to ten (10) overrides for each compute environment.
    /// </para>
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// To unset all override templates for a compute environment, you can pass an empty array
    /// to the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_UpdateComputeEnvironment.html">UpdateComputeEnvironment.overrides</a>
    /// parameter, or not include the <c>overrides</c> parameter when submitting the <c>UpdateComputeEnvironment</c>
    /// API operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LaunchTemplateSpecificationOverride
    {
        private string _launchTemplateId;
        private string _launchTemplateName;
        private List<string> _targetInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> If you specify the <c>launchTemplateId</c> you can't specify the <c>launchTemplateName</c>
        /// as well.
        /// </para>
        /// </summary>
        public string LaunchTemplateId
        {
            get { return this._launchTemplateId; }
            set { this._launchTemplateId = value; }
        }

        // Check to see if LaunchTemplateId property is set
        internal bool IsSetLaunchTemplateId()
        {
            return this._launchTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// The name of the launch template.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> If you specify the <c>launchTemplateName</c> you can't specify the <c>launchTemplateId</c>
        /// as well.
        /// </para>
        /// </summary>
        public string LaunchTemplateName
        {
            get { return this._launchTemplateName; }
            set { this._launchTemplateName = value; }
        }

        // Check to see if LaunchTemplateName property is set
        internal bool IsSetLaunchTemplateName()
        {
            return this._launchTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetInstanceTypes. 
        /// <para>
        /// The instance type or family that this this override launch template should be applied
        /// to.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when defining a launch template override.
        /// </para>
        ///  
        /// <para>
        /// Information included in this parameter must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a valid Amazon EC2 instance type or family.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>optimal</c> isn't allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>targetInstanceTypes</c> can target only instance types and families that are included
        /// within the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_ComputeResource.html#Batch-Type-ComputeResource-instanceTypes">
        /// <c>ComputeResource.instanceTypes</c> </a> set. <c>targetInstanceTypes</c> doesn't
        /// need to include all of the instances from the <c>instanceType</c> set, but at least
        /// a subset. For example, if <c>ComputeResource.instanceTypes</c> includes <c>[m5, g5]</c>,
        /// <c>targetInstanceTypes</c> can include <c>[m5.2xlarge]</c> and <c>[m5.large]</c> but
        /// not <c>[c5.large]</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>targetInstanceTypes</c> included within the same launch template override or across
        /// launch template overrides can't overlap for the same compute environment. For example,
        /// you can't define one launch template override to target an instance family and another
        /// define an instance type within this same family.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> TargetInstanceTypes
        {
            get { return this._targetInstanceTypes; }
            set { this._targetInstanceTypes = value; }
        }

        // Check to see if TargetInstanceTypes property is set
        internal bool IsSetTargetInstanceTypes()
        {
            return this._targetInstanceTypes != null && (this._targetInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the launch template, <c>$Default</c>, or <c>$Latest</c>.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>$Default</c>, the default version of the launch template is used.
        /// If the value is <c>$Latest</c>, the latest version of the launch template is used.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// If the AMI ID that's used in a compute environment is from the launch template, the
        /// AMI isn't changed when the compute environment is updated. It's only changed if the
        /// <c>updateToLatestImageVersion</c> parameter for the compute environment is set to
        /// <c>true</c>. During an infrastructure update, if either <c>$Default</c> or <c>$Latest</c>
        /// is specified, Batch re-evaluates the launch template version, and it might use a different
        /// version of the launch template. This is the case even if the launch template isn't
        /// specified in the update. When updating a compute environment, changing the launch
        /// template requires an infrastructure update of the compute environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Default: <c>$Default</c> 
        /// </para>
        ///  
        /// <para>
        /// Latest: <c>$Latest</c> 
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}