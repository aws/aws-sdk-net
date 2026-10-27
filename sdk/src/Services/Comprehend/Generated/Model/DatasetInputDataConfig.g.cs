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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Specifies the format and location of the input data for the dataset.
    /// </summary>
    public partial class DatasetInputDataConfig
    {
        /// <summary>
        /// Gets and sets the property AugmentedManifests. 
        /// <para>
        /// A list of augmented manifest files that provide training data for your custom model.
        /// An augmented manifest file is a labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatasetAugmentedManifestsListItem> AugmentedManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<DatasetAugmentedManifestsListItem>() : null;

        /// <summary>
        /// Checks to see if the AugmentedManifests property is set.
        /// </summary>
        internal bool IsSetAugmentedManifests() => this.AugmentedManifests != null && (this.AugmentedManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        ///  <c>COMPREHEND_CSV</c>: The data format is a two-column CSV file, where the first
        /// column contains labels and the second column contains documents.
        /// </para>
        ///  
        /// <para>
        ///  <c>AUGMENTED_MANIFEST</c>: The data format 
        /// </para>
        /// </summary>
        public DatasetDataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

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
        public DatasetDocumentClassifierInputDataConfig DocumentClassifierInputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassifierInputDataConfig property is set.
        /// </summary>
        internal bool IsSetDocumentClassifierInputDataConfig() => this.DocumentClassifierInputDataConfig != null;

        /// <summary>
        /// Gets and sets the property EntityRecognizerInputDataConfig. 
        /// <para>
        /// The input properties for training an entity recognizer model.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerInputDataConfig EntityRecognizerInputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the EntityRecognizerInputDataConfig property is set.
        /// </summary>
        internal bool IsSetEntityRecognizerInputDataConfig() => this.EntityRecognizerInputDataConfig != null;
    }
}
