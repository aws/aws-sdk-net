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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Constraints that control how you can configure a rate card.
    /// </summary>
    public partial class Constraints
    {
        /// <summary>
        /// Gets and sets the property MultipleDimensionSelection. 
        /// <para>
        /// Specifies whether you can select multiple dimensions. This field has one of the following
        /// values:
        /// </para>
        ///  <dl> <dt>Allowed</dt> <dd> 
        /// <para>
        /// You can select more than one dimension.
        /// </para>
        ///  </dd> <dt>Disallowed</dt> <dd> 
        /// <para>
        /// You can select only one dimension.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public RateCardConstraintType MultipleDimensionSelection { get; set; }

        /// <summary>
        /// Checks to see if the MultipleDimensionSelection property is set.
        /// </summary>
        internal bool IsSetMultipleDimensionSelection() => this.MultipleDimensionSelection != null;

        /// <summary>
        /// Gets and sets the property QuantityConfiguration. 
        /// <para>
        /// Specifies whether you can configure quantities. This field has one of the following
        /// values:
        /// </para>
        ///  <dl> <dt>Allowed</dt> <dd> 
        /// <para>
        /// You can set the quantity of each dimension.
        /// </para>
        ///  </dd> <dt>Disallowed</dt> <dd> 
        /// <para>
        /// You cannot change the quantity.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public RateCardConstraintType QuantityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuantityConfiguration property is set.
        /// </summary>
        internal bool IsSetQuantityConfiguration() => this.QuantityConfiguration != null;
    }
}
