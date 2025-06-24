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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Instructions on when and how to check the health of a support container in a container
    /// fleet. These properties override any Docker health checks that are set in the container
    /// image. For more information on container health checks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_HealthCheck.html#ECS-Type-HealthCheck-command">HealthCheck
    /// command</a> in the <i>Amazon Elastic Container Service API</i>. Game server containers
    /// don't have a health check parameter; Amazon GameLift Servers automatically handles
    /// health checks for these containers.
    /// 
    ///  
    /// <para>
    /// The following example instructs the container to initiate a health check command every
    /// 60 seconds and wait 10 seconds for it to succeed. If it fails, retry the command 3
    /// times before flagging the container as unhealthy. It also tells the container to wait
    /// 100 seconds after launch before counting failed health checks.
    /// </para>
    ///  
    /// <para>
    ///  <c>{"Command": [ "CMD-SHELL", "ps cax | grep "processmanager" || exit 1" ], "Interval":
    /// 60, "Timeout": 10, "Retries": 3, "StartPeriod": 100 }</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html">SupportContainerDefinitionInput</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerHealthCheck
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _interval;
        private int? _retries;
        private int? _startPeriod;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// A string array that specifies the command that the container runs to determine if
        /// it's healthy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time period (in seconds) between each health check.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=300)]
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retries. 
        /// <para>
        /// The number of times to retry a failed health check before flagging the container unhealthy.
        /// The first run of the command does not count as a retry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=10)]
        public int? Retries
        {
            get { return this._retries; }
            set { this._retries = value; }
        }

        // Check to see if Retries property is set
        internal bool IsSetRetries()
        {
            return this._retries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartPeriod. 
        /// <para>
        /// The optional grace period (in seconds) to give a container time to bootstrap before
        /// the first failed health check counts toward the number of retries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int? StartPeriod
        {
            get { return this._startPeriod; }
            set { this._startPeriod = value; }
        }

        // Check to see if StartPeriod property is set
        internal bool IsSetStartPeriod()
        {
            return this._startPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The time period (in seconds) to wait for a health check to succeed before counting
        /// a failed health check. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=60)]
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}