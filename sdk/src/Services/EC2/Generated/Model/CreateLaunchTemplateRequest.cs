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
    /// Container for the parameters to the CreateLaunchTemplate operation.
    /// Creates a launch template.
    /// 
    ///  
    /// <para>
    /// A launch template contains the parameters to launch an instance. When you launch an
    /// instance using <a>RunInstances</a>, you can specify a launch template instead of providing
    /// the launch parameters in the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
    /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you want to clone an existing launch template as the basis for creating a new launch
    /// template, you can use the Amazon EC2 console. The API, SDKs, and CLI do not support
    /// cloning a template. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#create-launch-template-from-existing-launch-template">Create
    /// a launch template from an existing launch template</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLaunchTemplateRequest : AmazonEC2Request
    {
        private string _clientToken;
        private RequestLaunchTemplateData _launchTemplateData;
        private string _launchTemplateName;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
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
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// A name for the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the launch template on creation. To tag the launch template,
        /// the resource type must be <code>launch-template</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify the tags for the resources that are created when an instance is launched,
        /// you must use the <code>TagSpecifications</code> parameter in the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestLaunchTemplateData.html">launch
        /// template data</a> structure.
        /// </para>
        ///  </note>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the first version of the launch template.
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