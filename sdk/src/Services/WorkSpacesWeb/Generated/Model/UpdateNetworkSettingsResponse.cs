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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// This is the response object from the UpdateNetworkSettings operation.
    /// </summary>
    public partial class UpdateNetworkSettingsResponse : AmazonWebServiceResponse
    {
        private NetworkSettings _networkSettings;

        /// <summary>
        /// Gets and sets the property NetworkSettings. 
        /// <para>
        /// The network settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkSettings NetworkSettings
        {
            get { return this._networkSettings; }
            set { this._networkSettings = value; }
        }

        // Check to see if NetworkSettings property is set
        internal bool IsSetNetworkSettings()
        {
            return this._networkSettings != null;
        }

    }
}