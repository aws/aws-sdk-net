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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents an action to modify commitments in a bill scenario.
    /// </summary>
    public partial class BillScenarioCommitmentModificationAction
    {
        /// <summary>
        /// Gets and sets the property AddReservedInstanceAction. 
        /// <para>
        ///  Action to add a Reserved Instance to the scenario. 
        /// </para>
        /// </summary>
        public AddReservedInstanceAction AddReservedInstanceAction { get; set; }

        /// <summary>
        /// Checks to see if the AddReservedInstanceAction property is set.
        /// </summary>
        internal bool IsSetAddReservedInstanceAction() => this.AddReservedInstanceAction != null;

        /// <summary>
        /// Gets and sets the property AddSavingsPlanAction. 
        /// <para>
        ///  Action to add a Savings Plan to the scenario. 
        /// </para>
        /// </summary>
        public AddSavingsPlanAction AddSavingsPlanAction { get; set; }

        /// <summary>
        /// Checks to see if the AddSavingsPlanAction property is set.
        /// </summary>
        internal bool IsSetAddSavingsPlanAction() => this.AddSavingsPlanAction != null;

        /// <summary>
        /// Gets and sets the property NegateReservedInstanceAction. 
        /// <para>
        ///  Action to remove a Reserved Instance from the scenario. 
        /// </para>
        /// </summary>
        public NegateReservedInstanceAction NegateReservedInstanceAction { get; set; }

        /// <summary>
        /// Checks to see if the NegateReservedInstanceAction property is set.
        /// </summary>
        internal bool IsSetNegateReservedInstanceAction() => this.NegateReservedInstanceAction != null;

        /// <summary>
        /// Gets and sets the property NegateSavingsPlanAction. 
        /// <para>
        ///  Action to remove a Savings Plan from the scenario. 
        /// </para>
        /// </summary>
        public NegateSavingsPlanAction NegateSavingsPlanAction { get; set; }

        /// <summary>
        /// Checks to see if the NegateSavingsPlanAction property is set.
        /// </summary>
        internal bool IsSetNegateSavingsPlanAction() => this.NegateSavingsPlanAction != null;
    }
}
