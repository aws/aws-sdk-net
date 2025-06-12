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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of the charge details that are associated with a percentage custom
    /// line item.
    /// </summary>
    public partial class CustomLineItemPercentageChargeDetails
    {
        private List<string> _associatedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _percentageValue;

        /// <summary>
        /// Gets and sets the property AssociatedValues. 
        /// <para>
        /// A list of resource ARNs to associate to the percentage custom line item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> AssociatedValues
        {
            get { return this._associatedValues; }
            set { this._associatedValues = value; }
        }

        // Check to see if AssociatedValues property is set
        internal bool IsSetAssociatedValues()
        {
            return this._associatedValues != null && (this._associatedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PercentageValue. 
        /// <para>
        /// The custom line item's percentage value. This will be multiplied against the combined
        /// value of its associated resources to determine its charge value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public double? PercentageValue
        {
            get { return this._percentageValue; }
            set { this._percentageValue = value; }
        }

        // Check to see if PercentageValue property is set
        internal bool IsSetPercentageValue()
        {
            return this._percentageValue.HasValue; 
        }

    }
}