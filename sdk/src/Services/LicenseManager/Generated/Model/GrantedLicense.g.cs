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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes a license that is granted to a grantee.
    /// </summary>
    public partial class GrantedLicense
    {
        /// <summary>
        /// Gets and sets the property Beneficiary. 
        /// <para>
        /// Granted license beneficiary.
        /// </para>
        /// </summary>
        public string Beneficiary { get; set; }

        /// <summary>
        /// Checks to see if the Beneficiary property is set.
        /// </summary>
        internal bool IsSetBeneficiary() => this.Beneficiary != null;

        /// <summary>
        /// Gets and sets the property ConsumptionConfiguration. 
        /// <para>
        /// Configuration for consumption of the license.
        /// </para>
        /// </summary>
        public ConsumptionConfiguration ConsumptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConsumptionConfiguration property is set.
        /// </summary>
        internal bool IsSetConsumptionConfiguration() => this.ConsumptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Creation time of the granted license.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Entitlement> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the granted license.
        /// </para>
        /// </summary>
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// Granted license issuer.
        /// </para>
        /// </summary>
        public IssuerDetails Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property LicenseMetadata. 
        /// <para>
        /// Granted license metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> LicenseMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;

        /// <summary>
        /// Checks to see if the LicenseMetadata property is set.
        /// </summary>
        internal bool IsSetLicenseMetadata() => this.LicenseMetadata != null && (this.LicenseMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseName. 
        /// <para>
        /// License name.
        /// </para>
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// Checks to see if the LicenseName property is set.
        /// </summary>
        internal bool IsSetLicenseName() => this.LicenseName != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// Product name.
        /// </para>
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ProductSKU. 
        /// <para>
        /// Product SKU.
        /// </para>
        /// </summary>
        public string ProductSKU { get; set; }

        /// <summary>
        /// Checks to see if the ProductSKU property is set.
        /// </summary>
        internal bool IsSetProductSKU() => this.ProductSKU != null;

        /// <summary>
        /// Gets and sets the property ReceivedMetadata. 
        /// <para>
        /// Granted license received metadata.
        /// </para>
        /// </summary>
        public ReceivedMetadata ReceivedMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedMetadata property is set.
        /// </summary>
        internal bool IsSetReceivedMetadata() => this.ReceivedMetadata != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Granted license status.
        /// </para>
        /// </summary>
        public LicenseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// Date and time range during which the granted license is valid, in ISO8601-UTC format.
        /// </para>
        /// </summary>
        public DatetimeRange Validity { get; set; }

        /// <summary>
        /// Checks to see if the Validity property is set.
        /// </summary>
        internal bool IsSetValidity() => this.Validity != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of the granted license.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
