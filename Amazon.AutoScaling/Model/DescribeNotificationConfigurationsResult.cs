/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The output of the DescribeNotificationConfigurations action.</para>
    /// </summary>
    public class DescribeNotificationConfigurationsResult  
    {
        
        private List<NotificationConfiguration> notificationConfigurations = new List<NotificationConfiguration>();
        private string nextToken;

        /// <summary>
        /// The list of notification configurations.<i>Should we be clearer?</i>>
        ///  
        /// </summary>
        public List<NotificationConfiguration> NotificationConfigurations
        {
            get { return this.notificationConfigurations; }
            set { this.notificationConfigurations = value; }
        }
        /// <summary>
        /// Adds elements to the NotificationConfigurations collection
        /// </summary>
        /// <param name="notificationConfigurations">The values to add to the NotificationConfigurations collection </param>
        /// <returns>this instance</returns>
        public DescribeNotificationConfigurationsResult WithNotificationConfigurations(params NotificationConfiguration[] notificationConfigurations)
        {
            foreach (NotificationConfiguration element in notificationConfigurations)
            {
                this.notificationConfigurations.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the NotificationConfigurations collection
        /// </summary>
        /// <param name="notificationConfigurations">The values to add to the NotificationConfigurations collection </param>
        /// <returns>this instance</returns>
        public DescribeNotificationConfigurationsResult WithNotificationConfigurations(IEnumerable<NotificationConfiguration> notificationConfigurations)
        {
            foreach (NotificationConfiguration element in notificationConfigurations)
            {
                this.notificationConfigurations.Add(element);
            }

            return this;
        }

        // Check to see if NotificationConfigurations property is set
        internal bool IsSetNotificationConfigurations()
        {
            return this.notificationConfigurations.Count > 0;       
        }

        /// <summary>
        /// A string that is used to mark the start of the next batch of returned results for pagination.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeNotificationConfigurationsResult WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
