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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomRoutingAcceleratorAttributes operation.
    /// Update the attributes for a custom routing accelerator.
    /// </summary>
    public partial class UpdateCustomRoutingAcceleratorAttributesRequest : AmazonGlobalAcceleratorRequest
    {
        private string _acceleratorArn;
        private bool? _flowLogsEnabled;
        private string _flowLogsS3Bucket;
        private string _flowLogsS3Prefix;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom routing accelerator to update attributes
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogsEnabled. 
        /// <para>
        /// Update whether flow logs are enabled. The default value is false. If the value is
        /// true, <c>FlowLogsS3Bucket</c> and <c>FlowLogsS3Prefix</c> must be specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/monitoring-global-accelerator.flow-logs.html">Flow
        /// logs</a> in the <i>Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? FlowLogsEnabled
        {
            get { return this._flowLogsEnabled; }
            set { this._flowLogsEnabled = value; }
        }

        // Check to see if FlowLogsEnabled property is set
        internal bool IsSetFlowLogsEnabled()
        {
            return this._flowLogsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlowLogsS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket for the flow logs. Attribute is required if <c>FlowLogsEnabled</c>
        /// is <c>true</c>. The bucket must exist and have a bucket policy that grants Global
        /// Accelerator permission to write to the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string FlowLogsS3Bucket
        {
            get { return this._flowLogsS3Bucket; }
            set { this._flowLogsS3Bucket = value; }
        }

        // Check to see if FlowLogsS3Bucket property is set
        internal bool IsSetFlowLogsS3Bucket()
        {
            return this._flowLogsS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogsS3Prefix. 
        /// <para>
        /// Update the prefix for the location in the Amazon S3 bucket for the flow logs. Attribute
        /// is required if <c>FlowLogsEnabled</c> is <c>true</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you don’t specify a prefix, the flow logs are stored in the root of the bucket.
        /// If you specify slash (/) for the S3 bucket prefix, the log file bucket folder structure
        /// will include a double slash (//), like the following:
        /// </para>
        ///  
        /// <para>
        /// DOC-EXAMPLE-BUCKET//AWSLogs/aws_account_id
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string FlowLogsS3Prefix
        {
            get { return this._flowLogsS3Prefix; }
            set { this._flowLogsS3Prefix = value; }
        }

        // Check to see if FlowLogsS3Prefix property is set
        internal bool IsSetFlowLogsS3Prefix()
        {
            return this._flowLogsS3Prefix != null;
        }

    }
}