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
    /// A list of conditions which would be applied together with an <c>AND</c> condition.
    /// </summary>
    public partial class CommonAttributeAndCondition
    {
        private HierarchyGroupCondition _hierarchyGroupCondition;
        private List<TagCondition> _tagConditions = AWSConfigs.InitializeCollections ? new List<TagCondition>() : null;

        /// <summary>
        /// Gets and sets the property HierarchyGroupCondition.
        /// </summary>
        public HierarchyGroupCondition HierarchyGroupCondition
        {
            get { return this._hierarchyGroupCondition; }
            set { this._hierarchyGroupCondition = value; }
        }

        // Check to see if HierarchyGroupCondition property is set
        internal bool IsSetHierarchyGroupCondition()
        {
            return this._hierarchyGroupCondition != null;
        }

        /// <summary>
        /// Gets and sets the property TagConditions. 
        /// <para>
        /// A leaf node condition which can be used to specify a tag condition.
        /// </para>
        /// </summary>
        public List<TagCondition> TagConditions
        {
            get { return this._tagConditions; }
            set { this._tagConditions = value; }
        }

        // Check to see if TagConditions property is set
        internal bool IsSetTagConditions()
        {
            return this._tagConditions != null && (this._tagConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}