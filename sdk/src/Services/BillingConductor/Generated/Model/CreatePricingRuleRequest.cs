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
        private string _clientToken;
        private string _description;
        private double? _modifierPercentage;
        private string _name;
        private PricingRuleScope _scope;
        private string _service;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private PricingRuleType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The token that is needed to support idempotency. Idempotency isn't currently supported,
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
        [AWSProperty(Min=0, Max=1024)]
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
        ///  A percentage modifier applied on the public pricing rates. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The scope of pricing rule that indicates if it is globally applicable, or is service-specific.
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
        ///  If the <code>Scope</code> attribute is set to <code>SERVICE</code>, the attribute
        /// indicates which service the <code>PricingRule</code> is applicable for. 
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

    }
}