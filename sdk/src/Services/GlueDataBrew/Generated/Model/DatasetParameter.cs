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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a dataset parameter that defines type and conditions for a parameter in
    /// the Amazon S3 path of the dataset.
    /// </summary>
    public partial class DatasetParameter
    {
        private bool? _createColumn;
        private DatetimeOptions _datetimeOptions;
        private FilterExpression _filter;
        private string _name;
        private ParameterType _type;

        /// <summary>
        /// Gets and sets the property CreateColumn. 
        /// <para>
        /// Optional boolean value that defines whether the captured value of this parameter should
        /// be used to create a new column in a dataset.
        /// </para>
        /// </summary>
        public bool? CreateColumn
        {
            get { return this._createColumn; }
            set { this._createColumn = value; }
        }

        // Check to see if CreateColumn property is set
        internal bool IsSetCreateColumn()
        {
            return this._createColumn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatetimeOptions. 
        /// <para>
        /// Additional parameter options such as a format and a timezone. Required for datetime
        /// parameters.
        /// </para>
        /// </summary>
        public DatetimeOptions DatetimeOptions
        {
            get { return this._datetimeOptions; }
            set { this._datetimeOptions = value; }
        }

        // Check to see if DatetimeOptions property is set
        internal bool IsSetDatetimeOptions()
        {
            return this._datetimeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The optional filter expression structure to apply additional matching criteria to
        /// the parameter.
        /// </para>
        /// </summary>
        public FilterExpression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that is used in the dataset's Amazon S3 path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the dataset parameter, can be one of a 'String', 'Number' or 'Datetime'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParameterType Type
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