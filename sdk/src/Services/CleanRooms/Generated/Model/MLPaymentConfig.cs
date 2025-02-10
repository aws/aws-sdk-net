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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// An object representing the collaboration member's machine learning payment responsibilities
    /// set by the collaboration creator.
    /// </summary>
    public partial class MLPaymentConfig
    {
        private ModelInferencePaymentConfig _modelInference;
        private ModelTrainingPaymentConfig _modelTraining;

        /// <summary>
        /// Gets and sets the property ModelInference. 
        /// <para>
        /// The payment responsibilities accepted by the member for model inference.
        /// </para>
        /// </summary>
        public ModelInferencePaymentConfig ModelInference
        {
            get { return this._modelInference; }
            set { this._modelInference = value; }
        }

        // Check to see if ModelInference property is set
        internal bool IsSetModelInference()
        {
            return this._modelInference != null;
        }

        /// <summary>
        /// Gets and sets the property ModelTraining. 
        /// <para>
        /// The payment responsibilities accepted by the member for model training.
        /// </para>
        /// </summary>
        public ModelTrainingPaymentConfig ModelTraining
        {
            get { return this._modelTraining; }
            set { this._modelTraining = value; }
        }

        // Check to see if ModelTraining property is set
        internal bool IsSetModelTraining()
        {
            return this._modelTraining != null;
        }

    }
}