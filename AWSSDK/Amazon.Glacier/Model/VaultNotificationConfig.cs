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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Represents a vault's notification configuration.</para>
    /// </summary>
    public class VaultNotificationConfig  
    {
        
        private string sNSTopic;
        private List<string> events = new List<string>();

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic Amazon Resource Name (ARN).
        ///  
        /// </summary>
        public string SNSTopic
        {
            get { return this.sNSTopic; }
            set { this.sNSTopic = value; }
        }

        /// <summary>
        /// Sets the SNSTopic property
        /// </summary>
        /// <param name="sNSTopic">The value to set for the SNSTopic property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VaultNotificationConfig WithSNSTopic(string sNSTopic)
        {
            this.sNSTopic = sNSTopic;
            return this;
        }
            

        // Check to see if SNSTopic property is set
        internal bool IsSetSNSTopic()
        {
            return this.sNSTopic != null;       
        }

        /// <summary>
        /// A list of one or more events for which Amazon Glacier will send a notification to the specified Amazon SNS topic.
        ///  
        /// </summary>
        public List<string> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }
        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VaultNotificationConfig WithEvents(params string[] events)
        {
            foreach (string element in events)
            {
                this.events.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VaultNotificationConfig WithEvents(IEnumerable<string> events)
        {
            foreach (string element in events)
            {
                this.events.Add(element);
            }

            return this;
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;       
        }
    }
}
