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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// For global and local secondary indexes, identifies the attributes that are copied
    /// from the table into the index.
    /// </summary>
    public partial class AwsDynamoDbTableProjection
    {
        private List<string> _nonKeyAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _projectionType;

        /// <summary>
        /// Gets and sets the property NonKeyAttributes. 
        /// <para>
        /// The nonkey attributes that are projected into the index. For each attribute, provide
        /// the attribute name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The types of attributes that are projected into the index. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ProjectionType
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