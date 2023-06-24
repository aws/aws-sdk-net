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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePricingRule operation.
    /// Creates a pricing rule can be associated to a pricing plan, or a set of pricing plans.
    /// </summary>
    public partial class CreatePricingRuleRequest : AmazonBillingConductorRequest
    {
        private string _billingEntity;
        private string _clientToken;
        private string _description;
        private double? _modifierPercentage;
        private string _name;
        private string _operation;
        private PricingRuleScope _scope;
        private string _service;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CreateTieringInput _tiering;
        private PricingRuleType _type;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property BillingEntity. 
        /// <para>
        ///  The seller of services provided by Amazon Web Services, their affiliates, or third-party
        /// providers selling services via Amazon Web Services Marketplace. 
        /// </para>
        /// </summary>
        public string BillingEntity
        {
            get { return this._billingEntity; }
            set { this._billingEntity = value; }
        }

        // Check to see if BillingEntity property is set
        internal bool IsSetBillingEntity()
        {
            return this._billingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The token that's needed to support idempotency. Idempotency isn't currently supported,
        /// but will be implemented in a future update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The pricing rule description. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ModifierPercentage. 
        /// <para>
        ///  A percentage modifier that's applied on the public pricing rates. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double ModifierPercentage
        {
            get { return this._modifierPercentage.GetValueOrDefault(); }
            set { this._modifierPercentage = value; }
        }

        // Check to see if ModifierPercentage property is set
        internal bool IsSetModifierPercentage()
        {
            return this._modifierPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The pricing rule name. The names must be unique to each pricing rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  Operation is the specific Amazon Web Services action covered by this line item. This
        /// describes the specific usage of the line item.
        /// </para>
        ///  
        /// <para>
        ///  If the <code>Scope</code> attribute is set to <code>SKU</code>, this attribute indicates
        /// which operation the <code>PricingRule</code> is modifying. For example, a value of
        /// <code>RunInstances:0202</code> indicates the operation of running an Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The scope of pricing rule that indicates if it's globally applicable, or it's service-specific.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingRuleScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        ///  If the <code>Scope</code> attribute is set to <code>SERVICE</code> or <code>SKU</code>,
        /// the attribute indicates which service the <code>PricingRule</code> is applicable for.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a pricing rule.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tiering. 
        /// <para>
        ///  The set of tiering configurations for the pricing rule. 
        /// </para>
        /// </summary>
        public CreateTieringInput Tiering
        {
            get { return this._tiering; }
            set { this._tiering = value; }
        }

        // Check to see if Tiering property is set
        internal bool IsSetTiering()
        {
            return this._tiering != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of pricing rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  Usage type is the unit that each service uses to measure the usage of a specific
        /// type of resource.
        /// </para>
        ///  
        /// <para>
        /// If the <code>Scope</code> attribute is set to <code>SKU</code>, this attribute indicates
        /// which usage type the <code>PricingRule</code> is modifying. For example, <code>USW2-BoxUsage:m2.2xlarge</code>
        /// describes an<code> M2 High Memory Double Extra Large</code> instance in the US West
        /// (Oregon) Region. <pre><code>&lt;/p&gt; </code></pre>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}