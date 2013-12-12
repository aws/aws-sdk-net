/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents attributes that are copied (projected) from the table into the index. These are in addition to the primary key attributes
    /// and index key attributes, which are automatically projected.</para>
    /// </summary>
    public class Projection
    {
        
        private ProjectionType projectionType;
        private List<string> nonKeyAttributes = new List<string>();


        /// <summary>
        /// Represents the set of attributes that are projected into the index: <ul> <li> <c>KEYS_ONLY</c> - Only the index and primary keys are
        /// projected into the index. </li> <li> <c>INCLUDE</c> - Only the specified table attributes are projected into the index. The list of
        /// projected attributes are in <i>NonKeyAttributes</i>. </li> <li> <c>ALL</c> - All of the table attributes are projected into the index. </li>
        /// </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ALL, KEYS_ONLY, INCLUDE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ProjectionType ProjectionType
        {
            get { return this.projectionType; }
            set { this.projectionType = value; }
        }

        // Check to see if ProjectionType property is set
        internal bool IsSetProjectionType()
        {
            return this.projectionType != null;
        }

        /// <summary>
        /// Represents the non-key attribute names which will be projected into the index. The total count of attributes specified in
        /// <i>NonKeyAttributes</i>, summed across all of the local secondary indexes, must not exceed 20. If you project the same attribute into two
        /// different indexes, this counts as two distinct attributes when determining the total.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 20</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> NonKeyAttributes
        {
            get { return this.nonKeyAttributes; }
            set { this.nonKeyAttributes = value; }
        }

        // Check to see if NonKeyAttributes property is set
        internal bool IsSetNonKeyAttributes()
        {
            return this.nonKeyAttributes.Count > 0;
        }
    }
}
