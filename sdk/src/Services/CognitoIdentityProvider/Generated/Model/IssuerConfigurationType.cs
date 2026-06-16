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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the issuer configuration for a user pool. Contains settings that determine
    /// how tokens are issued and validated.
    /// </summary>
    public partial class IssuerConfigurationType
    {
        private IssuerType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of issuer configuration. Determines the token issuing behavior for the user
        /// pool.
        /// </para>
        ///  <dl> <dt>ORIGINAL</dt> <dd> 
        /// <para>
        /// The original issuer configuration for user pools. The issuer URL is hosted in the
        /// user pool’s region and provides OIDC endpoints specific to that region.
        /// </para>
        ///  
        /// <para>
        /// Original issuers have the format of <c>https://cognito-idp.[region].amazonaws.com/[userPoolId]</c>
        /// 
        /// </para>
        ///  </dd> <dt>UPDATED</dt> <dd> 
        /// <para>
        /// Recommended for all user pools, including for multi-Region replication. Updated issuers
        /// host the same JWKS content in multiple regions, resulting in improved resilience and
        /// efficiency.
        /// </para>
        ///  
        /// <para>
        /// Updated issuers have the format of <c>https://issuer-cognito-idp.[region].amazonaws.com/[userPoolId]</c>,
        /// where region is the primary Amazon Web Services Region of your user pool.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public IssuerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}