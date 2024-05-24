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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetTopicRuleDestination operation.
    /// </summary>
    public partial class GetTopicRuleDestinationResponse : AmazonWebServiceResponse
    {
        private TopicRuleDestination _topicRuleDestination;

        /// <summary>
        /// Gets and sets the property TopicRuleDestination. 
        /// <para>
        /// The topic rule destination.
        /// </para>
        /// </summary>
        public TopicRuleDestination TopicRuleDestination
        {
            get { return this._topicRuleDestination; }
            set { this._topicRuleDestination = value; }
        }

        // Check to see if TopicRuleDestination property is set
        internal bool IsSetTopicRuleDestination()
        {
            return this._topicRuleDestination != null;
        }

    }
}