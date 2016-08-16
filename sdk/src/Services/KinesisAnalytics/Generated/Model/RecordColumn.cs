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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the mapping of each data element in the streaming source to the corresponding
    /// column in the in-application stream.
    /// 
    ///  
    /// <para>
    /// Also used to describe the format of the reference data source.
    /// </para>
    /// </summary>
    public partial class RecordColumn
    {
        private string _mapping;
        private string _name;
        private string _sqlType;

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// Reference to the data element in the streaming input of the reference data source.
        /// </para>
        /// </summary>
        public string Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the column created in the in-application input stream or reference table.
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
        /// Gets and sets the property SqlType. 
        /// <para>
        /// Type of column created in the in-application input stream or reference table.
        /// </para>
        /// </summary>
        public string SqlType
        {
            get { return this._sqlType; }
            set { this._sqlType = value; }
        }

        // Check to see if SqlType property is set
        internal bool IsSetSqlType()
        {
            return this._sqlType != null;
        }

    }
}