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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Reserved. If you need to sustain traffic greater than the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-gateways">documented
    /// limits</a>, contact Amazon Web Services Support.
    /// </summary>
    public partial class ProvisionedBandwidth
    {
        /// <summary>
        /// Gets and sets the property ProvisionTime. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public DateTime? ProvisionTime { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionTime property is set.
        /// </summary>
        internal bool IsSetProvisionTime() => this.ProvisionTime.HasValue;

        /// <summary>
        /// Gets and sets the property Provisioned. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Provisioned { get; set; }

        /// <summary>
        /// Checks to see if the Provisioned property is set.
        /// </summary>
        internal bool IsSetProvisioned() => this.Provisioned != null;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property Requested. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Requested { get; set; }

        /// <summary>
        /// Checks to see if the Requested property is set.
        /// </summary>
        internal bool IsSetRequested() => this.Requested != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
