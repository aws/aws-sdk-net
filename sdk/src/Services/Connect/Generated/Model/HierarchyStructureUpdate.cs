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
    /// Contains information about the level hierarchy to update.
    /// </summary>
    public partial class HierarchyStructureUpdate
    {
        private HierarchyLevelUpdate _levelFive;
        private HierarchyLevelUpdate _levelFour;
        private HierarchyLevelUpdate _levelOne;
        private HierarchyLevelUpdate _levelThree;
        private HierarchyLevelUpdate _levelTwo;

        /// <summary>
        /// Gets and sets the property LevelFive. 
        /// <para>
        /// The update for level five.
        /// </para>
        /// </summary>
        public HierarchyLevelUpdate LevelFive
        {
            get { return this._levelFive; }
            set { this._levelFive = value; }
        }

        // Check to see if LevelFive property is set
        internal bool IsSetLevelFive()
        {
            return this._levelFive != null;
        }

        /// <summary>
        /// Gets and sets the property LevelFour. 
        /// <para>
        /// The update for level four.
        /// </para>
        /// </summary>
        public HierarchyLevelUpdate LevelFour
        {
            get { return this._levelFour; }
            set { this._levelFour = value; }
        }

        // Check to see if LevelFour property is set
        internal bool IsSetLevelFour()
        {
            return this._levelFour != null;
        }

        /// <summary>
        /// Gets and sets the property LevelOne. 
        /// <para>
        /// The update for level one.
        /// </para>
        /// </summary>
        public HierarchyLevelUpdate LevelOne
        {
            get { return this._levelOne; }
            set { this._levelOne = value; }
        }

        // Check to see if LevelOne property is set
        internal bool IsSetLevelOne()
        {
            return this._levelOne != null;
        }

        /// <summary>
        /// Gets and sets the property LevelThree. 
        /// <para>
        /// The update for level three.
        /// </para>
        /// </summary>
        public HierarchyLevelUpdate LevelThree
        {
            get { return this._levelThree; }
            set { this._levelThree = value; }
        }

        // Check to see if LevelThree property is set
        internal bool IsSetLevelThree()
        {
            return this._levelThree != null;
        }

        /// <summary>
        /// Gets and sets the property LevelTwo. 
        /// <para>
        /// The update for level two.
        /// </para>
        /// </summary>
        public HierarchyLevelUpdate LevelTwo
        {
            get { return this._levelTwo; }
            set { this._levelTwo = value; }
        }

        // Check to see if LevelTwo property is set
        internal bool IsSetLevelTwo()
        {
            return this._levelTwo != null;
        }

    }
}