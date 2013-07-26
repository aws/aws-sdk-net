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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the RemovePermission operation.
    /// <para>The <c>RemovePermission</c> action removes a statement from a topic's access control policy.</para>
    /// </summary>
    public partial class RemovePermissionRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string label;
        /// <summary>
        /// Default constructor for a new RemovePermissionRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public RemovePermissionRequest() {}
    
        /// <summary>
        /// Constructs a new RemovePermissionRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic whose access control policy you wish to modify. </param>
        /// <param name="label"> The unique label of the statement you want to remove. </param>
        public RemovePermissionRequest(string topicArn, string label)
        {
            this.topicArn = topicArn;
            this.label = label;
        }
    

        /// <summary>
        /// The ARN of the topic whose access control policy you wish to modify.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// The unique label of the statement you want to remove.
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
    
