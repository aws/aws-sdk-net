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
        /// The Amazon Resource Name (ARN) of the accelerator that you want to update.
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
        /// Update whether flow logs are enabled.
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
        /// Update the name of the Amazon S3 bucket for the flow logs.
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
        /// Update the prefix for the location in the Amazon S3 bucket for the flow logs.
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