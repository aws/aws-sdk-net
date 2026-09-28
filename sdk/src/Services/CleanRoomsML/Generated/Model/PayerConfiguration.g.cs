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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Specifies which member accounts are responsible for paying for compute and synthetic
    /// data generation costs in a Clean Rooms ML collaboration.
    /// </summary>
    public partial class PayerConfiguration
    {
        /// <summary>
        /// Gets and sets the property ComputePayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ComputePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ComputePayerAccountId property is set.
        /// </summary>
        internal bool IsSetComputePayerAccountId() => this.ComputePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property SyntheticDataPayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying synthetic data generation
        /// costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SyntheticDataPayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SyntheticDataPayerAccountId property is set.
        /// </summary>
        internal bool IsSetSyntheticDataPayerAccountId() => this.SyntheticDataPayerAccountId != null;
    }
}
