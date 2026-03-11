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
    /// Contains lock version information for different levels of a data table hierarchy.
    /// Used for optimistic locking to prevent concurrent modification conflicts. Each component
    /// has its own lock version that changes when that component is modified.
    /// </summary>
    public partial class DataTableLockVersion
    {
        private string _attribute;
        private string _dataTable;
        private string _primaryValues;
        private string _value;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The lock version for a specific attribute. When the ValueLockLevel is ATTRIBUTE, this
        /// version changes when any value for the attribute changes. For other lock levels, it
        /// only changes when the attribute's properties are directly updated.
        /// </para>
        /// </summary>
        public string Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property DataTable. 
        /// <para>
        /// The lock version for the data table itself. Used for optimistic locking and table
        /// versioning. Changes with each update to the table's metadata or structure.
        /// </para>
        /// </summary>
        public string DataTable
        {
            get { return this._dataTable; }
            set { this._dataTable = value; }
        }

        // Check to see if DataTable property is set
        internal bool IsSetDataTable()
        {
            return this._dataTable != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The lock version for a specific set of primary values (record). This includes the
        /// default record even if the table does not have any primary attributes. Used for record-level
        /// locking.
        /// </para>
        /// </summary>
        public string PrimaryValues
        {
            get { return this._primaryValues; }
            set { this._primaryValues = value; }
        }

        // Check to see if PrimaryValues property is set
        internal bool IsSetPrimaryValues()
        {
            return this._primaryValues != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The lock version for a specific value. Changes each time the individual value is modified.
        /// Used for the finest-grained locking control.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}