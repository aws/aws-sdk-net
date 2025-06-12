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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A structure that defines search criteria for contacts using agent hierarchy group
    /// levels. For more information about agent hierarchies, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/agent-hierarchy.html">Set
    /// Up Agent Hierarchies</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </summary>
    public partial class AgentHierarchyGroups
    {
        private List<string> _l1Ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _l2Ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _l3Ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _l4Ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _l5Ids = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property L1Ids. 
        /// <para>
        /// The identifiers for level 1 hierarchy groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> L1Ids
        {
            get { return this._l1Ids; }
            set { this._l1Ids = value; }
        }

        // Check to see if L1Ids property is set
        internal bool IsSetL1Ids()
        {
            return this._l1Ids != null && (this._l1Ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property L2Ids. 
        /// <para>
        /// The identifiers for level 2 hierarchy groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> L2Ids
        {
            get { return this._l2Ids; }
            set { this._l2Ids = value; }
        }

        // Check to see if L2Ids property is set
        internal bool IsSetL2Ids()
        {
            return this._l2Ids != null && (this._l2Ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property L3Ids. 
        /// <para>
        /// The identifiers for level 3 hierarchy groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> L3Ids
        {
            get { return this._l3Ids; }
            set { this._l3Ids = value; }
        }

        // Check to see if L3Ids property is set
        internal bool IsSetL3Ids()
        {
            return this._l3Ids != null && (this._l3Ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property L4Ids. 
        /// <para>
        /// The identifiers for level 4 hierarchy groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> L4Ids
        {
            get { return this._l4Ids; }
            set { this._l4Ids = value; }
        }

        // Check to see if L4Ids property is set
        internal bool IsSetL4Ids()
        {
            return this._l4Ids != null && (this._l4Ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property L5Ids. 
        /// <para>
        /// The identifiers for level 5 hierarchy groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> L5Ids
        {
            get { return this._l5Ids; }
            set { this._l5Ids = value; }
        }

        // Check to see if L5Ids property is set
        internal bool IsSetL5Ids()
        {
            return this._l5Ids != null && (this._l5Ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}