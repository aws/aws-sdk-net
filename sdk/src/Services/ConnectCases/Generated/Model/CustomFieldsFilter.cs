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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A filter for fields in related items of type Custom
    /// </summary>
    public partial class CustomFieldsFilter
    {
        private List<CustomFieldsFilter> _andAll = AWSConfigs.InitializeCollections ? new List<CustomFieldsFilter>() : null;
        private FieldFilter _field;
        private CustomFieldsFilter _not;
        private List<CustomFieldsFilter> _orAll = AWSConfigs.InitializeCollections ? new List<CustomFieldsFilter>() : null;

        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Matches items that satisfy all of the specified filter conditions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CustomFieldsFilter> AndAll
        {
            get { return this._andAll; }
            set { this._andAll = value; }
        }

        // Check to see if AndAll property is set
        internal bool IsSetAndAll()
        {
            return this._andAll != null && (this._andAll.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Field.
        /// </summary>
        public FieldFilter Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Not. 
        /// <para>
        /// Excludes items matching the filter
        /// </para>
        /// </summary>
        public CustomFieldsFilter Not
        {
            get { return this._not; }
            set { this._not = value; }
        }

        // Check to see if Not property is set
        internal bool IsSetNot()
        {
            return this._not != null;
        }

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Matches items that satisfy any of the specified filter conditions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CustomFieldsFilter> OrAll
        {
            get { return this._orAll; }
            set { this._orAll = value; }
        }

        // Check to see if OrAll property is set
        internal bool IsSetOrAll()
        {
            return this._orAll != null && (this._orAll.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}