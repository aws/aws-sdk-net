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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A view of a data source that contains information about the shape of the data in the
    /// underlying source. This is a variant type structure. For this structure to be valid,
    /// only one of the attributes can be non-null.
    /// </summary>
    public partial class PhysicalTable
    {
        private CustomSql _customSql;
        private RelationalTable _relationalTable;
        private S3Source _s3Source;

        /// <summary>
        /// Gets and sets the property CustomSql. 
        /// <para>
        /// A physical table type built from the results of the custom SQL query.
        /// </para>
        /// </summary>
        public CustomSql CustomSql
        {
            get { return this._customSql; }
            set { this._customSql = value; }
        }

        // Check to see if CustomSql property is set
        internal bool IsSetCustomSql()
        {
            return this._customSql != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalTable. 
        /// <para>
        /// A physical table type for relational data sources.
        /// </para>
        /// </summary>
        public RelationalTable RelationalTable
        {
            get { return this._relationalTable; }
            set { this._relationalTable = value; }
        }

        // Check to see if RelationalTable property is set
        internal bool IsSetRelationalTable()
        {
            return this._relationalTable != null;
        }

        /// <summary>
        /// Gets and sets the property S3Source. 
        /// <para>
        /// A physical table type for as S3 data source.
        /// </para>
        /// </summary>
        public S3Source S3Source
        {
            get { return this._s3Source; }
            set { this._s3Source = value; }
        }

        // Check to see if S3Source property is set
        internal bool IsSetS3Source()
        {
            return this._s3Source != null;
        }

    }
}