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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The data structure used to specify the data to be used for inference in a batch transform
    /// job and to associate the data that is relevant to the prediction results in the output.
    /// The input filter provided allows you to exclude input data that is not needed for
    /// inference in a batch transform job. The output filter provided allows you to include
    /// input data relevant to interpreting the predictions in the output from the job. For
    /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html">Associate
    /// Prediction Results with their Corresponding Input Records</a>.
    /// </summary>
    public partial class DataProcessing
    {
        private string _inputFilter;
        private JoinSource _joinSource;
        private string _outputFilter;

        /// <summary>
        /// Gets and sets the property InputFilter. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html#data-processing-operators">JSONPath</a>
        /// expression used to select a portion of the input data to pass to the algorithm. Use
        /// the <code>InputFilter</code> parameter to exclude fields, such as an ID column, from
        /// the input. If you want Amazon SageMaker to pass the entire input dataset to the algorithm,
        /// accept the default value <code>$</code>.
        /// </para>
        ///  
        /// <para>
        /// Examples: <code>"$"</code>, <code>"$[1:]"</code>, <code>"$.features"</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InputFilter
        {
            get { return this._inputFilter; }
            set { this._inputFilter = value; }
        }

        // Check to see if InputFilter property is set
        internal bool IsSetInputFilter()
        {
            return this._inputFilter != null;
        }

        /// <summary>
        /// Gets and sets the property JoinSource. 
        /// <para>
        /// Specifies the source of the data to join with the transformed data. The valid values
        /// are <code>None</code> and <code>Input</code>. The default value is <code>None</code>,
        /// which specifies not to join the input with the transformed data. If you want the batch
        /// transform job to join the original input data with the transformed data, set <code>JoinSource</code>
        /// to <code>Input</code>. 
        /// </para>
        ///  
        /// <para>
        /// For JSON or JSONLines objects, such as a JSON array, Amazon SageMaker adds the transformed
        /// data to the input JSON object in an attribute called <code>SageMakerOutput</code>.
        /// The joined result for JSON must be a key-value pair object. If the input is not a
        /// key-value pair object, Amazon SageMaker creates a new JSON file. In the new JSON file,
        /// and the input data is stored under the <code>SageMakerInput</code> key and the results
        /// are stored in <code>SageMakerOutput</code>.
        /// </para>
        ///  
        /// <para>
        /// For CSV files, Amazon SageMaker combines the transformed data with the input data
        /// at the end of the input data and stores it in the output file. The joined data has
        /// the joined input data followed by the transformed data and the output is a CSV file.
        /// 
        /// </para>
        /// </summary>
        public JoinSource JoinSource
        {
            get { return this._joinSource; }
            set { this._joinSource = value; }
        }

        // Check to see if JoinSource property is set
        internal bool IsSetJoinSource()
        {
            return this._joinSource != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFilter. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html#data-processing-operators">JSONPath</a>
        /// expression used to select a portion of the joined dataset to save in the output file
        /// for a batch transform job. If you want Amazon SageMaker to store the entire input
        /// dataset in the output file, leave the default value, <code>$</code>. If you specify
        /// indexes that aren't within the dimension size of the joined dataset, you get an error.
        /// </para>
        ///  
        /// <para>
        /// Examples: <code>"$"</code>, <code>"$[0,5:]"</code>, <code>"$['id','SageMakerOutput']"</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string OutputFilter
        {
            get { return this._outputFilter; }
            set { this._outputFilter = value; }
        }

        // Check to see if OutputFilter property is set
        internal bool IsSetOutputFilter()
        {
            return this._outputFilter != null;
        }

    }
}