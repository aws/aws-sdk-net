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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure containing information about how this workspace works with IAM Identity
    /// Center.
    /// </summary>
    public partial class AwsSsoAuthentication
    {
        private string _ssoClientId;

        /// <summary>
        /// Gets and sets the property SsoClientId. 
        /// <para>
        /// The ID of the IAM Identity Center-managed application that is created by Amazon Managed
        /// Grafana.
        /// </para>
        /// </summary>
        public string SsoClientId
        {
            get { return this._ssoClientId; }
            set { this._ssoClientId = value; }
        }

        // Check to see if SsoClientId property is set
        internal bool IsSetSsoClientId()
        {
            return this._ssoClientId != null;
        }

    }
}