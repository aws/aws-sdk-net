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
    /// Container for the parameters to the CreateTopic operation.
    /// <para>The <c>CreateTopic</c> action creates a topic to which notifications can be published. Users can create at most 3000 topics. For more
    /// information, see <a href="http://aws.amazon.com/sns/" >http://aws.amazon.com/sns</a> .
    /// This action is idempotent, so if the requester already owns a topic with the specified name, that topic's ARN is returned without
    /// creating a new topic.</para>
    /// </summary>
    public partial class CreateTopicRequest : AmazonSimpleNotificationServiceRequest
    {
        private string name;

        /// <summary>
        /// Default constructor for a new CreateTopicRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateTopicRequest() {}
    
        /// <summary>
        /// Constructs a new CreateTopicRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="name"> The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII
        /// letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long. </param>
        public CreateTopicRequest(string name)
        {
            this.name = name;
        }
    

        /// <summary>
        /// The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers,
        /// underscores, and hyphens, and must be between 1 and 256 characters long.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

    }
}
    
