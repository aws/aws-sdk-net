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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing a launch template associated with a compute resource. You must
    /// specify either the launch template ID or launch template name in the request, but
    /// not both.
    /// 
    ///  
    /// <para>
    /// If security groups are specified using both the <code>securityGroupIds</code> parameter
    /// of <code>CreateComputeEnvironment</code> and the launch template, the values in the
    /// <code>securityGroupIds</code> parameter of <code>CreateComputeEnvironment</code> will
    /// be used.
    /// </para>
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LaunchTemplateSpecification
    {
        private string _launchTemplateId;
        private string _launchTemplateName;
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the launch template, <code>$Latest</code>, or <code>$Default</code>.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>$Latest</code>, the latest version of the launch template is
        /// used. If the value is <code>$Default</code>, the default version of the launch template
        /// is used.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>$Default</code>.
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