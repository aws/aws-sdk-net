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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents attributes that are copied (projected) from the table into an index. These
    /// are in addition to the primary key attributes and index key attributes, which are
    /// automatically projected.
    /// </summary>
    public partial class Projection
    {
        private List<string> _nonKeyAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProjectionType _projectionType;

        /// <summary>
        /// Gets and sets the property NonKeyAttributes. 
        /// <para>
        /// Represents the non-key attribute names which will be projected into the index.
        /// </para>
        ///  
        /// <para>
        /// For global and local secondary indexes, the total count of <c>NonKeyAttributes</c>
        /// summed across all of the secondary indexes, must not exceed 100. If you project the
        /// same attribute into two different indexes, this counts as two distinct attributes
        /// when determining the total. This limit only applies when you specify the ProjectionType
        /// of <c>INCLUDE</c>. You still can specify the ProjectionType of <c>ALL</c> to project
        /// all attributes from the source table, even if the table has more than 100 attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> NonKeyAttributes
        {
            get { return this._nonKeyAttributes; }
            set { this._nonKeyAttributes = value; }
        }

        // Check to see if NonKeyAttributes property is set
        internal bool IsSetNonKeyAttributes()
        {
            return this._nonKeyAttributes != null && (this._nonKeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProjectionType. 
        /// <para>
        /// The set of attributes that are projected into the index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> - In addition to the attributes described in <c>KEYS_ONLY</c>, the
        /// secondary index will include other non-key attributes that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All of the table attributes are projected into the index.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When using the DynamoDB console, <c>ALL</c> is selected by default.
        /// </para>
        /// </summary>
        public ProjectionType ProjectionType
        {
            get { return this._projectionType; }
            set { this._projectionType = value; }
        }

        // Check to see if ProjectionType property is set
        internal bool IsSetProjectionType()
        {
            return this._projectionType != null;
        }

    }
}