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
    /// Removes a statement from a topic's access control policy.
    /// </summary>
    public partial class RemovePermissionRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _label;
        private string _topicArn;


        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The unique label of the statement you want to remove.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }


        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the topic whose access control policy you wish to modify.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}