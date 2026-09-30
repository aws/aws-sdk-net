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

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about all brokers.
    /// </summary>
    public partial class BrokerSummary
    {
        /// <summary>
        /// Gets and sets the property BrokerArn. 
        /// <para>
        /// The broker's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string BrokerArn { get; set; }

        /// <summary>
        /// Checks to see if the BrokerArn property is set.
        /// </summary>
        internal bool IsSetBrokerArn() => this.BrokerArn != null;

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the broker.
        /// </para>
        /// </summary>
        public string BrokerId { get; set; }

        /// <summary>
        /// Checks to see if the BrokerId property is set.
        /// </summary>
        internal bool IsSetBrokerId() => this.BrokerId != null;

        /// <summary>
        /// Gets and sets the property BrokerName. 
        /// <para>
        /// The broker's name. This value is unique in your Amazon Web Services account, 1-50
        /// characters long, and containing only letters, numbers, dashes, and underscores, and
        /// must not contain white spaces, brackets, wildcard characters, or special characters.
        /// </para>
        /// </summary>
        public string BrokerName { get; set; }

        /// <summary>
        /// Checks to see if the BrokerName property is set.
        /// </summary>
        internal bool IsSetBrokerName() => this.BrokerName != null;

        /// <summary>
        /// Gets and sets the property BrokerState. 
        /// <para>
        /// The broker's status.
        /// </para>
        /// </summary>
        public BrokerState BrokerState { get; set; }

        /// <summary>
        /// Checks to see if the BrokerState property is set.
        /// </summary>
        internal bool IsSetBrokerState() => this.BrokerState != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time when the broker was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The broker's deployment mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of broker engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property HostInstanceType. 
        /// <para>
        /// The broker's instance type.
        /// </para>
        /// </summary>
        public string HostInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the HostInstanceType property is set.
        /// </summary>
        internal bool IsSetHostInstanceType() => this.HostInstanceType != null;
    }
}
