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
    /// Information about the agent hierarchy. Hierarchies can be configured with up to five
    /// levels.
    /// </summary>
    public partial class HierarchyGroups
    {
        private AgentHierarchyGroup _level1;
        private AgentHierarchyGroup _level2;
        private AgentHierarchyGroup _level3;
        private AgentHierarchyGroup _level4;
        private AgentHierarchyGroup _level5;

        /// <summary>
        /// Gets and sets the property Level1. 
        /// <para>
        /// The group at level one of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level1
        {
            get { return this._level1; }
            set { this._level1 = value; }
        }

        // Check to see if Level1 property is set
        internal bool IsSetLevel1()
        {
            return this._level1 != null;
        }

        /// <summary>
        /// Gets and sets the property Level2. 
        /// <para>
        /// The group at level two of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level2
        {
            get { return this._level2; }
            set { this._level2 = value; }
        }

        // Check to see if Level2 property is set
        internal bool IsSetLevel2()
        {
            return this._level2 != null;
        }

        /// <summary>
        /// Gets and sets the property Level3. 
        /// <para>
        /// The group at level three of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level3
        {
            get { return this._level3; }
            set { this._level3 = value; }
        }

        // Check to see if Level3 property is set
        internal bool IsSetLevel3()
        {
            return this._level3 != null;
        }

        /// <summary>
        /// Gets and sets the property Level4. 
        /// <para>
        /// The group at level four of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level4
        {
            get { return this._level4; }
            set { this._level4 = value; }
        }

        // Check to see if Level4 property is set
        internal bool IsSetLevel4()
        {
            return this._level4 != null;
        }

        /// <summary>
        /// Gets and sets the property Level5. 
        /// <para>
        /// The group at level five of the agent hierarchy.
        /// </para>
        /// </summary>
        public AgentHierarchyGroup Level5
        {
            get { return this._level5; }
            set { this._level5 = value; }
        }

        // Check to see if Level5 property is set
        internal bool IsSetLevel5()
        {
            return this._level5 != null;
        }

    }
}