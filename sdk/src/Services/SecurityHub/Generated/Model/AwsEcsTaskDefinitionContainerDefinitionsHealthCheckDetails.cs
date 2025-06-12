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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The container health check command and associated configuration parameters for the
    /// container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetails
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _interval;
        private int? _retries;
        private int? _startPeriod;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that the container runs to determine whether it is healthy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The time period in seconds between each health check execution. The default value
        /// is 30 seconds.
        /// </para>
        /// </summary>
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
        /// The number of times to retry a failed health check before the container is considered
        /// unhealthy. The default value is 3.
        /// </para>
        /// </summary>
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
        /// The optional grace period in seconds that allows containers time to bootstrap before
        /// failed health checks count towards the maximum number of retries.
        /// </para>
        /// </summary>
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
        /// The time period in seconds to wait for a health check to succeed before it is considered
        /// a failure. The default value is 5.
        /// </para>
        /// </summary>
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