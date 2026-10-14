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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Configuration for resold enterprise support plans.
    /// </summary>
    public partial class ResoldEnterprise
    {
        /// <summary>
        /// Gets and sets the property ChargeAccountId. 
        /// <para>
        /// The AWS account ID to charge for the support plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ChargeAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ChargeAccountId property is set.
        /// </summary>
        internal bool IsSetChargeAccountId() => this.ChargeAccountId != null;

        /// <summary>
        /// Gets and sets the property Coverage. 
        /// <para>
        /// The coverage level for resold enterprise support.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Coverage Coverage { get; set; }

        /// <summary>
        /// Checks to see if the Coverage property is set.
        /// </summary>
        internal bool IsSetCoverage() => this.Coverage != null;

        /// <summary>
        /// Gets and sets the property TamLocation. 
        /// <para>
        /// The location of the Technical Account Manager (TAM).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TamLocation { get; set; }

        /// <summary>
        /// Checks to see if the TamLocation property is set.
        /// </summary>
        internal bool IsSetTamLocation() => this.TamLocation != null;
    }
}
