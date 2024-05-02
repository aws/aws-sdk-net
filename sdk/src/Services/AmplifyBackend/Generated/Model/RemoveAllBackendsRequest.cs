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
    /// Container for the parameters to the RemoveAllBackends operation.
    /// Removes all backend environments from your Amplify project.
    /// </summary>
    public partial class RemoveAllBackendsRequest : AmazonAmplifyBackendRequest
    {
        private string _appId;
        private bool? _cleanAmplifyApp;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CleanAmplifyApp. 
        /// <para>
        /// Cleans up the Amplify Console app if this value is set to true.
        /// </para>
        /// </summary>
        public bool? CleanAmplifyApp
        {
            get { return this._cleanAmplifyApp; }
            set { this._cleanAmplifyApp = value; }
        }

        // Check to see if CleanAmplifyApp property is set
        internal bool IsSetCleanAmplifyApp()
        {
            return this._cleanAmplifyApp.HasValue; 
        }

    }
}