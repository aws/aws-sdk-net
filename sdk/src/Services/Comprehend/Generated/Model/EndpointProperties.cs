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
    /// Specifies information about the specified endpoint. For information about endpoints,
    /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
    /// endpoints</a>.
    /// </summary>
    public partial class EndpointProperties
    {
        private DateTime? _creationTime;
        private int? _currentInferenceUnits;
        private string _dataAccessRoleArn;
        private string _desiredDataAccessRoleArn;
        private int? _desiredInferenceUnits;
        private string _desiredModelArn;
        private string _endpointArn;
        private string _flywheelArn;
        private DateTime? _lastModifiedTime;
        private string _message;
        private string _modelArn;
        private EndpointStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation date and time of the endpoint.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentInferenceUnits. 
        /// <para>
        /// The number of inference units currently used by the model using this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int CurrentInferenceUnits
        {
            get { return this._currentInferenceUnits.GetValueOrDefault(); }
            set { this._currentInferenceUnits = value; }
        }

        // Check to see if CurrentInferenceUnits property is set
        internal bool IsSetCurrentInferenceUnits()
        {
            return this._currentInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend read access to trained custom models encrypted with
        /// a customer managed key (ModelKmsKeyId).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredDataAccessRoleArn. 
        /// <para>
        /// Data access role ARN to use in case the new model is encrypted with a customer KMS
        /// key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DesiredDataAccessRoleArn
        {
            get { return this._desiredDataAccessRoleArn; }
            set { this._desiredDataAccessRoleArn = value; }
        }

        // Check to see if DesiredDataAccessRoleArn property is set
        internal bool IsSetDesiredDataAccessRoleArn()
        {
            return this._desiredDataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredInferenceUnits. 
        /// <para>
        /// The desired number of inference units to be used by the model using this endpoint.
        /// Each inference unit represents of a throughput of 100 characters per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int DesiredInferenceUnits
        {
            get { return this._desiredInferenceUnits.GetValueOrDefault(); }
            set { this._desiredInferenceUnits = value; }
        }

        // Check to see if DesiredInferenceUnits property is set
        internal bool IsSetDesiredInferenceUnits()
        {
            return this._desiredInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredModelArn. 
        /// <para>
        /// ARN of the new model to use for updating an existing endpoint. This ARN is going to
        /// be different from the model ARN when the update is in progress
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DesiredModelArn
        {
            get { return this._desiredModelArn; }
            set { this._desiredModelArn = value; }
        }

        // Check to see if DesiredModelArn property is set
        internal bool IsSetDesiredModelArn()
        {
            return this._desiredModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlywheelArn
        {
            get { return this._flywheelArn; }
            set { this._flywheelArn = value; }
        }

        // Check to see if FlywheelArn property is set
        internal bool IsSetFlywheelArn()
        {
            return this._flywheelArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the endpoint was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies a reason for failure in cases of <code>Failed</code> status.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model to which the endpoint is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the endpoint. Because the endpoint updates and creation are
        /// asynchronous, so customers will need to wait for the endpoint to be <code>Ready</code>
        /// status before making inference requests.
        /// </para>
        /// </summary>
        public EndpointStatus Status
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