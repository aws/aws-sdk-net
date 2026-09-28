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
    /// Container for the parameters to the BatchDisassociateResourcesFromCustomLineItem operation.
    /// Disassociates a batch of resources from a percentage custom line item.
    /// </summary>
    public partial class BatchDisassociateResourcesFromCustomLineItemRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property BillingPeriodRange.
        /// </summary>
        public CustomLineItemBillingPeriodRange BillingPeriodRange { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriodRange property is set.
        /// </summary>
        internal bool IsSetBillingPeriodRange() => this.BillingPeriodRange != null;

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        ///  A list containing the ARNs of resources to be disassociated. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public List<string> ResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceArns property is set.
        /// </summary>
        internal bool IsSetResourceArns() => this.ResourceArns != null && (this.ResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        ///  A percentage custom line item ARN to disassociate the resources from. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
