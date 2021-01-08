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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes a license that is granted to a grantee.
    /// </summary>
    public partial class GrantedLicense
    {
        private string _beneficiary;
        private ConsumptionConfiguration _consumptionConfiguration;
        private string _createTime;
        private List<Entitlement> _entitlements = new List<Entitlement>();
        private string _homeRegion;
        private IssuerDetails _issuer;
        private string _licenseArn;
        private List<Metadata> _licenseMetadata = new List<Metadata>();
        private string _licenseName;
        private string _productName;
        private string _productSKU;
        private ReceivedMetadata _receivedMetadata;
        private LicenseStatus _status;
        private DatetimeRange _validity;
        private string _version;

        /// <summary>
        /// Gets and sets the property Beneficiary. 
        /// <para>
        /// Granted license beneficiary.
        /// </para>
        /// </summary>
        public string Beneficiary
        {
            get { return this._beneficiary; }
            set { this._beneficiary = value; }
        }

        // Check to see if Beneficiary property is set
        internal bool IsSetBeneficiary()
        {
            return this._beneficiary != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumptionConfiguration. 
        /// <para>
        /// Configuration for consumption of the license.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Creation time of the granted license.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements.
        /// </para>
        /// </summary>
        public List<Entitlement> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && this._entitlements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the granted license.
        /// </para>
        /// </summary>
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
        /// Granted license issuer.
        /// </para>
        /// </summary>
        public IssuerDetails Issuer
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
        [AWSProperty(Max=2048)]
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
        /// Granted license metadata.
        /// </para>
        /// </summary>
        public List<Metadata> LicenseMetadata
        {
            get { return this._licenseMetadata; }
            set { this._licenseMetadata = value; }
        }

        // Check to see if LicenseMetadata property is set
        internal bool IsSetLicenseMetadata()
        {
            return this._licenseMetadata != null && this._licenseMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LicenseName. 
        /// <para>
        /// License name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProductSKU. 
        /// <para>
        /// Product SKU.
        /// </para>
        /// </summary>
        public string ProductSKU
        {
            get { return this._productSKU; }
            set { this._productSKU = value; }
        }

        // Check to see if ProductSKU property is set
        internal bool IsSetProductSKU()
        {
            return this._productSKU != null;
        }

        /// <summary>
        /// Gets and sets the property ReceivedMetadata. 
        /// <para>
        /// Granted license received metadata.
        /// </para>
        /// </summary>
        public ReceivedMetadata ReceivedMetadata
        {
            get { return this._receivedMetadata; }
            set { this._receivedMetadata = value; }
        }

        // Check to see if ReceivedMetadata property is set
        internal bool IsSetReceivedMetadata()
        {
            return this._receivedMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Granted license status.
        /// </para>
        /// </summary>
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
        /// Date and time range during which the granted license is valid, in ISO8601-UTC format.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of the granted license.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}