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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// A module that you can attach, as ListAvailableModules returns it. ListAvailableModules
    /// and GetAvailableModule never return how a module is implemented.
    /// </summary>
    public partial class AvailableModuleSummary
    {
        /// <summary>
        /// Gets and sets the property MarketplaceProductId. 
        /// <para>
        /// The Marketplace product the module is sold under. Present only when subscriptionType
        /// is MARKETPLACE.
        /// </para>
        /// </summary>
        public string MarketplaceProductId { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceProductId property is set.
        /// </summary>
        internal bool IsSetMarketplaceProductId() => this.MarketplaceProductId != null;

        /// <summary>
        /// Gets and sets the property ModuleArn. 
        /// <para>
        /// The module's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string ModuleArn { get; set; }

        /// <summary>
        /// Checks to see if the ModuleArn property is set.
        /// </summary>
        internal bool IsSetModuleArn() => this.ModuleArn != null;

        /// <summary>
        /// Gets and sets the property ModuleId. 
        /// <para>
        /// The module's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Checks to see if the ModuleId property is set.
        /// </summary>
        internal bool IsSetModuleId() => this.ModuleId != null;

        /// <summary>
        /// Gets and sets the property ModuleName. 
        /// <para>
        /// A label, not unique: modules can share a name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ModuleName { get; set; }

        /// <summary>
        /// Checks to see if the ModuleName property is set.
        /// </summary>
        internal bool IsSetModuleName() => this.ModuleName != null;

        /// <summary>
        /// Gets and sets the property SubscriptionStatus. 
        /// <para>
        /// Specifies whether your access to the module is current.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStatus property is set.
        /// </summary>
        internal bool IsSetSubscriptionStatus() => this.SubscriptionStatus != null;

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The type of access that you have to the module.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionType property is set.
        /// </summary>
        internal bool IsSetSubscriptionType() => this.SubscriptionType != null;
    }
}
