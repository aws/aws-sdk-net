﻿/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Represents a topic configuration for notification configuration. A topic configuration contains
    /// an event and a topic arn.
    /// </summary>
    public  class TopicConfiguration
    {
        private string evnt;
        private string topic;

        /// <summary>
        /// Gets and sets the Event property.
        /// </summary>
        public string Event
        {
            get
            {
                return this.evnt;
            }
            set
            {
                this.evnt = value;
            }
        }

        /// <summary>
        /// Sets the Event property.
        /// </summary>
        /// <param name="evnt">Event property</param>
        /// <returns>this instance</returns>
        public TopicConfiguration WithEvent(string evnt)
        {
            this.evnt = evnt;
            return this;
        }

        /// <summary>
        /// Gets and sets the Topic property.
        /// </summary>
        public string Topic
        {
            get
            {
                return this.topic;
            }
            set
            {
                this.topic = value;
            }
        }

        /// <summary>
        /// Sets the Topic property.
        /// </summary>
        /// <param name="topic">Topic property</param>
        /// <returns>this instance</returns>
        public TopicConfiguration WithTopic(string topic)
        {
            this.topic = topic;
            return this;
        }

        /// <summary>
        /// Creates a string representation of a topic configuration.
        /// </summary>
        /// <returns>The string representation of the topic configuration.</returns>
        public override string ToString()
        {
            return this.ToXML();
        }

        /// <summary>
        /// Creates a xml representation of a topic configuration.
        /// </summary>
        /// <returns>The xml representation of the topic configuration.</returns>
        internal string ToXML()
        {
            string xml = string.Format(
                " <TopicConfiguration>"+
                "       <Topic>{0}</Topic>"+
                "       <Event>{1}</Event>" +
                "</TopicConfiguration>", this.Topic, this.Event);
            return xml;
        }
    }
}
