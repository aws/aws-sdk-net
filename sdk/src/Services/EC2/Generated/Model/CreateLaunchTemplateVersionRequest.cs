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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchTemplateVersion operation.
    /// Creates a new version of a launch template. You can specify an existing version of
    /// launch template from which to base the new version.
    /// 
    ///  
    /// <para>
    /// Launch template versions are numbered in the order in which they are created. You
    /// cannot specify, change, or replace the numbering of launch template versions.
    /// </para>
    ///  
    /// <para>
    /// Launch templates are immutable; after you create a launch template, you can't modify
    /// it. Instead, you can create a new version of the launch template that includes any
    /// changes you require.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#manage-launch-template-versions">Modify
    /// a launch template (manage launch template versions)</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLaunchTemplateVersionRequest : AmazonEC2Request
    {
        private string _clientToken;
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
        /// You must specify either the <code>LaunchTemplateId</code> or the <code>LaunchTemplateName</code>,
        /// but not both.
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
        /// You must specify the <code>LaunchTemplateName</code> or the <code>LaunchTemplateId</code>,
        /// but not both.
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
        /// If <code>true</code>, and if a Systems Manager parameter is specified for <code>ImageId</code>,
        /// the AMI ID is displayed in the response for <code>imageID</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool ResolveAlias
        {
            get { return this._resolveAlias.GetValueOrDefault(); }
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
        /// The version number of the launch template version on which to base the new version.
        /// The new version inherits the same launch parameters as the source version, except
        /// for parameters that you specify in <code>LaunchTemplateData</code>. Snapshots applied
        /// to the block device mapping are ignored when creating a new version unless they are
        /// explicitly included.
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