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
    /// Options for sending VPN tunnel logs to CloudWatch.
    /// </summary>
    public partial class CloudWatchLogOptions
    {
        private bool? _bgpLogEnabled;
        private string _bgpLogGroupArn;
        private string _bgpLogOutputFormat;
        private bool? _logEnabled;
        private string _logGroupArn;
        private string _logOutputFormat;

        /// <summary>
        /// Gets and sets the property BgpLogEnabled. 
        /// <para>
        /// Indicates whether Border Gateway Protocol (BGP) logging is enabled for the VPN connection.
        /// Default value is <c>False</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>True</c> | <c>False</c> 
        /// </para>
        /// </summary>
        public bool BgpLogEnabled
        {
            get { return this._bgpLogEnabled.GetValueOrDefault(); }
            set { this._bgpLogEnabled = value; }
        }

        // Check to see if BgpLogEnabled property is set
        internal bool IsSetBgpLogEnabled()
        {
            return this._bgpLogEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BgpLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch log group for BGP logs.
        /// </para>
        /// </summary>
        public string BgpLogGroupArn
        {
            get { return this._bgpLogGroupArn; }
            set { this._bgpLogGroupArn = value; }
        }

        // Check to see if BgpLogGroupArn property is set
        internal bool IsSetBgpLogGroupArn()
        {
            return this._bgpLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BgpLogOutputFormat. 
        /// <para>
        /// The output format for BGP logs sent to CloudWatch. Default format is <c>json</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>json</c> | <c>text</c> 
        /// </para>
        /// </summary>
        public string BgpLogOutputFormat
        {
            get { return this._bgpLogOutputFormat; }
            set { this._bgpLogOutputFormat = value; }
        }

        // Check to see if BgpLogOutputFormat property is set
        internal bool IsSetBgpLogOutputFormat()
        {
            return this._bgpLogOutputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property LogEnabled. 
        /// <para>
        /// Status of VPN tunnel logging feature. Default value is <c>False</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>True</c> | <c>False</c> 
        /// </para>
        /// </summary>
        public bool LogEnabled
        {
            get { return this._logEnabled.GetValueOrDefault(); }
            set { this._logEnabled = value; }
        }

        // Check to see if LogEnabled property is set
        internal bool IsSetLogEnabled()
        {
            return this._logEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.
        /// </para>
        /// </summary>
        public string LogGroupArn
        {
            get { return this._logGroupArn; }
            set { this._logGroupArn = value; }
        }

        // Check to see if LogGroupArn property is set
        internal bool IsSetLogGroupArn()
        {
            return this._logGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogOutputFormat. 
        /// <para>
        /// Configured log format. Default format is <c>json</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>json</c> | <c>text</c> 
        /// </para>
        /// </summary>
        public string LogOutputFormat
        {
            get { return this._logOutputFormat; }
            set { this._logOutputFormat = value; }
        }

        // Check to see if LogOutputFormat property is set
        internal bool IsSetLogOutputFormat()
        {
            return this._logOutputFormat != null;
        }

    }
}