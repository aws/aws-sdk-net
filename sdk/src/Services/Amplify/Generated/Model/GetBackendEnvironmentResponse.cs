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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the get backend environment result.
    /// </summary>
    public partial class GetBackendEnvironmentResponse : AmazonWebServiceResponse
    {
        private BackendEnvironment _backendEnvironment;

        /// <summary>
        /// Gets and sets the property BackendEnvironment. 
        /// <para>
        /// Describes the backend environment for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BackendEnvironment BackendEnvironment
        {
            get { return this._backendEnvironment; }
            set { this._backendEnvironment = value; }
        }

        // Check to see if BackendEnvironment property is set
        internal bool IsSetBackendEnvironment()
        {
            return this._backendEnvironment != null;
        }

    }
}