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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A list of fields, comparators and value that you can use to filter the crawler runs
    /// for a specified crawler.
    /// </summary>
    public partial class CrawlsFilter
    {
        private FieldName _fieldName;
        private string _fieldValue;
        private FilterOperator _filterOperator;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// A key used to filter the crawler runs for a specified crawler. Valid values for each
        /// of the field names are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CRAWL_ID</c>: A string representing the UUID identifier for a crawl.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STATE</c>: A string representing the state of the crawl.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>START_TIME</c> and <c>END_TIME</c>: The epoch timestamp in milliseconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DPU_HOUR</c>: The number of data processing unit (DPU) hours used for the crawl.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FieldName FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldValue. 
        /// <para>
        /// The value provided for comparison on the crawl field. 
        /// </para>
        /// </summary>
        public string FieldValue
        {
            get { return this._fieldValue; }
            set { this._fieldValue = value; }
        }

        // Check to see if FieldValue property is set
        internal bool IsSetFieldValue()
        {
            return this._fieldValue != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperator. 
        /// <para>
        /// A defined comparator that operates on the value. The available operators are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GT</c>: Greater than.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GE</c>: Greater than or equal to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LT</c>: Less than.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LE</c>: Less than or equal to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EQ</c>: Equal to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NE</c>: Not equal to.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FilterOperator FilterOperator
        {
            get { return this._filterOperator; }
            set { this._filterOperator = value; }
        }

        // Check to see if FilterOperator property is set
        internal bool IsSetFilterOperator()
        {
            return this._filterOperator != null;
        }

    }
}