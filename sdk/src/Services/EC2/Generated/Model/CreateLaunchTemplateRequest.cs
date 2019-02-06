/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchTemplate operation.
    /// Creates a launch template. A launch template contains the parameters to launch an
    /// instance. When you launch an instance using <a>RunInstances</a>, you can specify a
    /// launch template instead of providing the launch parameters in the request.
    /// </summary>
    public partial class CreateLaunchTemplateRequest : AmazonEC2Request
    {
        private string _clientToken;
        private RequestLaunchTemplateData _launchTemplateData;
        private string _launchTemplateName;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the first version of the launch template.
        /// </para>
        /// </summary>
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