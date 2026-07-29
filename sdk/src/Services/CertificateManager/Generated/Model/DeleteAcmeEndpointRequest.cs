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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAcmeEndpoint operation.
    /// Deletes an ACME endpoint. After deletion, the endpoint URL is no longer accessible
    /// and ACME clients cannot issue certificates through it. Any existing external account
    /// bindings and domain validations associated with the endpoint are also deleted.
    /// </summary>
    public partial class DeleteAcmeEndpointRequest : AmazonCertificateManagerRequest
    {
        private string _acmeEndpointArn;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string AcmeEndpointArn
        {
            get { return this._acmeEndpointArn; }
            set { this._acmeEndpointArn = value; }
        }

        // Check to see if AcmeEndpointArn property is set
        internal bool IsSetAcmeEndpointArn()
        {
            return this._acmeEndpointArn != null;
        }

    }
}