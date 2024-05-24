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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeploymentModel
    {
        private ModelState _desiredState;
        private string _modelHandle;
        private string _modelName;
        private string _modelVersion;
        private string _rollbackFailureReason;
        private ModelState _state;
        private DeploymentStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The desired state of the model.
        /// </para>
        /// </summary>
        public ModelState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property ModelHandle. 
        /// <para>
        /// The unique handle of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelHandle
        {
            get { return this._modelHandle; }
            set { this._modelHandle = value; }
        }

        // Check to see if ModelHandle property is set
        internal bool IsSetModelHandle()
        {
            return this._modelHandle != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=255)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackFailureReason. 
        /// <para>
        /// Returns the error message if there is a rollback.
        /// </para>
        /// </summary>
        public string RollbackFailureReason
        {
            get { return this._rollbackFailureReason; }
            set { this._rollbackFailureReason = value; }
        }

        // Check to see if RollbackFailureReason property is set
        internal bool IsSetRollbackFailureReason()
        {
            return this._rollbackFailureReason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Returns the current state of the model.
        /// </para>
        /// </summary>
        public ModelState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns the deployment status of the model.
        /// </para>
        /// </summary>
        public DeploymentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Returns the error message for the deployment status result.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}