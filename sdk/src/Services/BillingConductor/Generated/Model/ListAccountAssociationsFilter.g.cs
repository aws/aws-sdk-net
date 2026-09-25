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
    /// The filter on the account ID of the linked account, or any of the following:
    /// 
    ///  
    /// <para>
    ///  <c>MONITORED</c>: linked accounts that are associated to billing groups.
    /// </para>
    ///  
    /// <para>
    ///  <c>UNMONITORED</c>: linked accounts that are not associated to billing groups.
    /// </para>
    ///  
    /// <para>
    ///  <c>Billing Group Arn</c>: linked accounts that are associated to the provided Billing
    /// Group Arn.
    /// </para>
    /// </summary>
    public partial class ListAccountAssociationsFilter
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID to filter on.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The list of Amazon Web Services IDs to retrieve their associated billing group for
        /// a given time range. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        ///  <c>MONITORED</c>: linked accounts that are associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNMONITORED</c>: linked accounts that are not associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <c>Billing Group Arn</c>: linked accounts that are associated to the provided Billing
        /// Group Arn.
        /// </para>
        /// </summary>
        public string Association { get; set; }

        /// <summary>
        /// Checks to see if the Association property is set.
        /// </summary>
        internal bool IsSetAssociation() => this.Association != null;
    }
}
