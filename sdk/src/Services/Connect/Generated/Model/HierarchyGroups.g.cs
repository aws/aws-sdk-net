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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the agent hierarchy. Hierarchies can be configured with up to five
    /// levels.
    /// </summary>
    public partial class HierarchyGroups
    {
        /// <summary>
        /// Gets and sets the property Level1. 
        /// <para>
        /// The group at level one of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level1 { get; set; }

        /// <summary>
        /// Checks to see if the Level1 property is set.
        /// </summary>
        internal bool IsSetLevel1() => this.Level1 != null;

        /// <summary>
        /// Gets and sets the property Level2. 
        /// <para>
        /// The group at level two of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level2 { get; set; }

        /// <summary>
        /// Checks to see if the Level2 property is set.
        /// </summary>
        internal bool IsSetLevel2() => this.Level2 != null;

        /// <summary>
        /// Gets and sets the property Level3. 
        /// <para>
        /// The group at level three of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level3 { get; set; }

        /// <summary>
        /// Checks to see if the Level3 property is set.
        /// </summary>
        internal bool IsSetLevel3() => this.Level3 != null;

        /// <summary>
        /// Gets and sets the property Level4. 
        /// <para>
        /// The group at level four of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level4 { get; set; }

        /// <summary>
        /// Checks to see if the Level4 property is set.
        /// </summary>
        internal bool IsSetLevel4() => this.Level4 != null;

        /// <summary>
        /// Gets and sets the property Level5. 
        /// <para>
        /// The group at level five of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level5 { get; set; }

        /// <summary>
        /// Checks to see if the Level5 property is set.
        /// </summary>
        internal bool IsSetLevel5() => this.Level5 != null;
    }
}
