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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// List of AWS services with program eligibility indicators (MAP, modernization pathways),
    /// cost estimates, and optimization recommendations.
    /// </summary>
    public partial class AwsProductDetails
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// Baseline service cost before optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// List of program and pathway categories this product is eligible for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Optimizations. 
        /// <para>
        /// List of specific optimization recommendations for this product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<AwsProductOptimization> Optimizations { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsProductOptimization>() : null;

        /// <summary>
        /// Checks to see if the Optimizations property is set.
        /// </summary>
        internal bool IsSetOptimizations() => this.Optimizations != null && (this.Optimizations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptimizedAmount. 
        /// <para>
        /// Service cost after applying optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string OptimizedAmount { get; set; }

        /// <summary>
        /// Checks to see if the OptimizedAmount property is set.
        /// </summary>
        internal bool IsSetOptimizedAmount() => this.OptimizedAmount != null;

        /// <summary>
        /// Gets and sets the property PotentialSavingsAmount. 
        /// <para>
        /// Service-specific cost reduction through optimizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PotentialSavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the PotentialSavingsAmount property is set.
        /// </summary>
        internal bool IsSetPotentialSavingsAmount() => this.PotentialSavingsAmount != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// AWS Partner Central product identifier used for opportunity association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Pricing Calculator service code.
        /// </para>
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;
    }
}
