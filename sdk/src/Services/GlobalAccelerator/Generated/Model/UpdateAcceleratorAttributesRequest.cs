/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAcceleratorAttributes operation.
    /// Update the attributes for an accelerator. To see an AWS CLI example of updating an
    /// accelerator to enable flow logs, scroll down to <b>Example</b>.
    /// </summary>
    public partial class UpdateAcceleratorAttributesRequest : AmazonGlobalAcceleratorRequest
    {
        private string _acceleratorArn;
        private bool? _flowLogsEnabled;
        private string _flowLogsS3Bucket;
        private string _flowLogsS3Prefix;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the accelerator that you want to update. Attribute
        /// is required.
        /// </para>
        /// </summary>
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
        /// true, <code>FlowLogsS3Bucket</code> and <code>FlowLogsS3Prefix</code> must be specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/monitoring-global-accelerator.flow-logs.html">Flow
        /// Logs</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool FlowLogsEnabled
        {
            get { return this._flowLogsEnabled.GetValueOrDefault(); }
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
        /// The name of the Amazon S3 bucket for the flow logs. Attribute is required if <code>FlowLogsEnabled</code>
        /// is <code>true</code>. The bucket must exist and have a bucket policy that grants AWS
        /// Global Accelerator permission to write to the bucket.
        /// </para>
        /// </summary>
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
        /// is required if <code>FlowLogsEnabled</code> is <code>true</code>. If you don’t specify
        /// a prefix, the flow logs are stored in the root of the bucket.
        /// </para>
        /// </summary>
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