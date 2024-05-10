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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes details for authentication that uses IAM.
    /// </summary>
    public partial class IamAuthenticationMethod
    {
        private Amazon.Runtime.Documents.Document _actorPolicy;

        /// <summary>
        /// Gets and sets the property ActorPolicy. 
        /// <para>
        /// An IAM policy document in JSON.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document ActorPolicy
        {
            get { return this._actorPolicy; }
            set { this._actorPolicy = value; }
        }

        // Check to see if ActorPolicy property is set
        internal bool IsSetActorPolicy()
        {
            return !this._actorPolicy.IsNull();
        }

    }
}