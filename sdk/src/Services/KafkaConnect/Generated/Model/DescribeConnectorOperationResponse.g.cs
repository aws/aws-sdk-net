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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnectorOperation operation.
    /// </summary>
    public partial class DescribeConnectorOperationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector operation.
        /// </para>
        /// </summary>
        public string ConnectorOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationArn property is set.
        /// </summary>
        internal bool IsSetConnectorOperationArn() => this.ConnectorOperationArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorOperationState. 
        /// <para>
        /// The state of the connector operation.
        /// </para>
        /// </summary>
        public ConnectorOperationState ConnectorOperationState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationState property is set.
        /// </summary>
        internal bool IsSetConnectorOperationState() => this.ConnectorOperationState != null;

        /// <summary>
        /// Gets and sets the property ConnectorOperationType. 
        /// <para>
        /// The type of connector operation performed.
        /// </para>
        /// </summary>
        public ConnectorOperationType ConnectorOperationType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationType property is set.
        /// </summary>
        internal bool IsSetConnectorOperationType() => this.ConnectorOperationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the operation ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo.
        /// </summary>
        public StateDescription ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property OperationSteps. 
        /// <para>
        /// The array of operation steps taken.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorOperationStep> OperationSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectorOperationStep>() : null;

        /// <summary>
        /// Checks to see if the OperationSteps property is set.
        /// </summary>
        internal bool IsSetOperationSteps() => this.OperationSteps != null && (this.OperationSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginConnectorConfiguration. 
        /// <para>
        /// The origin connector configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> OriginConnectorConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the OriginConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetOriginConnectorConfiguration() => this.OriginConnectorConfiguration != null && (this.OriginConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginWorkerSetting. 
        /// <para>
        /// The origin worker setting.
        /// </para>
        /// </summary>
        public WorkerSetting OriginWorkerSetting { get; set; }

        /// <summary>
        /// Checks to see if the OriginWorkerSetting property is set.
        /// </summary>
        internal bool IsSetOriginWorkerSetting() => this.OriginWorkerSetting != null;

        /// <summary>
        /// Gets and sets the property TargetConnectorConfiguration. 
        /// <para>
        /// The target connector configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> TargetConnectorConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TargetConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConnectorConfiguration() => this.TargetConnectorConfiguration != null && (this.TargetConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetWorkerSetting. 
        /// <para>
        /// The target worker setting.
        /// </para>
        /// </summary>
        public WorkerSetting TargetWorkerSetting { get; set; }

        /// <summary>
        /// Checks to see if the TargetWorkerSetting property is set.
        /// </summary>
        internal bool IsSetTargetWorkerSetting() => this.TargetWorkerSetting != null;
    }
}
