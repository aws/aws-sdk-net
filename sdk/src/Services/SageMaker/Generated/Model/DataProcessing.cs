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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// the <c>InputFilter</c> parameter to exclude fields, such as an ID column, from the
        /// input. If you want SageMaker to pass the entire input dataset to the algorithm, accept
        /// the default value <c>$</c>.
        /// </para>
        ///  
        /// <para>
        /// Examples: <c>"$"</c>, <c>"$[1:]"</c>, <c>"$.features"</c> 
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
        /// are <c>None</c> and <c>Input</c>. The default value is <c>None</c>, which specifies
        /// not to join the input with the transformed data. If you want the batch transform job
        /// to join the original input data with the transformed data, set <c>JoinSource</c> to
        /// <c>Input</c>. You can specify <c>OutputFilter</c> as an additional filter to select
        /// a portion of the joined dataset and store it in the output file.
        /// </para>
        ///  
        /// <para>
        /// For JSON or JSONLines objects, such as a JSON array, SageMaker adds the transformed
        /// data to the input JSON object in an attribute called <c>SageMakerOutput</c>. The joined
        /// result for JSON must be a key-value pair object. If the input is not a key-value pair
        /// object, SageMaker creates a new JSON file. In the new JSON file, and the input data
        /// is stored under the <c>SageMakerInput</c> key and the results are stored in <c>SageMakerOutput</c>.
        /// </para>
        ///  
        /// <para>
        /// For CSV data, SageMaker takes each row as a JSON array and joins the transformed data
        /// with the input by appending each transformed row to the end of the input. The joined
        /// data has the original input data followed by the transformed data and the output is
        /// a CSV file.
        /// </para>
        ///  
        /// <para>
        /// For information on how joining in applied, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html#batch-transform-data-processing-workflow">Workflow
        /// for Associating Inferences with Input Records</a>.
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
        /// for a batch transform job. If you want SageMaker to store the entire input dataset
        /// in the output file, leave the default value, <c>$</c>. If you specify indexes that
        /// aren't within the dimension size of the joined dataset, you get an error.
        /// </para>
        ///  
        /// <para>
        /// Examples: <c>"$"</c>, <c>"$[0,5:]"</c>, <c>"$['id','SageMakerOutput']"</c> 
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