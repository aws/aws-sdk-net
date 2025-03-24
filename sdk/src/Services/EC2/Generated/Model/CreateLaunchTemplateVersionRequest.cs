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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateLaunchTemplateVersion operation.
    /// Creates a new version of a launch template. You must specify an existing launch template,
    /// either by name or ID. You can determine whether the new version inherits parameters
    /// from a source version, and add or overwrite parameters as needed.
    /// 
    ///  
    /// <para>
    /// Launch template versions are numbered in the order in which they are created. You
    /// can't specify, change, or replace the numbering of launch template versions.
    /// </para>
    ///  
    /// <para>
    /// Launch templates are immutable; after you create a launch template, you can't modify
    /// it. Instead, you can create a new version of the launch template that includes the
    /// changes that you require.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-launch-template-versions.html">Modify
    /// a launch template (manage launch template versions)</a> in the <i>Amazon EC2 User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLaunchTemplateVersionRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _dryRun;
        private RequestLaunchTemplateData _launchTemplateData;
        private string _launchTemplateId;
        private string _launchTemplateName;
        private bool? _resolveAlias;
        private string _sourceVersion;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If a client token isn't specified, a randomly generated token is used in the request
        /// to ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Maximum 128 ASCII characters.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateData. 
        /// <para>
        /// The information for the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestLaunchTemplateData LaunchTemplateData
        {
            get { return this._launchTemplateData; }
            set { this._launchTemplateData = value; }
        }

        // Check to see if LaunchTemplateData property is set
        internal bool IsSetLaunchTemplateData()
        {
            return this._launchTemplateData != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the launch template ID or the launch template name, but not
        /// both.
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
        /// You must specify either the launch template ID or the launch template name, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property ResolveAlias. 
        /// <para>
        /// If <c>true</c>, and if a Systems Manager parameter is specified for <c>ImageId</c>,
        /// the AMI ID is displayed in the response for <c>imageID</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ResolveAlias
        {
            get { return this._resolveAlias; }
            set { this._resolveAlias = value; }
        }

        // Check to see if ResolveAlias property is set
        internal bool IsSetResolveAlias()
        {
            return this._resolveAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The version of the launch template on which to base the new version. Snapshots applied
        /// to the block device mapping are ignored when creating a new version unless they are
        /// explicitly included.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter, the new version inherits the launch parameters from
        /// the source version. If you specify additional launch parameters for the new version,
        /// they overwrite any corresponding launch parameters inherited from the source version.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the new version contains only the launch parameters that
        /// you specify for the new version.
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the version of the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}