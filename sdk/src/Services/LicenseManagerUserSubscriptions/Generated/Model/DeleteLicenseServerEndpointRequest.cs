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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLicenseServerEndpoint operation.
    /// Deletes a <c>LicenseServerEndpoint</c> resource.
    /// </summary>
    public partial class DeleteLicenseServerEndpointRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        private string _licenseServerEndpointArn;
        private ServerType _serverType;

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the <c>LicenseServerEndpoint</c> resource
        /// to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseServerEndpointArn
        {
            get { return this._licenseServerEndpointArn; }
            set { this._licenseServerEndpointArn = value; }
        }

        // Check to see if LicenseServerEndpointArn property is set
        internal bool IsSetLicenseServerEndpointArn()
        {
            return this._licenseServerEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        /// The type of License Server that the delete request refers to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerType ServerType
        {
            get { return this._serverType; }
            set { this._serverType = value; }
        }

        // Check to see if ServerType property is set
        internal bool IsSetServerType()
        {
            return this._serverType != null;
        }

    }
}