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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AmplifyFeatureFlags. 
        /// <para>
        /// A stringified version of the cli.json file for your Amplify project.
        /// </para>
        /// </summary>
        public string AmplifyFeatureFlags { get; set; }

        /// <summary>
        /// Checks to see if the AmplifyFeatureFlags property is set.
        /// </summary>
        internal bool IsSetAmplifyFeatureFlags() => this.AmplifyFeatureFlags != null;

        /// <summary>
        /// Gets and sets the property AmplifyMetaConfig. 
        /// <para>
        /// A stringified version of the current configs for your Amplify project.
        /// </para>
        /// </summary>
        public string AmplifyMetaConfig { get; set; }

        /// <summary>
        /// Checks to see if the AmplifyMetaConfig property is set.
        /// </summary>
        internal bool IsSetAmplifyMetaConfig() => this.AmplifyMetaConfig != null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Checks to see if the AppName property is set.
        /// </summary>
        internal bool IsSetAppName() => this.AppName != null;

        /// <summary>
        /// Gets and sets the property BackendEnvironmentList. 
        /// <para>
        /// A list of backend environments in an array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BackendEnvironmentList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BackendEnvironmentList property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentList() => this.BackendEnvironmentList != null && (this.BackendEnvironmentList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        public string BackendEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the BackendEnvironmentName property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentName() => this.BackendEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the request failed, this is the returned error.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;
    }
}
