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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// An instance of a variable to be passed to the <c>containerAction</c> execution. Each
    /// variable must have a name and a value given by one of <c>stringValue</c>, <c>datasetContentVersionValue</c>,
    /// or <c>outputFileUriValue</c>.
    /// </summary>
    public partial class Variable
    {
        private DatasetContentVersionValue _datasetContentVersionValue;
        private double? _doubleValue;
        private string _name;
        private OutputFileUriValue _outputFileUriValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property DatasetContentVersionValue. 
        /// <para>
        /// The value of the variable as a structure that specifies a dataset content version.
        /// </para>
        /// </summary>
        public DatasetContentVersionValue DatasetContentVersionValue
        {
            get { return this._datasetContentVersionValue; }
            set { this._datasetContentVersionValue = value; }
        }

        // Check to see if DatasetContentVersionValue property is set
        internal bool IsSetDatasetContentVersionValue()
        {
            return this._datasetContentVersionValue != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// The value of the variable as a double (numeric).
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property OutputFileUriValue. 
        /// <para>
        /// The value of the variable as a structure that specifies an output file URI.
        /// </para>
        /// </summary>
        public OutputFileUriValue OutputFileUriValue
        {
            get { return this._outputFileUriValue; }
            set { this._outputFileUriValue = value; }
        }

        // Check to see if OutputFileUriValue property is set
        internal bool IsSetOutputFileUriValue()
        {
            return this._outputFileUriValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The value of the variable as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}