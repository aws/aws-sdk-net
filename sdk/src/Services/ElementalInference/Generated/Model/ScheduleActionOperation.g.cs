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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Holds one typed configuration change that a schedule action makes to a feed. Each
    /// operation must contain exactly one property.
    /// </summary>
    public partial class ScheduleActionOperation
    {
        /// <summary>
        /// Gets and sets the property RemoveClippingDataSourceConfiguration. 
        /// <para>
        /// The operation type that removes the game from an event clipping output.
        /// </para>
        /// </summary>
        public RemoveClippingDataSourceConfiguration RemoveClippingDataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveClippingDataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveClippingDataSourceConfiguration() => this.RemoveClippingDataSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdateClippingDataSourceConfiguration. 
        /// <para>
        /// The operation type that attaches a game to an event clipping output.
        /// </para>
        /// </summary>
        public UpdateClippingDataSourceConfiguration UpdateClippingDataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UpdateClippingDataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetUpdateClippingDataSourceConfiguration() => this.UpdateClippingDataSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdateOutputStatus. 
        /// <para>
        /// The operation type that enables or disables an output.
        /// </para>
        /// </summary>
        public UpdateOutputStatus UpdateOutputStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateOutputStatus property is set.
        /// </summary>
        internal bool IsSetUpdateOutputStatus() => this.UpdateOutputStatus != null;
    }
}
