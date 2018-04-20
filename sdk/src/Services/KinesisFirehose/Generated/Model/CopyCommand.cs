/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes a <code>COPY</code> command for Amazon Redshift.
    /// </summary>
    public partial class CopyCommand
    {
        private string _copyOptions;
        private string _dataTableColumns;
        private string _dataTableName;

        /// <summary>
        /// Gets and sets the property CopyOptions. 
        /// <para>
        /// Optional parameters to use with the Amazon Redshift <code>COPY</code> command. For
        /// more information, see the "Optional Parameters" section of <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_COPY.html">Amazon
        /// Redshift COPY command</a>. Some possible examples that would apply to Kinesis Data
        /// Firehose are as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>delimiter '\t' lzop;</code> - fields are delimited with "\t" (TAB character)
        /// and compressed using lzop.
        /// </para>
        ///  
        /// <para>
        ///  <code>delimiter '|'</code> - fields are delimited with "|" (this is the default delimiter).
        /// </para>
        ///  
        /// <para>
        ///  <code>delimiter '|' escape</code> - the delimiter should be escaped.
        /// </para>
        ///  
        /// <para>
        ///  <code>fixedwidth 'venueid:3,venuename:25,venuecity:12,venuestate:2,venueseats:6'</code>
        /// - fields are fixed width in the source, with each width specified after every column
        /// in the table.
        /// </para>
        ///  
        /// <para>
        ///  <code>JSON 's3://mybucket/jsonpaths.txt'</code> - data is in JSON format, and the
        /// path specified is the format of the data.
        /// </para>
        ///  
        /// <para>
        /// For more examples, see <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_COPY_command_examples.html">Amazon
        /// Redshift COPY command examples</a>.
        /// </para>
        /// </summary>
        public string CopyOptions
        {
            get { return this._copyOptions; }
            set { this._copyOptions = value; }
        }

        // Check to see if CopyOptions property is set
        internal bool IsSetCopyOptions()
        {
            return this._copyOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DataTableColumns. 
        /// <para>
        /// A comma-separated list of column names.
        /// </para>
        /// </summary>
        public string DataTableColumns
        {
            get { return this._dataTableColumns; }
            set { this._dataTableColumns = value; }
        }

        // Check to see if DataTableColumns property is set
        internal bool IsSetDataTableColumns()
        {
            return this._dataTableColumns != null;
        }

        /// <summary>
        /// Gets and sets the property DataTableName. 
        /// <para>
        /// The name of the target table. The table must already exist in the database.
        /// </para>
        /// </summary>
        public string DataTableName
        {
            get { return this._dataTableName; }
            set { this._dataTableName = value; }
        }

        // Check to see if DataTableName property is set
        internal bool IsSetDataTableName()
        {
            return this._dataTableName != null;
        }

    }
}