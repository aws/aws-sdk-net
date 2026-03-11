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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The privacy budget information that controls access to Clean Rooms ML input channels.
    /// </summary>
    public partial class PrivacyBudgets
    {
        private List<AccessBudget> _accessBudgets = AWSConfigs.InitializeCollections ? new List<AccessBudget>() : null;

        /// <summary>
        /// Gets and sets the property AccessBudgets. 
        /// <para>
        /// A list of access budgets that apply to resources associated with this Clean Rooms
        /// ML input channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<AccessBudget> AccessBudgets
        {
            get { return this._accessBudgets; }
            set { this._accessBudgets = value; }
        }

        // Check to see if AccessBudgets property is set
        internal bool IsSetAccessBudgets()
        {
            return this._accessBudgets != null && (this._accessBudgets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}