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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDestination operation.
    /// Creates or updates a destination. This operation is used only to create destinations
    /// for cross-account subscriptions.
    /// 
    ///  
    /// <para>
    /// A destination encapsulates a physical resource (such as an Amazon Kinesis stream).
    /// With a destination, you can subscribe to a real-time stream of log events for a different
    /// account, ingested using <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
    /// </para>
    ///  
    /// <para>
    /// Through an access policy, a destination controls what is written to it. By default,
    /// <code>PutDestination</code> does not set any access policy with the destination, which
    /// means a cross-account user cannot call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutSubscriptionFilter.html">PutSubscriptionFilter</a>
    /// against this destination. To enable this, the destination owner must call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>
    /// after <code>PutDestination</code>.
    /// </para>
    ///  
    /// <para>
    /// To perform a <code>PutDestination</code> operation, you must also have the <code>iam:PassRole</code>
    /// permission.
    /// </para>
    /// </summary>
    public partial class PutDestinationRequest : AmazonCloudWatchLogsRequest
    {
        private string _destinationName;
        private string _roleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// A name for the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that grants CloudWatch Logs permissions to call the Amazon
        /// Kinesis <code>PutRecord</code> operation on the destination stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN of an Amazon Kinesis stream to which to deliver matching log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}