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
    /// Container for the parameters to the ModifyLaunchTemplate operation.
    /// Modifies a launch template. You can specify which version of the launch template to
    /// set as the default version. When launching an instance, the default version applies
    /// when a launch template version is not specified.
    /// </summary>
    public partial class ModifyLaunchTemplateRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _defaultVersion;
        private bool? _dryRun;
        private string _launchTemplateId;
        private string _launchTemplateName;

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
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// The version number of the launch template to set as the default version.
        /// </para>
        /// </summary>
        public string DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion != null;
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

    }
}