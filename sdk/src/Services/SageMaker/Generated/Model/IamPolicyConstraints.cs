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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Use this parameter to specify a supported global condition key that is added to the
    /// IAM policy.
    /// </summary>
    public partial class IamPolicyConstraints
    {
        private EnabledOrDisabled _sourceIp;
        private EnabledOrDisabled _vpcSourceIp;

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// When <c>SourceIp</c> is <c>Enabled</c> the worker's IP address when a task is rendered
        /// in the worker portal is added to the IAM policy as a <c>Condition</c> used to generate
        /// the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match
        /// in order for the Amazon S3 resource to be rendered in the worker portal.
        /// </para>
        /// </summary>
        public EnabledOrDisabled SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSourceIp. 
        /// <para>
        /// When <c>VpcSourceIp</c> is <c>Enabled</c> the worker's IP address when a task is rendered
        /// in private worker portal inside the VPC is added to the IAM policy as a <c>Condition</c>
        /// used to generate the Amazon S3 presigned URL. To render the task successfully Amazon
        /// S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint,
        /// and that the worker's IP address matches the IP address in the IAM policy. To learn
        /// more about configuring private worker portal, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/samurai-vpc-worker-portal.html">Use
        /// Amazon VPC mode from a private worker portal</a>.
        /// </para>
        /// </summary>
        public EnabledOrDisabled VpcSourceIp
        {
            get { return this._vpcSourceIp; }
            set { this._vpcSourceIp = value; }
        }

        // Check to see if VpcSourceIp property is set
        internal bool IsSetVpcSourceIp()
        {
            return this._vpcSourceIp != null;
        }

    }
}