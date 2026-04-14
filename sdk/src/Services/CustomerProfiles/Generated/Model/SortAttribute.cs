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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Defines the characteristics and rules for sorting by a specific attribute.
    /// </summary>
    public partial class SortAttribute
    {
        private SegmentSortDataType _dataType;
        private string _name;
        private SegmentSortOrder _order;
        private SortAttributeType _type;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the sort attribute (e.g., string, number, date).
        /// </para>
        /// </summary>
        public SegmentSortDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute to sort by.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The sort order for the attribute (ascending or descending).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SegmentSortOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of attribute (e.g., profile, calculated).
        /// </para>
        /// </summary>
        public SortAttributeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}