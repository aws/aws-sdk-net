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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourceMetricsConfiguration operation.
    /// Deletes the resource metrics configuration for an Amazon Web Services resource. After
    /// you delete the configuration, Amazon CloudWatch stops collecting detailed metrics
    /// for the resource. Metric data that Amazon CloudWatch already collected for the resource
    /// is not deleted.
    /// 
    ///  
    /// <para>
    /// This operation returns a <c>ResourceNotFoundException</c> if no resource metrics configuration
    /// exists for the specified resource ARN. Verify that the resource ARN is correct.
    /// </para>
    ///  
    /// <para>
    /// To delete a resource metrics configuration, you must have the <c>cloudwatch:DeleteResourceMetricsConfiguration</c>
    /// permission. For information about scoping this permission to specific resources, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/iam-cw-condition-keys-resource-arn.html">Condition
    /// keys for resource metrics configuration access</a> in the <i>Amazon CloudWatch User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteResourceMetricsConfigurationRequest : AmazonCloudWatchRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services resource to delete the resource
        /// metrics configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}