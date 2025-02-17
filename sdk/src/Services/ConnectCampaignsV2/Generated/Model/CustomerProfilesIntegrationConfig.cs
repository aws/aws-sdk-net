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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Customer Profiles integration config
    /// </summary>
    public partial class CustomerProfilesIntegrationConfig
    {
        private string _domainArn;
        private Dictionary<string, string> _objectTypeNames = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DomainArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=500)]
        public string DomainArn
        {
            get { return this._domainArn; }
            set { this._domainArn = value; }
        }

        // Check to see if DomainArn property is set
        internal bool IsSetDomainArn()
        {
            return this._domainArn != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeNames.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ObjectTypeNames
        {
            get { return this._objectTypeNames; }
            set { this._objectTypeNames = value; }
        }

        // Check to see if ObjectTypeNames property is set
        internal bool IsSetObjectTypeNames()
        {
            return this._objectTypeNames != null && (this._objectTypeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}