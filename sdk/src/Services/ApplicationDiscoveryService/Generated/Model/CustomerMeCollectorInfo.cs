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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private int? _activeMeCollectors;
        private int? _denyListedMeCollectors;
        private int? _healthyMeCollectors;
        private int? _shutdownMeCollectors;
        private int? _totalMeCollectors;
        private int? _unhealthyMeCollectors;
        private int? _unknownMeCollectors;

        /// <summary>
        /// Gets and sets the property ActiveMeCollectors. 
        /// <para>
        ///  The number of active Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ActiveMeCollectors
        {
            get { return this._activeMeCollectors; }
            set { this._activeMeCollectors = value; }
        }

        // Check to see if ActiveMeCollectors property is set
        internal bool IsSetActiveMeCollectors()
        {
            return this._activeMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DenyListedMeCollectors. 
        /// <para>
        ///  The number of deny-listed Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DenyListedMeCollectors
        {
            get { return this._denyListedMeCollectors; }
            set { this._denyListedMeCollectors = value; }
        }

        // Check to see if DenyListedMeCollectors property is set
        internal bool IsSetDenyListedMeCollectors()
        {
            return this._denyListedMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyMeCollectors. 
        /// <para>
        ///  The number of healthy Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HealthyMeCollectors
        {
            get { return this._healthyMeCollectors; }
            set { this._healthyMeCollectors = value; }
        }

        // Check to see if HealthyMeCollectors property is set
        internal bool IsSetHealthyMeCollectors()
        {
            return this._healthyMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShutdownMeCollectors. 
        /// <para>
        ///  The number of Migration Evaluator collectors with <c>SHUTDOWN</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShutdownMeCollectors
        {
            get { return this._shutdownMeCollectors; }
            set { this._shutdownMeCollectors = value; }
        }

        // Check to see if ShutdownMeCollectors property is set
        internal bool IsSetShutdownMeCollectors()
        {
            return this._shutdownMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMeCollectors. 
        /// <para>
        ///  The total number of Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalMeCollectors
        {
            get { return this._totalMeCollectors; }
            set { this._totalMeCollectors = value; }
        }

        // Check to see if TotalMeCollectors property is set
        internal bool IsSetTotalMeCollectors()
        {
            return this._totalMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyMeCollectors. 
        /// <para>
        ///  The number of unhealthy Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnhealthyMeCollectors
        {
            get { return this._unhealthyMeCollectors; }
            set { this._unhealthyMeCollectors = value; }
        }

        // Check to see if UnhealthyMeCollectors property is set
        internal bool IsSetUnhealthyMeCollectors()
        {
            return this._unhealthyMeCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownMeCollectors. 
        /// <para>
        ///  The number of unknown Migration Evaluator collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnknownMeCollectors
        {
            get { return this._unknownMeCollectors; }
            set { this._unknownMeCollectors = value; }
        }

        // Check to see if UnknownMeCollectors property is set
        internal bool IsSetUnknownMeCollectors()
        {
            return this._unknownMeCollectors.HasValue; 
        }

    }
}