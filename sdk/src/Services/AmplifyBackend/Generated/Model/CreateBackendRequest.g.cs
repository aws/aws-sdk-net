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
    /// Container for the parameters to the CreateBackend operation. This operation creates
    /// a backend for an Amplify app. Backends are automatically created at the time of app
    /// creation.
    /// </summary>
    public partial class CreateBackendRequest : AmazonAmplifyBackendRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public string AppName { get; set; }

        /// <summary>
        /// Checks to see if the AppName property is set.
        /// </summary>
        internal bool IsSetAppName() => this.AppName != null;

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackendEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the BackendEnvironmentName property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentName() => this.BackendEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resource configuration for creating a backend.
        /// </para>
        /// </summary>
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;
    }
}
