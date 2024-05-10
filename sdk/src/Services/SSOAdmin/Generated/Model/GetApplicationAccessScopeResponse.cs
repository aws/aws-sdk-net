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
    /// This is the response object from the GetApplicationAccessScope operation.
    /// </summary>
    public partial class GetApplicationAccessScopeResponse : AmazonWebServiceResponse
    {
        private List<string> _authorizedTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scope;

        /// <summary>
        /// Gets and sets the property AuthorizedTargets. 
        /// <para>
        /// An array of authorized targets associated with this access scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AuthorizedTargets
        {
            get { return this._authorizedTargets; }
            set { this._authorizedTargets = value; }
        }

        // Check to see if AuthorizedTargets property is set
        internal bool IsSetAuthorizedTargets()
        {
            return this._authorizedTargets != null && (this._authorizedTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The name of the access scope that can be used with the authorized targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}