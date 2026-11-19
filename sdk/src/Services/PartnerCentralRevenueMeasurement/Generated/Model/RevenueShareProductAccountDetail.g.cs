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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// A typed account list returned by GetMarketplaceRevenueShare, with its count and full
    /// list of IDs.
    /// </summary>
    public partial class RevenueShareProductAccountDetail
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The full list of AWS account identifiers of this type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The type of account list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RevenueShareProductAccountType AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of accounts of this type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;
    }
}
