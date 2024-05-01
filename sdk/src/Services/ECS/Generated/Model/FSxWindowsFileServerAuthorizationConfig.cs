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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The authorization configuration details for Amazon FSx for Windows File Server file
    /// system. See <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_FSxWindowsFileServerVolumeConfiguration.html">FSxWindowsFileServerVolumeConfiguration</a>
    /// in the <i>Amazon ECS API Reference</i>.
    /// 
    ///  
    /// <para>
    /// For more information and the input format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html">Amazon
    /// FSx for Windows File Server Volumes</a> in the <i>Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class FSxWindowsFileServerAuthorizationConfig
    {
        private string _credentialsParameter;
        private string _domain;

        /// <summary>
        /// Gets and sets the property CredentialsParameter. 
        /// <para>
        /// The authorization credential option to use. The authorization credential options can
        /// be provided using either the Amazon Resource Name (ARN) of an Secrets Manager secret
        /// or SSM Parameter Store parameter. The ARN refers to the stored credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialsParameter
        {
            get { return this._credentialsParameter; }
            set { this._credentialsParameter = value; }
        }

        // Check to see if CredentialsParameter property is set
        internal bool IsSetCredentialsParameter()
        {
            return this._credentialsParameter != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// A fully qualified domain name hosted by an <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">Directory
        /// Service</a> Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

    }
}