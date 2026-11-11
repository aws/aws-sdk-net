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
    /// Information about the levels in the hierarchy group.
    /// </summary>
    public partial class HierarchyPathReference
    {
        /// <summary>
        /// Gets and sets the property LevelFive. 
        /// <para>
        /// Information about level five.
        /// </para>
        /// </summary>
        public HierarchyGroupSummaryReference LevelFive { get; set; }

        /// <summary>
        /// Checks to see if the LevelFive property is set.
        /// </summary>
        internal bool IsSetLevelFive() => this.LevelFive != null;

        /// <summary>
        /// Gets and sets the property LevelFour. 
        /// <para>
        /// Information about level four.
        /// </para>
        /// </summary>
        public HierarchyGroupSummaryReference LevelFour { get; set; }

        /// <summary>
        /// Checks to see if the LevelFour property is set.
        /// </summary>
        internal bool IsSetLevelFour() => this.LevelFour != null;

        /// <summary>
        /// Gets and sets the property LevelOne. 
        /// <para>
        /// Information about level one.
        /// </para>
        /// </summary>
        public HierarchyGroupSummaryReference LevelOne { get; set; }

        /// <summary>
        /// Checks to see if the LevelOne property is set.
        /// </summary>
        internal bool IsSetLevelOne() => this.LevelOne != null;

        /// <summary>
        /// Gets and sets the property LevelThree. 
        /// <para>
        /// Information about level three.
        /// </para>
        /// </summary>
        public HierarchyGroupSummaryReference LevelThree { get; set; }

        /// <summary>
        /// Checks to see if the LevelThree property is set.
        /// </summary>
        internal bool IsSetLevelThree() => this.LevelThree != null;

        /// <summary>
        /// Gets and sets the property LevelTwo. 
        /// <para>
        /// Information about level two.
        /// </para>
        /// </summary>
        public HierarchyGroupSummaryReference LevelTwo { get; set; }

        /// <summary>
        /// Checks to see if the LevelTwo property is set.
        /// </summary>
        internal bool IsSetLevelTwo() => this.LevelTwo != null;
    }
}
