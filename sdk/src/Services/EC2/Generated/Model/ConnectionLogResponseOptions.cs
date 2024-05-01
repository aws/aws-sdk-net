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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the client connection logging options for a Client VPN endpoint.
    /// </summary>
    public partial class ConnectionLogResponseOptions
    {
        private string _cloudwatchLogGroup;
        private string _cloudwatchLogStream;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property CloudwatchLogGroup. 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log group to which connection logging data
        /// is published.
        /// </para>
        /// </summary>
        public string CloudwatchLogGroup
        {
            get { return this._cloudwatchLogGroup; }
            set { this._cloudwatchLogGroup = value; }
        }

        // Check to see if CloudwatchLogGroup property is set
        internal bool IsSetCloudwatchLogGroup()
        {
            return this._cloudwatchLogGroup != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchLogStream. 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log stream to which connection logging data
        /// is published.
        /// </para>
        /// </summary>
        public string CloudwatchLogStream
        {
            get { return this._cloudwatchLogStream; }
            set { this._cloudwatchLogStream = value; }
        }

        // Check to see if CloudwatchLogStream property is set
        internal bool IsSetCloudwatchLogStream()
        {
            return this._cloudwatchLogStream != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether client connection logging is enabled for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}