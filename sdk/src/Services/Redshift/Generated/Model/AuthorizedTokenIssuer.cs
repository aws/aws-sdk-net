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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The authorized token issuer for the Amazon Redshift IAM Identity Center application.
    /// </summary>
    public partial class AuthorizedTokenIssuer
    {
        private List<string> _authorizedAudiencesList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trustedTokenIssuerArn;

        /// <summary>
        /// Gets and sets the property AuthorizedAudiencesList. 
        /// <para>
        /// The list of audiences for the authorized token issuer for integrating Amazon Redshift
        /// with IDC Identity Center.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizedAudiencesList
        {
            get { return this._authorizedAudiencesList; }
            set { this._authorizedAudiencesList = value; }
        }

        // Check to see if AuthorizedAudiencesList property is set
        internal bool IsSetAuthorizedAudiencesList()
        {
            return this._authorizedAudiencesList != null && (this._authorizedAudiencesList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerArn. 
        /// <para>
        /// The ARN for the authorized token issuer for integrating Amazon Redshift with IDC Identity
        /// Center.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TrustedTokenIssuerArn
        {
            get { return this._trustedTokenIssuerArn; }
            set { this._trustedTokenIssuerArn = value; }
        }

        // Check to see if TrustedTokenIssuerArn property is set
        internal bool IsSetTrustedTokenIssuerArn()
        {
            return this._trustedTokenIssuerArn != null;
        }

    }
}