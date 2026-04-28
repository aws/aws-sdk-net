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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Information about an integrated repository
    /// </summary>
    public partial class IntegratedRepository
    {
        private string _integrationId;
        private string _providerResourceId;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// Integration identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationId
        {
            get { return this._integrationId; }
            set { this._integrationId = value; }
        }

        // Check to see if IntegrationId property is set
        internal bool IsSetIntegrationId()
        {
            return this._integrationId != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderResourceId. 
        /// <para>
        /// External provider resource identifier, e.g., Github repository identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderResourceId
        {
            get { return this._providerResourceId; }
            set { this._providerResourceId = value; }
        }

        // Check to see if ProviderResourceId property is set
        internal bool IsSetProviderResourceId()
        {
            return this._providerResourceId != null;
        }

    }
}