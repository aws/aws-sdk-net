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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The filter fields for the express private offer configuration entity.
    /// </summary>
    public partial class ExpressPrivateOfferConfigurationFilters
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// You can filter on the <c>EntityId</c> of an express private offer configuration.
        /// </para>
        /// </summary>
        public ExpressPrivateOfferConfigurationEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// You can filter on the <c>ProductId</c> of an express private offer configuration.
        /// </para>
        /// </summary>
        public ExpressPrivateOfferConfigurationProductIdFilter ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the express private offer configuration to filter on. Valid values are
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – The configuration is active and you can use it to generate offers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> – The configuration is deprecated or deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExpressPrivateOfferConfigurationStateFilter State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
