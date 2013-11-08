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
    /// Container for the parameters to the GetTopicAttributes operation.
    /// <para>The <c>GetTopicAttributes</c> action returns all of the properties of a topic. Topic properties returned might differ based on the
    /// authorization of the user. </para>
    /// </summary>
    public partial class GetTopicAttributesRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        /// <summary>
        /// Default constructor for a new GetTopicAttributesRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public GetTopicAttributesRequest() {}
    
        /// <summary>
        /// Constructs a new GetTopicAttributesRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic whose properties you want to get. </param>
        public GetTopicAttributesRequest(string topicArn)
        {
            this.topicArn = topicArn;
        }
    

        /// <summary>
        /// The ARN of the topic whose properties you want to get.
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

    }
}
    
