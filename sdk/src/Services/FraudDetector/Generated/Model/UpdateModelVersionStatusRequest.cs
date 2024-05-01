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
    /// Container for the parameters to the UpdateModelVersionStatus operation.
    /// Updates the status of a model version.
    /// 
    ///  
    /// <para>
    /// You can perform the following status updates:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Change the <c>TRAINING_IN_PROGRESS</c> status to <c>TRAINING_CANCELLED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change the <c>TRAINING_COMPLETE</c> status to <c>ACTIVE</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change <c>ACTIVE</c> to <c>INACTIVE</c>.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateModelVersionStatusRequest : AmazonFraudDetectorRequest
    {
        private string _modelId;
        private ModelTypeEnum _modelType;
        private string _modelVersionNumber;
        private ModelVersionStatus _status;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID of the model version to update.
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
        /// Gets and sets the property ModelVersionNumber. 
        /// <para>
        /// The model version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=7)]
        public string ModelVersionNumber
        {
            get { return this._modelVersionNumber; }
            set { this._modelVersionNumber = value; }
        }

        // Check to see if ModelVersionNumber property is set
        internal bool IsSetModelVersionNumber()
        {
            return this._modelVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The model version status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}