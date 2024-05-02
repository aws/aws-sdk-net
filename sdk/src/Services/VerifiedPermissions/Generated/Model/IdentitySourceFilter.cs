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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A structure that defines characteristics of an identity source that you can use to
    /// filter.
    /// 
    ///  
    /// <para>
    /// This data type is a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListIdentityStores.html">ListIdentityStores</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class IdentitySourceFilter
    {
        private string _principalEntityType;

        /// <summary>
        /// Gets and sets the property PrincipalEntityType. 
        /// <para>
        /// The Cedar entity type of the principals returned by the identity provider (IdP) associated
        /// with this identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string PrincipalEntityType
        {
            get { return this._principalEntityType; }
            set { this._principalEntityType = value; }
        }

        // Check to see if PrincipalEntityType property is set
        internal bool IsSetPrincipalEntityType()
        {
            return this._principalEntityType != null;
        }

    }
}