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
    /// An object that represents a launch template that's associated with a compute resource.
    /// You must specify either the launch template ID or launch template name in the request,
    /// but not both.
    /// 
    ///  
    /// <para>
    /// If security groups are specified using both the <c>securityGroupIds</c> parameter
    /// of <c>CreateComputeEnvironment</c> and the launch template, the values in the <c>securityGroupIds</c>
    /// parameter of <c>CreateComputeEnvironment</c> will be used.
    /// </para>
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LaunchTemplateSpecification
    {
        private string _launchTemplateId;
        private string _launchTemplateName;
        private List<LaunchTemplateSpecificationOverride> _overrides = AWSConfigs.InitializeCollections ? new List<LaunchTemplateSpecificationOverride>() : null;
        private UserdataType _userdataType;
        private string _version;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
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
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A launch template to use in place of the default launch template. You must specify
        /// either the launch template ID or launch template name in the request, but not both.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to ten (10) launch template overrides that are associated to unique
        /// instance types or families for each compute environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// To unset all override templates for a compute environment, you can pass an empty array
        /// to the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_UpdateComputeEnvironment.html">UpdateComputeEnvironment.overrides</a>
        /// parameter, or not include the <c>overrides</c> parameter when submitting the <c>UpdateComputeEnvironment</c>
        /// API operation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateSpecificationOverride> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && (this._overrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserdataType. 
        /// <para>
        /// The EKS node initialization process to use. You only need to specify this value if
        /// you are using a custom AMI. The default value is <c>EKS_BOOTSTRAP_SH</c>. If <i>imageType</i>
        /// is a custom AMI based on EKS_AL2023 or EKS_AL2023_NVIDIA then you must choose <c>EKS_NODEADM</c>.
        /// </para>
        /// </summary>
        public UserdataType UserdataType
        {
            get { return this._userdataType; }
            set { this._userdataType = value; }
        }

        // Check to see if UserdataType property is set
        internal bool IsSetUserdataType()
        {
            return this._userdataType != null;
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