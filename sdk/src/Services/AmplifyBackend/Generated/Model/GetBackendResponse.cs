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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the GetBackend operation.
    /// </summary>
    public partial class GetBackendResponse : AmazonWebServiceResponse
    {
        private string _amplifyFeatureFlags;
        private string _amplifyMetaConfig;
        private string _appId;
        private string _appName;
        private List<string> _backendEnvironmentList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _backendEnvironmentName;
        private string _error;

        /// <summary>
        /// Gets and sets the property AmplifyFeatureFlags. 
        /// <para>
        /// A stringified version of the cli.json file for your Amplify project.
        /// </para>
        /// </summary>
        public string AmplifyFeatureFlags
        {
            get { return this._amplifyFeatureFlags; }
            set { this._amplifyFeatureFlags = value; }
        }

        // Check to see if AmplifyFeatureFlags property is set
        internal bool IsSetAmplifyFeatureFlags()
        {
            return this._amplifyFeatureFlags != null;
        }

        /// <summary>
        /// Gets and sets the property AmplifyMetaConfig. 
        /// <para>
        /// A stringified version of the current configs for your Amplify project.
        /// </para>
        /// </summary>
        public string AmplifyMetaConfig
        {
            get { return this._amplifyMetaConfig; }
            set { this._amplifyMetaConfig = value; }
        }

        // Check to see if AmplifyMetaConfig property is set
        internal bool IsSetAmplifyMetaConfig()
        {
            return this._amplifyMetaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        public string AppName
        {
            get { return this._appName; }
            set { this._appName = value; }
        }

        // Check to see if AppName property is set
        internal bool IsSetAppName()
        {
            return this._appName != null;
        }

        /// <summary>
        /// Gets and sets the property BackendEnvironmentList. 
        /// <para>
        /// A list of backend environments in an array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BackendEnvironmentList
        {
            get { return this._backendEnvironmentList; }
            set { this._backendEnvironmentList = value; }
        }

        // Check to see if BackendEnvironmentList property is set
        internal bool IsSetBackendEnvironmentList()
        {
            return this._backendEnvironmentList != null && (this._backendEnvironmentList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        public string BackendEnvironmentName
        {
            get { return this._backendEnvironmentName; }
            set { this._backendEnvironmentName = value; }
        }

        // Check to see if BackendEnvironmentName property is set
        internal bool IsSetBackendEnvironmentName()
        {
            return this._backendEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the request failed, this is the returned error.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

    }
}