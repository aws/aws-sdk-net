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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ImportModelVersion operation. Imports a model
    /// that has been trained successfully.
    /// </summary>
    public partial class ImportModelVersionRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. If you do not set the client request token, Amazon
        /// Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset for the machine learning model being imported. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property InferenceDataImportStrategy. 
        /// <para>
        /// Indicates how to import the accumulated inference data when a model version is imported.
        /// The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// NO_IMPORT – Don't import the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ADD_WHEN_EMPTY – Only import the data from the source model if there is no existing
        /// data in the target model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OVERWRITE – Import the data from the source model and overwrite the existing data
        /// in the target model.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InferenceDataImportStrategy InferenceDataImportStrategy { get; set; }

        /// <summary>
        /// Checks to see if the InferenceDataImportStrategy property is set.
        /// </summary>
        internal bool IsSetInferenceDataImportStrategy() => this.InferenceDataImportStrategy != null;

        /// <summary>
        /// Gets and sets the property LabelsInputConfiguration.
        /// </summary>
        public LabelsInputConfiguration LabelsInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelsInputConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelsInputConfiguration() => this.LabelsInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name for the machine learning model to be created. If the model already exists,
        /// Amazon Lookout for Equipment creates a new version. If you do not specify this field,
        /// it is filled with the name of the source model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// being used to create the machine learning model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key key used to encrypt model data by Amazon Lookout
        /// for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServerSideKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideKmsKeyId() => this.ServerSideKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SourceModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelVersionArn property is set.
        /// </summary>
        internal bool IsSetSourceModelVersionArn() => this.SourceModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the machine learning model to be created. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
