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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// The inventory data for installed Migration Evaluator collectors.
    /// </summary>
    public partial class CustomerMeCollectorInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveMeCollectors. 
        /// <para>
        ///  The number of active Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ActiveMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the ActiveMeCollectors property is set.
        /// </summary>
        internal bool IsSetActiveMeCollectors() => this.ActiveMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property DenyListedMeCollectors. 
        /// <para>
        ///  The number of deny-listed Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DenyListedMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the DenyListedMeCollectors property is set.
        /// </summary>
        internal bool IsSetDenyListedMeCollectors() => this.DenyListedMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyMeCollectors. 
        /// <para>
        ///  The number of healthy Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HealthyMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the HealthyMeCollectors property is set.
        /// </summary>
        internal bool IsSetHealthyMeCollectors() => this.HealthyMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property ShutdownMeCollectors. 
        /// <para>
        ///  The number of Migration Evaluator collectors with <c>SHUTDOWN</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ShutdownMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the ShutdownMeCollectors property is set.
        /// </summary>
        internal bool IsSetShutdownMeCollectors() => this.ShutdownMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMeCollectors. 
        /// <para>
        ///  The total number of Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the TotalMeCollectors property is set.
        /// </summary>
        internal bool IsSetTotalMeCollectors() => this.TotalMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyMeCollectors. 
        /// <para>
        ///  The number of unhealthy Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnhealthyMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyMeCollectors property is set.
        /// </summary>
        internal bool IsSetUnhealthyMeCollectors() => this.UnhealthyMeCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownMeCollectors. 
        /// <para>
        ///  The number of unknown Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnknownMeCollectors { get; set; }

        /// <summary>
        /// Checks to see if the UnknownMeCollectors property is set.
        /// </summary>
        internal bool IsSetUnknownMeCollectors() => this.UnknownMeCollectors.HasValue;
    }
}
