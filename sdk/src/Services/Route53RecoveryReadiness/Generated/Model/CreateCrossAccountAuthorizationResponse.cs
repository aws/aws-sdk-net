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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the CreateCrossAccountAuthorization operation.
    /// </summary>
    public partial class CreateCrossAccountAuthorizationResponse : AmazonWebServiceResponse
    {
        private string _crossAccountAuthorization;

        /// <summary>
        /// Gets and sets the property CrossAccountAuthorization. 
        /// <para>
        /// The cross-account authorization.
        /// </para>
        /// </summary>
        public string CrossAccountAuthorization
        {
            get { return this._crossAccountAuthorization; }
            set { this._crossAccountAuthorization = value; }
        }

        // Check to see if CrossAccountAuthorization property is set
        internal bool IsSetCrossAccountAuthorization()
        {
            return this._crossAccountAuthorization != null;
        }

    }
}