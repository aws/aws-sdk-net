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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that describes how email sent during the predictive inbox placement test
    /// was handled by a certain email provider.
    /// </summary>
    public partial class IspPlacement
    {
        /// <summary>
        /// Gets and sets the property IspName. 
        /// <para>
        /// The name of the email provider that the inbox placement data applies to.
        /// </para>
        /// </summary>
        public string IspName { get; set; }

        /// <summary>
        /// Checks to see if the IspName property is set.
        /// </summary>
        internal bool IsSetIspName() => this.IspName != null;

        /// <summary>
        /// Gets and sets the property PlacementStatistics. 
        /// <para>
        /// An object that contains inbox placement metrics for a specific email provider.
        /// </para>
        /// </summary>
        public PlacementStatistics PlacementStatistics { get; set; }

        /// <summary>
        /// Checks to see if the PlacementStatistics property is set.
        /// </summary>
        internal bool IsSetPlacementStatistics() => this.PlacementStatistics != null;
    }
}
