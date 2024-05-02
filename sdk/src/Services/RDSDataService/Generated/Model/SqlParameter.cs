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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// A parameter used in a SQL statement.
    /// </summary>
    public partial class SqlParameter
    {
        private string _name;
        private TypeHint _typeHint;
        private Field _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TypeHint. 
        /// <para>
        /// A hint that specifies the correct object type for data type mapping. Possible values
        /// are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DATE</c> - The corresponding <c>String</c> parameter value is sent as an object
        /// of <c>DATE</c> type to the database. The accepted format is <c>YYYY-MM-DD</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DECIMAL</c> - The corresponding <c>String</c> parameter value is sent as an object
        /// of <c>DECIMAL</c> type to the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JSON</c> - The corresponding <c>String</c> parameter value is sent as an object
        /// of <c>JSON</c> type to the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIME</c> - The corresponding <c>String</c> parameter value is sent as an object
        /// of <c>TIME</c> type to the database. The accepted format is <c>HH:MM:SS[.FFF]</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMESTAMP</c> - The corresponding <c>String</c> parameter value is sent as an
        /// object of <c>TIMESTAMP</c> type to the database. The accepted format is <c>YYYY-MM-DD
        /// HH:MM:SS[.FFF]</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UUID</c> - The corresponding <c>String</c> parameter value is sent as an object
        /// of <c>UUID</c> type to the database. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TypeHint TypeHint
        {
            get { return this._typeHint; }
            set { this._typeHint = value; }
        }

        // Check to see if TypeHint property is set
        internal bool IsSetTypeHint()
        {
            return this._typeHint != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the parameter.
        /// </para>
        /// </summary>
        public Field Value
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