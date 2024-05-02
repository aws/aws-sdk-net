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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about all brokers.
    /// </summary>
    public partial class BrokerSummary
    {
        private string _brokerArn;
        private string _brokerId;
        private string _brokerName;
        private BrokerState _brokerState;
        private DateTime? _created;
        private DeploymentMode _deploymentMode;
        private EngineType _engineType;
        private string _hostInstanceType;

        /// <summary>
        /// Gets and sets the property BrokerArn. 
        /// <para>
        /// The broker's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string BrokerArn
        {
            get { return this._brokerArn; }
            set { this._brokerArn = value; }
        }

        // Check to see if BrokerArn property is set
        internal bool IsSetBrokerArn()
        {
            return this._brokerArn != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the broker.
        /// </para>
        /// </summary>
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. This value is unique in your Amazon Web Services account, 1-50
        /// characters long, and containing only letters, numbers, dashes, and underscores, and
        /// must not contain white spaces, brackets, wildcard characters, or special characters.
        /// </para>
        /// </summary>
        public string BrokerName
        {
            get { return this._brokerName; }
            set { this._brokerName = value; }
        }

        // Check to see if BrokerName property is set
        internal bool IsSetBrokerName()
        {
            return this._brokerName != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerState. 
        /// <para>
        /// The broker's status.
        /// </para>
        /// </summary>
        public BrokerState BrokerState
        {
            get { return this._brokerState; }
            set { this._brokerState = value; }
        }

        // Check to see if BrokerState property is set
        internal bool IsSetBrokerState()
        {
            return this._brokerState != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time when the broker was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The broker's deployment mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentMode DeploymentMode
        {
            get { return this._deploymentMode; }
            set { this._deploymentMode = value; }
        }

        // Check to see if DeploymentMode property is set
        internal bool IsSetDeploymentMode()
        {
            return this._deploymentMode != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of broker engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property HostInstanceType. 
        /// <para>
        /// The broker's instance type.
        /// </para>
        /// </summary>
        public string HostInstanceType
        {
            get { return this._hostInstanceType; }
            set { this._hostInstanceType = value; }
        }

        // Check to see if HostInstanceType property is set
        internal bool IsSetHostInstanceType()
        {
            return this._hostInstanceType != null;
        }

    }
}