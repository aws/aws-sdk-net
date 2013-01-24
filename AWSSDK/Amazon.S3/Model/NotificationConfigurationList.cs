/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The notification configuration for a bucket in S3. 
    /// </summary>
    /// <remarks>
    /// A configuration is a collection of topic configurations which contain the event
    /// and topic arn.  Currently only one event type is being supported with the possiblity of 
    /// more event types in the future.
    /// </remarks>
    public class NotificationConfigurationList
    {
        private List<TopicConfiguration> topicConfigurations = new List<TopicConfiguration>();

        /// <summary>
        /// The topic configurations included in this notification configuration. 
        /// </summary>
        public List<TopicConfiguration> TopicConfigurations
        {
            get { return this.topicConfigurations; }
        }

        /// <summary>
        /// Adds new topic configurations to the set belonging to this notification configuration.
        /// </summary>
        /// <param name="args">Topic configurations to add</param>
        /// <returns>this instance</returns>
        public NotificationConfigurationList WithTopicConfigurations(params TopicConfiguration[] args)
        {
            foreach (TopicConfiguration arg in args)
            {
                topicConfigurations.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Creates a string representation of a NotificationConfigurationlist.
        /// </summary>
        /// <returns>The string representation of the NotificationConfigurationlist.</returns>
        public override string ToString()
        {
            return this.ToXML();
        }

        /// <summary>
        /// Creates a xml representation of a NotificationConfigurationlist.
        /// </summary>
        /// <returns>The xml representation of the NotificationConfigurationlist.</returns>
        internal string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<NotificationConfiguration xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">");
            foreach (TopicConfiguration topicConfig in this.topicConfigurations)
            {
                sb.Append(topicConfig.ToXML());
            }
            sb.Append("</NotificationConfiguration>");
            return sb.ToString();
        }

    }
}
