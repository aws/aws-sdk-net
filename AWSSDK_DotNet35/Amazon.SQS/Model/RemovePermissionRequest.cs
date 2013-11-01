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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the RemovePermission operation.
    /// <para>The <c>RemovePermission</c> action revokes any permissions in the queue policy that matches the specified <c>Label</c> parameter. Only
    /// the owner of the queue can remove permissions.</para>
    /// </summary>
    public partial class RemovePermissionRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string label;


        /// <summary>
        /// The URL of the SQS queue to take action on.
        ///  
        /// </summary>
        public string QueueUrl
        {
            get { return this.queueUrl; }
            set { this.queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this.queueUrl != null;
        }

        /// <summary>
        /// The identification of the permission to remove. This is the label added with the <a>AddPermission</a> operation.
        ///  
        /// </summary>
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this.label != null;
        }

    }
}
    
