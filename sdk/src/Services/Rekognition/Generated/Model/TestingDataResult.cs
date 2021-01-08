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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Sagemaker Groundtruth format manifest files for the input, output and validation datasets
    /// that are used and created during testing.
    /// </summary>
    public partial class TestingDataResult
    {
        private TestingData _input;
        private TestingData _output;
        private ValidationData _validation;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The testing dataset that was supplied for training.
        /// </para>
        /// </summary>
        public TestingData Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The subset of the dataset that was actually tested. Some images (assets) might not
        /// be tested due to file formatting and other issues. 
        /// </para>
        /// </summary>
        public TestingData Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The location of the data validation manifest. The data validation manifest is created
        /// for the test dataset during model training.
        /// </para>
        /// </summary>
        public ValidationData Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }

        // Check to see if Validation property is set
        internal bool IsSetValidation()
        {
            return this._validation != null;
        }

    }
}