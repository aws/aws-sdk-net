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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector metadata specific to Salesforce.
    /// </summary>
    public partial class SalesforceMetadata
    {
        private List<string> _dataTransferApis = new List<string>();
        private List<string> _oAuthScopes = new List<string>();

        /// <summary>
        /// Gets and sets the property DataTransferApis. 
        /// <para>
        /// The Salesforce APIs that you can have Amazon AppFlow use when your flows transfers
        /// data to or from Salesforce.
        /// </para>
        /// </summary>
        public List<string> DataTransferApis
        {
            get { return this._dataTransferApis; }
            set { this._dataTransferApis = value; }
        }

        // Check to see if DataTransferApis property is set
        internal bool IsSetDataTransferApis()
        {
            return this._dataTransferApis != null && this._dataTransferApis.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        ///  The desired authorization scope for the Salesforce account. 
        /// </para>
        /// </summary>
        public List<string> OAuthScopes
        {
            get { return this._oAuthScopes; }
            set { this._oAuthScopes = value; }
        }

        // Check to see if OAuthScopes property is set
        internal bool IsSetOAuthScopes()
        {
            return this._oAuthScopes != null && this._oAuthScopes.Count > 0; 
        }

    }
}