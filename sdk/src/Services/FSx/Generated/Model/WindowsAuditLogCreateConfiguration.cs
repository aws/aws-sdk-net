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
    /// The Windows file access auditing configuration used when creating or updating an Amazon
    /// FSx for Windows File Server file system.
    /// </summary>
    public partial class WindowsAuditLogCreateConfiguration
    {
        private string _auditLogDestination;
        private WindowsAccessAuditLogLevel _fileAccessAuditLogLevel;
        private WindowsAccessAuditLogLevel _fileShareAccessAuditLogLevel;

        /// <summary>
        /// Gets and sets the property AuditLogDestination. 
        /// <para>
        /// The Amazon Resource Name (ARN) that specifies the destination of the audit logs.
        /// </para>
        ///  
        /// <para>
        /// The destination can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis
        /// Data Firehose delivery stream ARN, with the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The destination ARN that you provide (either CloudWatch Logs log group or Kinesis
        /// Data Firehose delivery stream) must be in the same Amazon Web Services partition,
        /// Amazon Web Services Region, and Amazon Web Services account as your Amazon FSx file
        /// system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log group must begin with the <c>/aws/fsx</c>
        /// prefix. The name of the Amazon Kinesis Data Firehose delivery stream must begin with
        /// the <c>aws-fsx</c> prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you do not provide a destination in <c>AuditLogDestination</c>, Amazon FSx will
        /// create and use a log stream in the CloudWatch Logs <c>/aws/fsx/windows</c> log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>AuditLogDestination</c> is provided and the resource does not exist, the request
        /// will fail with a <c>BadRequest</c> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>FileAccessAuditLogLevel</c> and <c>FileShareAccessAuditLogLevel</c> are both
        /// set to <c>DISABLED</c>, you cannot specify a destination in <c>AuditLogDestination</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string AuditLogDestination
        {
            get { return this._auditLogDestination; }
            set { this._auditLogDestination = value; }
        }

        // Check to see if AuditLogDestination property is set
        internal bool IsSetAuditLogDestination()
        {
            return this._auditLogDestination != null;
        }

        /// <summary>
        /// Gets and sets the property FileAccessAuditLogLevel. 
        /// <para>
        /// Sets which attempt type is logged by Amazon FSx for file and folder accesses.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCESS_ONLY</c> - only successful attempts to access files or folders are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILURE_ONLY</c> - only failed attempts to access files or folders are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS_AND_FAILURE</c> - both successful attempts and failed attempts to access
        /// files or folders are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - access auditing of files and folders is turned off.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WindowsAccessAuditLogLevel FileAccessAuditLogLevel
        {
            get { return this._fileAccessAuditLogLevel; }
            set { this._fileAccessAuditLogLevel = value; }
        }

        // Check to see if FileAccessAuditLogLevel property is set
        internal bool IsSetFileAccessAuditLogLevel()
        {
            return this._fileAccessAuditLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareAccessAuditLogLevel. 
        /// <para>
        /// Sets which attempt type is logged by Amazon FSx for file share accesses.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCESS_ONLY</c> - only successful attempts to access file shares are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILURE_ONLY</c> - only failed attempts to access file shares are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS_AND_FAILURE</c> - both successful attempts and failed attempts to access
        /// file shares are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - access auditing of file shares is turned off.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WindowsAccessAuditLogLevel FileShareAccessAuditLogLevel
        {
            get { return this._fileShareAccessAuditLogLevel; }
            set { this._fileShareAccessAuditLogLevel = value; }
        }

        // Check to see if FileShareAccessAuditLogLevel property is set
        internal bool IsSetFileShareAccessAuditLogLevel()
        {
            return this._fileShareAccessAuditLogLevel != null;
        }

    }
}