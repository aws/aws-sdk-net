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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for sending VPN tunnel logs to CloudWatch.
    /// </summary>
    public partial class CloudWatchLogOptions
    {
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
        public bool? BgpLogEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BgpLogEnabled property is set.
        /// </summary>
        internal bool IsSetBgpLogEnabled() => this.BgpLogEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property BgpLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch log group for BGP logs.
        /// </para>
        /// </summary>
        public string BgpLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the BgpLogGroupArn property is set.
        /// </summary>
        internal bool IsSetBgpLogGroupArn() => this.BgpLogGroupArn != null;

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
        public string BgpLogOutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the BgpLogOutputFormat property is set.
        /// </summary>
        internal bool IsSetBgpLogOutputFormat() => this.BgpLogOutputFormat != null;

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
        public bool? LogEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LogEnabled property is set.
        /// </summary>
        internal bool IsSetLogEnabled() => this.LogEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.
        /// </para>
        /// </summary>
        public string LogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupArn property is set.
        /// </summary>
        internal bool IsSetLogGroupArn() => this.LogGroupArn != null;

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
        public string LogOutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogOutputFormat property is set.
        /// </summary>
        internal bool IsSetLogOutputFormat() => this.LogOutputFormat != null;
    }
}
