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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Identifies the launch template that the associated Windows AMI uses for launching
    /// an instance when faster launching is enabled.
    /// 
    ///  <note> 
    /// <para>
    /// You can specify either the <c>launchTemplateName</c> or the <c>launchTemplateId</c>,
    /// but not both.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FastLaunchLaunchTemplateSpecification
    {
        private string _launchTemplateId;
        private string _launchTemplateName;
        private string _launchTemplateVersion;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template to use for faster launching for a Windows AMI.
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
        /// The name of the launch template to use for faster launching for a Windows AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property LaunchTemplateVersion. 
        /// <para>
        /// The version of the launch template to use for faster launching for a Windows AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LaunchTemplateVersion
        {
            get { return this._launchTemplateVersion; }
            set { this._launchTemplateVersion = value; }
        }

        // Check to see if LaunchTemplateVersion property is set
        internal bool IsSetLaunchTemplateVersion()
        {
            return this._launchTemplateVersion != null;
        }

    }
}