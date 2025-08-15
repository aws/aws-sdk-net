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
    /// A structure that describes how data is partitioned on the target.
    /// </summary>
    public partial class IntegrationPartition
    {
        private string _conversionSpec;
        private string _fieldName;
        private string _functionSpec;

        /// <summary>
        /// Gets and sets the property ConversionSpec. 
        /// <para>
        /// Specifies the timestamp format of the source data. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>epoch_sec</c> - Unix epoch timestamp in seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>epoch_milli</c> - Unix epoch timestamp in milliseconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iso</c> - ISO 8601 formatted timestamp
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  Only specify <c>ConversionSpec</c> when using timestamp-based partition functions
        /// (year, month, day, or hour). Glue Zero-ETL uses this parameter to correctly transform
        /// source data into timestamp format before partitioning. 
        /// </para>
        ///  
        /// <para>
        ///  Do not use high-cardinality columns with the <c>identity</c> partition function.
        /// High-cardinality columns include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Primary keys
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Timestamp fields (such as <c>LastModifiedTimestamp</c>, <c>CreatedDate</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// System-generated timestamps
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Using high-cardinality columns with identity partitioning creates many small partitions,
        /// which can significantly degrade ingestion performance. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConversionSpec
        {
            get { return this._conversionSpec; }
            set { this._conversionSpec = value; }
        }

        // Check to see if ConversionSpec property is set
        internal bool IsSetConversionSpec()
        {
            return this._conversionSpec != null;
        }

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name used to partition data on the target. Avoid using columns that have
        /// unique values for each row (for example, `LastModifiedTimestamp`, `SystemModTimeStamp`)
        /// as the partition column. These columns are not suitable for partitioning because they
        /// create a large number of small partitions, which can lead to performance issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FieldName
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
        /// Gets and sets the property FunctionSpec. 
        /// <para>
        /// Specifies the function used to partition data on the target. The accepted values for
        /// this parameter are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>identity</c> - Uses source values directly without transformation
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>year</c> - Extracts the year from timestamp values (e.g., 2023)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>month</c> - Extracts the month from timestamp values (e.g., 2023-01)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>day</c> - Extracts the day from timestamp values (e.g., 2023-01-15)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hour</c> - Extracts the hour from timestamp values (e.g., 2023-01-15-14)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FunctionSpec
        {
            get { return this._functionSpec; }
            set { this._functionSpec = value; }
        }

        // Check to see if FunctionSpec property is set
        internal bool IsSetFunctionSpec()
        {
            return this._functionSpec != null;
        }

    }
}