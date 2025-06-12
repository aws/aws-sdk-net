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
    /// Container for the parameters to the CreateLicenseVersion operation.
    /// Creates a new version of the specified license.
    /// </summary>
    public partial class CreateLicenseVersionRequest : AmazonLicenseManagerRequest
    {
        private string _clientToken;
        private ConsumptionConfiguration _consumptionConfiguration;
        private List<Entitlement> _entitlements = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;
        private string _homeRegion;
        private Issuer _issuer;
        private string _licenseArn;
        private List<Metadata> _licenseMetadata = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;
        private string _licenseName;
        private string _productName;
        private string _sourceVersion;
        private LicenseStatus _status;
        private DatetimeRange _validity;

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
        /// Gets and sets the property ConsumptionConfiguration. 
        /// <para>
        /// Configuration for consumption of the license. Choose a provisional configuration for
        /// workloads running with continuous connectivity. Choose a borrow configuration for
        /// workloads with offline usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConsumptionConfiguration ConsumptionConfiguration
        {
            get { return this._consumptionConfiguration; }
            set { this._consumptionConfiguration = value; }
        }

        // Check to see if ConsumptionConfiguration property is set
        internal bool IsSetConsumptionConfiguration()
        {
            return this._consumptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Entitlement> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && (this._entitlements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the license.
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
        /// Gets and sets the property Issuer. 
        /// <para>
        /// License issuer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Issuer Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
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
        /// Gets and sets the property LicenseMetadata. 
        /// <para>
        /// Information about the license.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> LicenseMetadata
        {
            get { return this._licenseMetadata; }
            set { this._licenseMetadata = value; }
        }

        // Check to see if LicenseMetadata property is set
        internal bool IsSetLicenseMetadata()
        {
            return this._licenseMetadata != null && (this._licenseMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseName. 
        /// <para>
        /// License name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseName
        {
            get { return this._licenseName; }
            set { this._licenseName = value; }
        }

        // Check to see if LicenseName property is set
        internal bool IsSetLicenseName()
        {
            return this._licenseName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// Product name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Current version of the license.
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LicenseStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// Date and time range during which the license is valid, in ISO8601-UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatetimeRange Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity != null;
        }

    }
}