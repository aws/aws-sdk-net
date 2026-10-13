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
    /// Container for the parameters to the CreateLicenseVersion operation. Creates a new
    /// version of the specified license.
    /// </summary>
    public partial class CreateLicenseVersionRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConsumptionConfiguration. 
        /// <para>
        /// Configuration for consumption of the license. Choose a provisional configuration for
        /// workloads running with continuous connectivity. Choose a borrow configuration for
        /// workloads with offline usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConsumptionConfiguration ConsumptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConsumptionConfiguration property is set.
        /// </summary>
        internal bool IsSetConsumptionConfiguration() => this.ConsumptionConfiguration != null;

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
        [AWSProperty(Required = true)]
        public List<Entitlement> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// License issuer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Issuer Issuer { get; set; }

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
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property LicenseMetadata. 
        /// <para>
        /// Information about the license.
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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ResetUsage. 
        /// <para>
        /// Specifies whether to reset the license usage for the new license version. If you don't
        /// specify a value, the license usage is not reset.
        /// </para>
        /// </summary>
        public bool? ResetUsage { get; set; }

        /// <summary>
        /// Checks to see if the ResetUsage property is set.
        /// </summary>
        internal bool IsSetResetUsage() => this.ResetUsage.HasValue;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Current version of the license.
        /// </para>
        /// </summary>
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// Date and time range during which the license is valid, in ISO8601-UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatetimeRange Validity { get; set; }

        /// <summary>
        /// Checks to see if the Validity property is set.
        /// </summary>
        internal bool IsSetValidity() => this.Validity != null;
    }
}
