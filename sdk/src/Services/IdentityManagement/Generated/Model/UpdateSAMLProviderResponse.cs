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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateSAMLProvider.html">UpdateSAMLProvider</a>
    /// request.
    /// </summary>
    public partial class UpdateSAMLProviderResponse : AmazonWebServiceResponse
    {
        private string _samlProviderArn;

        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SAMLProviderArn
        {
            get { return this._samlProviderArn; }
            set { this._samlProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this._samlProviderArn != null;
        }

    }
}