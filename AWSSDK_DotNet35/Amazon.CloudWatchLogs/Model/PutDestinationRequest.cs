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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDestination operation.
    /// Creates or updates a <code>Destination</code>. A destination encapsulates a physical
    /// resource (such as a Kinesis stream) and allows you to subscribe to a real-time stream
    /// of log events of a different account, ingested through <code class="code">PutLogEvents</code>
    /// requests. Currently, the only supported physical resource is a Amazon Kinesis stream
    /// belonging to the same account as the destination. 
    /// 
    ///  
    /// <para>
    ///  A destination controls what is written to its Amazon Kinesis stream through an access
    /// policy. By default, PutDestination does not set any access policy with the destination,
    /// which means a cross-account user will not be able to call <code>PutSubscriptionFilter</code>
    /// against this destination. To enable that, the destination owner must call <code>PutDestinationPolicy</code>
    /// after PutDestination. 
    /// </para>
    /// </summary>
    public partial class PutDestinationRequest : AmazonCloudWatchLogsRequest
    {
        private string _destinationName;
        private string _roleArn;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// A name for the destination.
        /// </para>
        /// </summary>
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
        /// The ARN of an IAM role that grants CloudWatch Logs permissions to do Amazon Kinesis
        /// PutRecord requests on the desitnation stream.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN of an Amazon Kinesis stream to deliver matching log events to.
        /// </para>
        /// </summary>
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