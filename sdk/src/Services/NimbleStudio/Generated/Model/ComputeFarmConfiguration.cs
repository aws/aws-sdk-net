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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The configuration for a render farm that is associated with a studio resource.
    /// </summary>
    public partial class ComputeFarmConfiguration
    {
        private string _activeDirectoryUser;
        private string _endpoint;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryUser. 
        /// <para>
        /// The name of an Active Directory user that is used on ComputeFarm worker instances.
        /// </para>
        /// </summary>
        public string ActiveDirectoryUser
        {
            get { return this._activeDirectoryUser; }
            set { this._activeDirectoryUser = value; }
        }

        // Check to see if ActiveDirectoryUser property is set
        internal bool IsSetActiveDirectoryUser()
        {
            return this._activeDirectoryUser != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint of the ComputeFarm that is accessed by the studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

    }
}