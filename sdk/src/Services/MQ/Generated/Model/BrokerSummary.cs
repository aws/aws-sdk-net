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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the broker.
    /// </summary>
    public partial class BrokerSummary
    {
        private string _brokerArn;
        private string _brokerId;
        private string _brokerName;
        private BrokerState _brokerState;
        private DateTime? _created;
        private DeploymentMode _deploymentMode;
        private string _hostInstanceType;

        /// <summary>
        /// Gets and sets the property BrokerArn. The Amazon Resource Name (ARN) of the broker.
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
        /// Gets and sets the property BrokerId. The unique ID that Amazon MQ generates for the
        /// broker.
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
        /// Gets and sets the property BrokerName. The name of the broker. This value must be
        /// unique in your AWS account, 1-50 characters long, must contain only letters, numbers,
        /// dashes, and underscores, and must not contain whitespaces, brackets, wildcard characters,
        /// or special characters.
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
        /// Gets and sets the property BrokerState. The status of the broker.
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
        /// Gets and sets the property Created. The time when the broker was created.
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentMode. Required. The deployment mode of the broker.
        /// </summary>
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
        /// Gets and sets the property HostInstanceType. The broker's instance type.
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