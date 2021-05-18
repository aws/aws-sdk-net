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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the source deployed to an AWS App Runner service. It can be a code or an
    /// image repository.
    /// </summary>
    public partial class SourceConfiguration
    {
        private AuthenticationConfiguration _authenticationConfiguration;
        private bool? _autoDeploymentsEnabled;
        private CodeRepository _codeRepository;
        private ImageRepository _imageRepository;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// Describes the resources that are needed to authenticate access to some source repositories.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoDeploymentsEnabled. 
        /// <para>
        /// If <code>true</code>, continuous integration from the source repository is enabled
        /// for the App Runner service. Each repository change (source code commit or new image
        /// version) starts a deployment.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool AutoDeploymentsEnabled
        {
            get { return this._autoDeploymentsEnabled.GetValueOrDefault(); }
            set { this._autoDeploymentsEnabled = value; }
        }

        // Check to see if AutoDeploymentsEnabled property is set
        internal bool IsSetAutoDeploymentsEnabled()
        {
            return this._autoDeploymentsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// The description of a source code repository.
        /// </para>
        ///  
        /// <para>
        /// You must provide either this member or <code>ImageRepository</code> (but not both).
        /// </para>
        /// </summary>
        public CodeRepository CodeRepository
        {
            get { return this._codeRepository; }
            set { this._codeRepository = value; }
        }

        // Check to see if CodeRepository property is set
        internal bool IsSetCodeRepository()
        {
            return this._codeRepository != null;
        }

        /// <summary>
        /// Gets and sets the property ImageRepository. 
        /// <para>
        /// The description of a source image repository.
        /// </para>
        ///  
        /// <para>
        /// You must provide either this member or <code>CodeRepository</code> (but not both).
        /// </para>
        /// </summary>
        public ImageRepository ImageRepository
        {
            get { return this._imageRepository; }
            set { this._imageRepository = value; }
        }

        // Check to see if ImageRepository property is set
        internal bool IsSetImageRepository()
        {
            return this._imageRepository != null;
        }

    }
}