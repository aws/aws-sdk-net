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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Specifies the format and location of the input data for the dataset.
    /// </summary>
    public partial class DatasetInputDataConfig
    {
        private List<DatasetAugmentedManifestsListItem> _augmentedManifests = new List<DatasetAugmentedManifestsListItem>();
        private DatasetDataFormat _dataFormat;
        private DatasetDocumentClassifierInputDataConfig _documentClassifierInputDataConfig;
        private DatasetEntityRecognizerInputDataConfig _entityRecognizerInputDataConfig;

        /// <summary>
        /// Gets and sets the property AugmentedManifests. 
        /// <para>
        /// A list of augmented manifest files that provide training data for your custom model.
        /// An augmented manifest file is a labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth. 
        /// </para>
        /// </summary>
        public List<DatasetAugmentedManifestsListItem> AugmentedManifests
        {
            get { return this._augmentedManifests; }
            set { this._augmentedManifests = value; }
        }

        // Check to see if AugmentedManifests property is set
        internal bool IsSetAugmentedManifests()
        {
            return this._augmentedManifests != null && this._augmentedManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        ///  <code>COMPREHEND_CSV</code>: The data format is a two-column CSV file, where the
        /// first column contains labels and the second column contains documents.
        /// </para>
        ///  
        /// <para>
        ///  <code>AUGMENTED_MANIFEST</code>: The data format 
        /// </para>
        /// </summary>
        public DatasetDataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentClassifierInputDataConfig. 
        /// <para>
        /// The input properties for training a document classifier model. 
        /// </para>
        ///  
        /// <para>
        /// For more information on how the input file is formatted, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/prep-classifier-data.html">Preparing
        /// training data</a> in the Comprehend Developer Guide. 
        /// </para>
        /// </summary>
        public DatasetDocumentClassifierInputDataConfig DocumentClassifierInputDataConfig
        {
            get { return this._documentClassifierInputDataConfig; }
            set { this._documentClassifierInputDataConfig = value; }
        }

        // Check to see if DocumentClassifierInputDataConfig property is set
        internal bool IsSetDocumentClassifierInputDataConfig()
        {
            return this._documentClassifierInputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EntityRecognizerInputDataConfig. 
        /// <para>
        /// The input properties for training an entity recognizer model.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerInputDataConfig EntityRecognizerInputDataConfig
        {
            get { return this._entityRecognizerInputDataConfig; }
            set { this._entityRecognizerInputDataConfig = value; }
        }

        // Check to see if EntityRecognizerInputDataConfig property is set
        internal bool IsSetEntityRecognizerInputDataConfig()
        {
            return this._entityRecognizerInputDataConfig != null;
        }

    }
}