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
    /// Configuration for different types of support plans.
    /// </summary>
    public partial class SupportPlan
    {
        /// <summary>
        /// Gets and sets the property PartnerLedSupport. 
        /// <para>
        /// Configuration for partner-led support plans.
        /// </para>
        /// </summary>
        public PartnerLedSupport PartnerLedSupport { get; set; }

        /// <summary>
        /// Checks to see if the PartnerLedSupport property is set.
        /// </summary>
        internal bool IsSetPartnerLedSupport() => this.PartnerLedSupport != null;

        /// <summary>
        /// Gets and sets the property ResoldEnterprise. 
        /// <para>
        /// Configuration for resold enterprise support plans.
        /// </para>
        /// </summary>
        public ResoldEnterprise ResoldEnterprise { get; set; }

        /// <summary>
        /// Checks to see if the ResoldEnterprise property is set.
        /// </summary>
        internal bool IsSetResoldEnterprise() => this.ResoldEnterprise != null;

        /// <summary>
        /// Gets and sets the property ResoldUnifiedOperations. 
        /// <para>
        /// Configuration for resold unified operations support plans.
        /// </para>
        /// </summary>
        public ResoldUnifiedOperations ResoldUnifiedOperations { get; set; }

        /// <summary>
        /// Checks to see if the ResoldUnifiedOperations property is set.
        /// </summary>
        internal bool IsSetResoldUnifiedOperations() => this.ResoldUnifiedOperations != null;
    }
}
