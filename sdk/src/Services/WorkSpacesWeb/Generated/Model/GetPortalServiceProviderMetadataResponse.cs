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
    /// This is the response object from the GetPortalServiceProviderMetadata operation.
    /// </summary>
    public partial class GetPortalServiceProviderMetadataResponse : AmazonWebServiceResponse
    {
        private string _portalArn;
        private string _serviceProviderSamlMetadata;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceProviderSamlMetadata. 
        /// <para>
        /// The service provider SAML metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=204800)]
        public string ServiceProviderSamlMetadata
        {
            get { return this._serviceProviderSamlMetadata; }
            set { this._serviceProviderSamlMetadata = value; }
        }

        // Check to see if ServiceProviderSamlMetadata property is set
        internal bool IsSetServiceProviderSamlMetadata()
        {
            return this._serviceProviderSamlMetadata != null;
        }

    }
}