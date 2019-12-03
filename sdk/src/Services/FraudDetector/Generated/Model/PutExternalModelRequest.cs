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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the PutExternalModel operation.
    /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
    /// to update the configuration of the model endpoint, including the IAM role and/or the
    /// mapped variables.
    /// </summary>
    public partial class PutExternalModelRequest : AmazonFraudDetectorRequest
    {
        private ModelInputConfiguration _inputConfiguration;
        private string _modelEndpoint;
        private ModelEndpointStatus _modelEndpointStatus;
        private ModelSource _modelSource;
        private ModelOutputConfiguration _outputConfiguration;
        private Role _role;

        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The model endpoint input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInputConfiguration InputConfiguration
        {
            get { return this._inputConfiguration; }
            set { this._inputConfiguration = value; }
        }

        // Check to see if InputConfiguration property is set
        internal bool IsSetInputConfiguration()
        {
            return this._inputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        /// The model endpoints name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelEndpoint
        {
            get { return this._modelEndpoint; }
            set { this._modelEndpoint = value; }
        }

        // Check to see if ModelEndpoint property is set
        internal bool IsSetModelEndpoint()
        {
            return this._modelEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ModelEndpointStatus. 
        /// <para>
        /// The model endpoint’s status in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelEndpointStatus ModelEndpointStatus
        {
            get { return this._modelEndpointStatus; }
            set { this._modelEndpointStatus = value; }
        }

        // Check to see if ModelEndpointStatus property is set
        internal bool IsSetModelEndpointStatus()
        {
            return this._modelEndpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The source of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelSource ModelSource
        {
            get { return this._modelSource; }
            set { this._modelSource = value; }
        }

        // Check to see if ModelSource property is set
        internal bool IsSetModelSource()
        {
            return this._modelSource != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The model endpoint output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelOutputConfiguration OutputConfiguration
        {
            get { return this._outputConfiguration; }
            set { this._outputConfiguration = value; }
        }

        // Check to see if OutputConfiguration property is set
        internal bool IsSetOutputConfiguration()
        {
            return this._outputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role used to invoke the model endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Role Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}