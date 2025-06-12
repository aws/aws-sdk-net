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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateModelVersion operation.
    /// Updates a model version. Updating a model version retrains an existing model version
    /// using updated training data and produces a new minor version of the model. You can
    /// update the training data set location and data access role attributes using this action.
    /// This action creates and trains a new minor version of the model, for example version
    /// 1.01, 1.02, 1.03.
    /// </summary>
    public partial class UpdateModelVersionRequest : AmazonFraudDetectorRequest
    {
        private ExternalEventsDetail _externalEventsDetail;
        private IngestedEventsDetail _ingestedEventsDetail;
        private string _majorVersionNumber;
        private string _modelId;
        private ModelTypeEnum _modelType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// The details of the external events data used for training the model version. Required
        /// if <c>trainingDataSource</c> is <c>EXTERNAL_EVENTS</c>.
        /// </para>
        /// </summary>
        public ExternalEventsDetail ExternalEventsDetail
        {
            get { return this._externalEventsDetail; }
            set { this._externalEventsDetail = value; }
        }

        // Check to see if ExternalEventsDetail property is set
        internal bool IsSetExternalEventsDetail()
        {
            return this._externalEventsDetail != null;
        }

        /// <summary>
        /// Gets and sets the property IngestedEventsDetail. 
        /// <para>
        /// The details of the ingested event used for training the model version. Required if
        /// your <c>trainingDataSource</c> is <c>INGESTED_EVENTS</c>.
        /// </para>
        /// </summary>
        public IngestedEventsDetail IngestedEventsDetail
        {
            get { return this._ingestedEventsDetail; }
            set { this._ingestedEventsDetail = value; }
        }

        // Check to see if IngestedEventsDetail property is set
        internal bool IsSetIngestedEventsDetail()
        {
            return this._ingestedEventsDetail != null;
        }

        /// <summary>
        /// Gets and sets the property MajorVersionNumber. 
        /// <para>
        /// The major version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string MajorVersionNumber
        {
            get { return this._majorVersionNumber; }
            set { this._majorVersionNumber = value; }
        }

        // Check to see if MajorVersionNumber property is set
        internal bool IsSetMajorVersionNumber()
        {
            return this._majorVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelTypeEnum ModelType
        {
            get { return this._modelType; }
            set { this._modelType = value; }
        }

        // Check to see if ModelType property is set
        internal bool IsSetModelType()
        {
            return this._modelType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key and value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}