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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies summary information about the space settings.
    /// </summary>
    public partial class SpaceSettingsSummary
    {
        private AppType _appType;
        private FeatureStatus _remoteAccess;
        private SpaceStorageSettings _spaceStorageSettings;

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of app created within the space.
        /// </para>
        /// </summary>
        public AppType AppType
        {
            get { return this._appType; }
            set { this._appType = value; }
        }

        // Check to see if AppType property is set
        internal bool IsSetAppType()
        {
            return this._appType != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccess. 
        /// <para>
        /// A setting that enables or disables remote access for a SageMaker space. When enabled,
        /// this allows you to connect to the remote space from your local IDE.
        /// </para>
        /// </summary>
        public FeatureStatus RemoteAccess
        {
            get { return this._remoteAccess; }
            set { this._remoteAccess = value; }
        }

        // Check to see if RemoteAccess property is set
        internal bool IsSetRemoteAccess()
        {
            return this._remoteAccess != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings. 
        /// <para>
        /// The storage settings for a space.
        /// </para>
        /// </summary>
        public SpaceStorageSettings SpaceStorageSettings
        {
            get { return this._spaceStorageSettings; }
            set { this._spaceStorageSettings = value; }
        }

        // Check to see if SpaceStorageSettings property is set
        internal bool IsSetSpaceStorageSettings()
        {
            return this._spaceStorageSettings != null;
        }

    }
}