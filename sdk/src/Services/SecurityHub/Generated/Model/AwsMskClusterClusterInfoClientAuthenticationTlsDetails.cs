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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details for client authentication using TLS.
    /// </summary>
    public partial class AwsMskClusterClusterInfoClientAuthenticationTlsDetails
    {
        private List<string> _certificateAuthorityArnList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArnList. 
        /// <para>
        ///  List of Amazon Web Services Private CA Amazon Resource Names (ARNs). Amazon Web Services
        /// Private CA enables creation of private certificate authority (CA) hierarchies, including
        /// root and subordinate CAs, without the investment and maintenance costs of operating
        /// an on-premises CA.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CertificateAuthorityArnList
        {
            get { return this._certificateAuthorityArnList; }
            set { this._certificateAuthorityArnList = value; }
        }

        // Check to see if CertificateAuthorityArnList property is set
        internal bool IsSetCertificateAuthorityArnList()
        {
            return this._certificateAuthorityArnList != null && (this._certificateAuthorityArnList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Indicates whether TLS authentication is enabled or not.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}