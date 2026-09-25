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
    /// Container for the parameters to the CreateBillingGroup operation. Creates a billing
    /// group that resembles a consolidated billing family that Amazon Web Services charges,
    /// based off of the predefined pricing plan computation.
    /// </summary>
    public partial class CreateBillingGroupRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property AccountGrouping. 
        /// <para>
        ///  The set of accounts that will be under the billing group. The set of accounts resemble
        /// the linked accounts in a consolidated billing family. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountGrouping AccountGrouping { get; set; }

        /// <summary>
        /// Checks to see if the AccountGrouping property is set.
        /// </summary>
        internal bool IsSetAccountGrouping() => this.AccountGrouping != null;

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
        /// Gets and sets the property ComputationPreference. 
        /// <para>
        ///  The preferences and settings that will be used to compute the Amazon Web Services
        /// charges for a billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputationPreference ComputationPreference { get; set; }

        /// <summary>
        /// Checks to see if the ComputationPreference property is set.
        /// </summary>
        internal bool IsSetComputationPreference() => this.ComputationPreference != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The billing group name. The names must be unique. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrimaryAccountId. 
        /// <para>
        ///  The account ID that serves as the main account in a billing group. 
        /// </para>
        /// </summary>
        public string PrimaryAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountId property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountId() => this.PrimaryAccountId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a billing group.
        /// This feature isn't available during the beta. 
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
    }
}
