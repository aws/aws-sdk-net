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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
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
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// This is the response object from the GetServiceSettings operation.
    /// </summary>
    public partial class GetServiceSettingsResponse : AmazonWebServiceResponse
    {
        private ServiceSettings _serviceSettings;

        /// <summary>
        /// Gets and sets the property ServiceSettings. 
        /// <para>
        /// Returns details about the settings for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        public ServiceSettings ServiceSettings
        {
            get { return this._serviceSettings; }
            set { this._serviceSettings = value; }
        }

        // Check to see if ServiceSettings property is set
        internal bool IsSetServiceSettings()
        {
            return this._serviceSettings != null;
        }

    }
}