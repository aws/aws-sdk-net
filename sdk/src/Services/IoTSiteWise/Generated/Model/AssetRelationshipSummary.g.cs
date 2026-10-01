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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains information about assets that are related to one another.
    /// </summary>
    public partial class AssetRelationshipSummary
    {
        /// <summary>
        /// Gets and sets the property HierarchyInfo. 
        /// <para>
        /// The assets that are related through an asset hierarchy.
        /// </para>
        ///  
        /// <para>
        /// This object is present if the <c>relationshipType</c> is <c>HIERARCHY</c>.
        /// </para>
        /// </summary>
        public AssetHierarchyInfo HierarchyInfo { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyInfo property is set.
        /// </summary>
        internal bool IsSetHierarchyInfo() => this.HierarchyInfo != null;

        /// <summary>
        /// Gets and sets the property RelationshipType. 
        /// <para>
        /// The relationship type of the assets in this relationship. This value is one of the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HIERARCHY</c> – The assets are related through an asset hierarchy. If you specify
        /// this relationship type, this asset relationship includes the <c>hierarchyInfo</c>
        /// object.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetRelationshipType RelationshipType { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipType property is set.
        /// </summary>
        internal bool IsSetRelationshipType() => this.RelationshipType != null;
    }
}
