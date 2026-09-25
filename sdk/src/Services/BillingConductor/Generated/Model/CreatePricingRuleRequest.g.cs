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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePricingRule operation. Creates a pricing
    /// rule can be associated to a pricing plan, or a set of pricing plans.
    /// </summary>
    public partial class CreatePricingRuleRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property BillingEntity. 
        /// <para>
        ///  The seller of services provided by Amazon Web Services, their affiliates, or third-party
        /// providers selling services via Amazon Web Services Marketplace. 
        /// </para>
        /// </summary>
        public string BillingEntity { get; set; }

        /// <summary>
        /// Checks to see if the BillingEntity property is set.
        /// </summary>
        internal bool IsSetBillingEntity() => this.BillingEntity != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you specify to ensure idempotency of the
        /// request. Idempotency ensures that an API request completes no more than one time.
        /// With an idempotent request, if the original request completes successfully, any subsequent
        /// retries complete successfully without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The pricing rule description. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ModifierPercentage. 
        /// <para>
        /// A percentage modifier that's applied on the public pricing rates. Your entry will
        /// be rounded to the nearest 2 decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? ModifierPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ModifierPercentage property is set.
        /// </summary>
        internal bool IsSetModifierPercentage() => this.ModifierPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The pricing rule name. The names must be unique to each pricing rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  Operation is the specific Amazon Web Services action covered by this line item. This
        /// describes the specific usage of the line item.
        /// </para>
        ///  
        /// <para>
        ///  If the <c>Scope</c> attribute is set to <c>SKU</c>, this attribute indicates which
        /// operation the <c>PricingRule</c> is modifying. For example, a value of <c>RunInstances:0202</c>
        /// indicates the operation of running an Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The scope of pricing rule that indicates if it's globally applicable, or it's service-specific.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingRuleScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        ///  If the <c>Scope</c> attribute is set to <c>SERVICE</c> or <c>SKU</c>, the attribute
        /// indicates which service the <c>PricingRule</c> is applicable for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a pricing rule.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tiering. 
        /// <para>
        ///  The set of tiering configurations for the pricing rule. 
        /// </para>
        /// </summary>
        public CreateTieringInput Tiering { get; set; }

        /// <summary>
        /// Checks to see if the Tiering property is set.
        /// </summary>
        internal bool IsSetTiering() => this.Tiering != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of pricing rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingRuleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  Usage type is the unit that each service uses to measure the usage of a specific
        /// type of resource.
        /// </para>
        ///  
        /// <para>
        /// If the <c>Scope</c> attribute is set to <c>SKU</c>, this attribute indicates which
        /// usage type the <c>PricingRule</c> is modifying. For example, <c>USW2-BoxUsage:m2.2xlarge</c>
        /// describes an<c> M2 High Memory Double Extra Large</c> instance in the US West (Oregon)
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
