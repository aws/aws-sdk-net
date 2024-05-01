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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Lustre logging configuration used when creating or updating an Amazon FSx for
    /// Lustre file system. An Amazon File Cache is created with Lustre logging enabled by
    /// default, with a setting of <c>WARN_ERROR</c> for the logging events. which can't be
    /// changed.
    /// 
    ///  
    /// <para>
    /// Lustre logging writes the enabled logging events for your file system or cache to
    /// Amazon CloudWatch Logs.
    /// </para>
    /// </summary>
    public partial class LustreLogCreateConfiguration
    {
        private string _destination;
        private LustreAccessAuditLogLevel _level;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Resource Name (ARN) that specifies the destination of the logs.
        /// </para>
        ///  
        /// <para>
        /// The destination can be any Amazon CloudWatch Logs log group ARN, with the following
        /// requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The destination ARN that you provide must be in the same Amazon Web Services partition,
        /// Amazon Web Services Region, and Amazon Web Services account as your Amazon FSx file
        /// system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log group must begin with the <c>/aws/fsx</c>
        /// prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you do not provide a destination, Amazon FSx will create and use a log stream in
        /// the CloudWatch Logs <c>/aws/fsx/lustre</c> log group (for Amazon FSx for Lustre) or
        /// <c>/aws/fsx/filecache</c> (for Amazon File Cache).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Destination</c> is provided and the resource does not exist, the request will
        /// fail with a <c>BadRequest</c> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Level</c> is set to <c>DISABLED</c>, you cannot specify a destination in <c>Destination</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Sets which data repository events are logged by Amazon FSx.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WARN_ONLY</c> - only warning events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR_ONLY</c> - only error events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARN_ERROR</c> - both warning events and error events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - logging of data repository events is turned off.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public LustreAccessAuditLogLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

    }
}