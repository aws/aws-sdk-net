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
    /// The Amazon SageMaker model.
    /// </summary>
    public partial class ExternalModel
    {
        private string _arn;
        private string _createdTime;
        private ModelInputConfiguration _inputConfiguration;
        private string _invokeModelEndpointRoleArn;
        private string _lastUpdatedTime;
        private string _modelEndpoint;
        private ModelEndpointStatus _modelEndpointStatus;
        private ModelSource _modelSource;
        private ModelOutputConfiguration _outputConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The model ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp of when the model was last created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The input configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InvokeModelEndpointRoleArn. 
        /// <para>
        /// The role used to invoke the model. 
        /// </para>
        /// </summary>
        public string InvokeModelEndpointRoleArn
        {
            get { return this._invokeModelEndpointRoleArn; }
            set { this._invokeModelEndpointRoleArn = value; }
        }

        // Check to see if InvokeModelEndpointRoleArn property is set
        internal bool IsSetInvokeModelEndpointRoleArn()
        {
            return this._invokeModelEndpointRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the model was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        /// The Amazon SageMaker model endpoints.
        /// </para>
        /// </summary>
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
        /// The Amazon Fraud Detector status for the external model endpoint
        /// </para>
        /// </summary>
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
        /// The output configuration.
        /// </para>
        /// </summary>
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

    }
}