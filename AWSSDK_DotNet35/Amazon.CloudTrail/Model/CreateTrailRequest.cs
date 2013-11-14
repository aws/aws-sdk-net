/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrail operation.
    /// <para>From the command line, use create-subscription. </para> <para>Creates a trail that specifies the settings for delivery of log data to
    /// an Amazon S3 bucket. The request includes a Trail structure that specifies the following:</para>
    /// <ul>
    /// <li>Trail name.</li>
    /// <li>The name of an existing Amazon S3 bucket to which CloudTrail delivers your log files.</li>
    /// <li>The name of the Amazon S3 key prefix that precedes each log file.</li>
    /// <li>The name of an existing Amazon SNS topic that notifies you that a new file is available in your bucket.</li>
    /// <li>Whether the log file should include AWS API calls from global services. Currently, the only global AWS API calls included in CloudTrail
    /// log files are from IAM and AWS STS.</li>
    /// 
    /// </ul>
    /// </summary>
    public partial class CreateTrailRequest : AmazonCloudTrailRequest
    {
        private Trail trail;


        /// <summary>
        /// Contains the <a>Trail</a> structure that specifies the settings for each trail.
        ///  
        /// </summary>
        public Trail Trail
        {
            get { return this.trail; }
            set { this.trail = value; }
        }

        // Check to see if Trail property is set
        internal bool IsSetTrail()
        {
            return this.trail != null;
        }

    }
}
    
