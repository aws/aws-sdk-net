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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A clause to match a query pattern
    /// </summary>
    public partial class MatchClause
    {
        /// <summary>
        /// Gets and sets the property EntityPattern. 
        /// <para>
        /// The pattern describing the entities for the query to traverse.
        /// </para>
        /// </summary>
        public EntityPattern EntityPattern { get; set; }

        /// <summary>
        /// Checks to see if the EntityPattern property is set.
        /// </summary>
        internal bool IsSetEntityPattern() => this.EntityPattern != null;

        /// <summary>
        /// Gets and sets the property RelationPattern. 
        /// <para>
        /// The pattern describing the query's relational traversal.
        /// </para>
        /// </summary>
        public RelationPattern RelationPattern { get; set; }

        /// <summary>
        /// Checks to see if the RelationPattern property is set.
        /// </summary>
        internal bool IsSetRelationPattern() => this.RelationPattern != null;
    }
}
