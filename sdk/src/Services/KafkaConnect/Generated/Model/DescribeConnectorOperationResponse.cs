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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnectorOperation operation.
    /// </summary>
    public partial class DescribeConnectorOperationResponse : AmazonWebServiceResponse
    {
        private string _connectorArn;
        private string _connectorOperationArn;
        private ConnectorOperationState _connectorOperationState;
        private ConnectorOperationType _connectorOperationType;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private StateDescription _errorInfo;
        private List<ConnectorOperationStep> _operationSteps = AWSConfigs.InitializeCollections ? new List<ConnectorOperationStep>() : null;
        private Dictionary<string, string> _originConnectorConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private WorkerSetting _originWorkerSetting;
        private Dictionary<string, string> _targetConnectorConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private WorkerSetting _targetWorkerSetting;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector operation.
        /// </para>
        /// </summary>
        public string ConnectorOperationArn
        {
            get { return this._connectorOperationArn; }
            set { this._connectorOperationArn = value; }
        }

        // Check to see if ConnectorOperationArn property is set
        internal bool IsSetConnectorOperationArn()
        {
            return this._connectorOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationState. 
        /// <para>
        /// The state of the connector operation.
        /// </para>
        /// </summary>
        public ConnectorOperationState ConnectorOperationState
        {
            get { return this._connectorOperationState; }
            set { this._connectorOperationState = value; }
        }

        // Check to see if ConnectorOperationState property is set
        internal bool IsSetConnectorOperationState()
        {
            return this._connectorOperationState != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationType. 
        /// <para>
        /// The type of connector operation performed.
        /// </para>
        /// </summary>
        public ConnectorOperationType ConnectorOperationType
        {
            get { return this._connectorOperationType; }
            set { this._connectorOperationType = value; }
        }

        // Check to see if ConnectorOperationType property is set
        internal bool IsSetConnectorOperationType()
        {
            return this._connectorOperationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the operation ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo.
        /// </summary>
        public StateDescription ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property OperationSteps. 
        /// <para>
        /// The array of operation steps taken.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorOperationStep> OperationSteps
        {
            get { return this._operationSteps; }
            set { this._operationSteps = value; }
        }

        // Check to see if OperationSteps property is set
        internal bool IsSetOperationSteps()
        {
            return this._operationSteps != null && (this._operationSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginConnectorConfiguration. 
        /// <para>
        /// The origin connector configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> OriginConnectorConfiguration
        {
            get { return this._originConnectorConfiguration; }
            set { this._originConnectorConfiguration = value; }
        }

        // Check to see if OriginConnectorConfiguration property is set
        internal bool IsSetOriginConnectorConfiguration()
        {
            return this._originConnectorConfiguration != null && (this._originConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginWorkerSetting. 
        /// <para>
        /// The origin worker setting.
        /// </para>
        /// </summary>
        public WorkerSetting OriginWorkerSetting
        {
            get { return this._originWorkerSetting; }
            set { this._originWorkerSetting = value; }
        }

        // Check to see if OriginWorkerSetting property is set
        internal bool IsSetOriginWorkerSetting()
        {
            return this._originWorkerSetting != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConnectorConfiguration. 
        /// <para>
        /// The target connector configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> TargetConnectorConfiguration
        {
            get { return this._targetConnectorConfiguration; }
            set { this._targetConnectorConfiguration = value; }
        }

        // Check to see if TargetConnectorConfiguration property is set
        internal bool IsSetTargetConnectorConfiguration()
        {
            return this._targetConnectorConfiguration != null && (this._targetConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetWorkerSetting. 
        /// <para>
        /// The target worker setting.
        /// </para>
        /// </summary>
        public WorkerSetting TargetWorkerSetting
        {
            get { return this._targetWorkerSetting; }
            set { this._targetWorkerSetting = value; }
        }

        // Check to see if TargetWorkerSetting property is set
        internal bool IsSetTargetWorkerSetting()
        {
            return this._targetWorkerSetting != null;
        }

    }
}