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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// A collection of additional state information, such as domain and clock configuration.
    /// </summary>
    public partial class LiveSimulationState
    {
        private List<SimulationClock> _clocks = new List<SimulationClock>();
        private List<Domain> _domains = new List<Domain>();

        /// <summary>
        /// Gets and sets the property Clocks. 
        /// <para>
        /// A list of simulation clocks.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, a simulation has only one clock.
        /// </para>
        ///  </note>
        /// </summary>
        public List<SimulationClock> Clocks
        {
            get { return this._clocks; }
            set { this._clocks = value; }
        }

        // Check to see if Clocks property is set
        internal bool IsSetClocks()
        {
            return this._clocks != null && this._clocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// A list of domains for the simulation. For more information about domains, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/what-is_key-concepts.html">Key
        /// concepts</a> in the <i>Amazon Web Services SimSpace Weaver User Guide</i>.
        /// </para>
        /// </summary>
        public List<Domain> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && this._domains.Count > 0; 
        }

    }
}