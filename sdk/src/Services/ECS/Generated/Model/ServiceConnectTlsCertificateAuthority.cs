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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The certificate root authority that secures your service.
    /// </summary>
    public partial class ServiceConnectTlsCertificateAuthority
    {
        private string _awsPcaAuthorityArn;

        /// <summary>
        /// Gets and sets the property AwsPcaAuthorityArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Private Certificate Authority certificate.
        /// </para>
        /// </summary>
        public string AwsPcaAuthorityArn
        {
            get { return this._awsPcaAuthorityArn; }
            set { this._awsPcaAuthorityArn = value; }
        }

        // Check to see if AwsPcaAuthorityArn property is set
        internal bool IsSetAwsPcaAuthorityArn()
        {
            return this._awsPcaAuthorityArn != null;
        }

    }
}