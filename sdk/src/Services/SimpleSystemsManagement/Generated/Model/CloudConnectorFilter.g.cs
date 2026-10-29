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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A filter for listing cloud connectors.
    /// </summary>
    public partial class CloudConnectorFilter
    {
        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The name of the filter key.
        /// </para>
        /// </summary>
        public CloudConnectorFilterKey FilterKey { get; set; }

        /// <summary>
        /// Checks to see if the FilterKey property is set.
        /// </summary>
        internal bool IsSetFilterKey() => this.FilterKey != null;

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The filter values. Valid values for each filter key are as follows:
        /// </para>
        ///  <dl> <dt>SubscriptionId</dt> <dd> 
        /// <para>
        /// The Azure subscription ID to filter by. To return only tenant-level connectors, specify
        /// <c>NONE</c>.
        /// </para>
        ///  </dd> <dt>TenantId</dt> <dd> 
        /// <para>
        /// The Azure tenant ID to filter by. Filters the results to connectors that target the
        /// specified tenant.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> FilterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterValues property is set.
        /// </summary>
        internal bool IsSetFilterValues() => this.FilterValues != null && (this.FilterValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
