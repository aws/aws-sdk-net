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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGrant operation.
    /// Creates a grant for the specified license. A grant shares the use of license entitlements
    /// with a specific Amazon Web Services account, an organization, or an organizational
    /// unit (OU). For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
    /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
    /// </summary>
    public partial class CreateGrantRequest : AmazonLicenseManagerRequest
    {
        private List<string> _allowedOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _grantName;
        private string _homeRegion;
        private string _licenseArn;
        private List<string> _principals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations for the grant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public List<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }

        // Check to see if AllowedOperations property is set
        internal bool IsSetAllowedOperations()
        {
            return this._allowedOperations != null && (this._allowedOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GrantName. 
        /// <para>
        /// Grant name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GrantName
        {
            get { return this._grantName; }
            set { this._grantName = value; }
        }

        // Check to see if GrantName property is set
        internal bool IsSetGrantName()
        {
            return this._grantName != null;
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string LicenseArn
        {
            get { return this._licenseArn; }
            set { this._licenseArn = value; }
        }

        // Check to see if LicenseArn property is set
        internal bool IsSetLicenseArn()
        {
            return this._licenseArn != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The grant principals. You can specify one of the following as an Amazon Resource Name
        /// (ARN):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account, which includes only the account specified.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// An organizational unit (OU), which includes all accounts in the OU.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// An organization, which will include all accounts across your organization.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && (this._principals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the grant. For more information about tagging support in License Manager,
        /// see the <a href="https://docs.aws.amazon.com/license-manager/latest/APIReference/API_TagResource.html">TagResource</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}