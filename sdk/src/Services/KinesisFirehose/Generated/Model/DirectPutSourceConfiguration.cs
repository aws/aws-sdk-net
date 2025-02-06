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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The structure that configures parameters such as <c>ThroughputHintInMBs</c> for a
    /// stream configured with Direct PUT as a source.
    /// </summary>
    public partial class DirectPutSourceConfiguration
    {
        private int? _throughputHintInMBs;

        /// <summary>
        /// Gets and sets the property ThroughputHintInMBs. 
        /// <para>
        ///  The value that you configure for this parameter is for information purpose only and
        /// does not affect Firehose delivery throughput limit. You can use the <a href="https://support.console.aws.amazon.com/support/home#/case/create%3FissueType=service-limit-increase%26limitType=kinesis-firehose-limits">Firehose
        /// Limits form</a> to request a throughput limit increase. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int? ThroughputHintInMBs
        {
            get { return this._throughputHintInMBs; }
            set { this._throughputHintInMBs = value; }
        }

        // Check to see if ThroughputHintInMBs property is set
        internal bool IsSetThroughputHintInMBs()
        {
            return this._throughputHintInMBs.HasValue; 
        }

    }
}