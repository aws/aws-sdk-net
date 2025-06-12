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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to websites that require user authentication.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        private List<BasicAuthenticationConfiguration> _basicAuthentication = AWSConfigs.InitializeCollections ? new List<BasicAuthenticationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property BasicAuthentication. 
        /// <para>
        /// The list of configuration information that's required to connect to and crawl a website
        /// host using basic authentication credentials.
        /// </para>
        ///  
        /// <para>
        /// The list includes the name and port number of the website host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BasicAuthenticationConfiguration> BasicAuthentication
        {
            get { return this._basicAuthentication; }
            set { this._basicAuthentication = value; }
        }

        // Check to see if BasicAuthentication property is set
        internal bool IsSetBasicAuthentication()
        {
            return this._basicAuthentication != null && (this._basicAuthentication.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}