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
    /// Container for the parameters to the UpdatePricingRule operation. Updates an existing
    /// pricing rule.
    /// </summary>
    public partial class UpdatePricingRuleRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pricing rule to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The new description for the pricing rule. 
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
        ///  The new modifier to show pricing plan rates as a percentage. Your entry will be rounded
        /// to the nearest 2 decimal places. 
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
        ///  The new name of the pricing rule. The name must be unique to each pricing rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tiering. 
        /// <para>
        ///  The set of tiering configurations for the pricing rule. 
        /// </para>
        /// </summary>
        public UpdateTieringInput Tiering { get; set; }

        /// <summary>
        /// Checks to see if the Tiering property is set.
        /// </summary>
        internal bool IsSetTiering() => this.Tiering != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The new pricing rule type. 
        /// </para>
        /// </summary>
        public PricingRuleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
