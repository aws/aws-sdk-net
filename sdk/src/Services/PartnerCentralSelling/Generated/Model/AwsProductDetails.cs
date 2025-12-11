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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// AWS services with program eligibility indicators (MAP, modernization pathways), cost
    /// estimates, and optimization recommendations.
    /// </summary>
    public partial class AwsProductDetails
    {
        private string _amount;
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AwsProductOptimization> _optimizations = AWSConfigs.InitializeCollections ? new List<AwsProductOptimization>() : null;
        private string _optimizedAmount;
        private string _potentialSavingsAmount;
        private string _productCode;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// Baseline service cost before optimizations (may be null for AWS-sourced predictions)
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// List of program and pathway categories this product is eligible for
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Optimizations. 
        /// <para>
        /// List of specific optimization recommendations for this product
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AwsProductOptimization> Optimizations
        {
            get { return this._optimizations; }
            set { this._optimizations = value; }
        }

        // Check to see if Optimizations property is set
        internal bool IsSetOptimizations()
        {
            return this._optimizations != null && (this._optimizations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizedAmount. 
        /// <para>
        /// Service cost after applying optimizations (may be null for AWS-sourced predictions)
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string OptimizedAmount
        {
            get { return this._optimizedAmount; }
            set { this._optimizedAmount = value; }
        }

        // Check to see if OptimizedAmount property is set
        internal bool IsSetOptimizedAmount()
        {
            return this._optimizedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property PotentialSavingsAmount. 
        /// <para>
        /// Service-specific cost reduction through optimizations (may be null for AWS-sourced
        /// predictions)
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PotentialSavingsAmount
        {
            get { return this._potentialSavingsAmount; }
            set { this._potentialSavingsAmount = value; }
        }

        // Check to see if PotentialSavingsAmount property is set
        internal bool IsSetPotentialSavingsAmount()
        {
            return this._potentialSavingsAmount != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// AWS Partner Central product identifier used for opportunity association
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Pricing Calculator service code (links to original calculator URL)
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}