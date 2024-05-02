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
    /// Contains information about a hierarchy structure.
    /// </summary>
    public partial class HierarchyStructure
    {
        private HierarchyLevel _levelFive;
        private HierarchyLevel _levelFour;
        private HierarchyLevel _levelOne;
        private HierarchyLevel _levelThree;
        private HierarchyLevel _levelTwo;

        /// <summary>
        /// Gets and sets the property LevelFive. 
        /// <para>
        /// Information about level five.
        /// </para>
        /// </summary>
        public HierarchyLevel LevelFive
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
        /// Information about level four.
        /// </para>
        /// </summary>
        public HierarchyLevel LevelFour
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
        /// Information about level one.
        /// </para>
        /// </summary>
        public HierarchyLevel LevelOne
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
        /// Information about level three.
        /// </para>
        /// </summary>
        public HierarchyLevel LevelThree
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
        /// Information about level two.
        /// </para>
        /// </summary>
        public HierarchyLevel LevelTwo
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