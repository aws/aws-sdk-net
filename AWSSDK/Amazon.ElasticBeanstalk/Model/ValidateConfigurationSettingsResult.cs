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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Provides a list of validation messages.</para>
    /// </summary>
    public class ValidateConfigurationSettingsResult  
    {
        
        private List<ValidationMessage> messages = new List<ValidationMessage>();

        /// <summary>
        /// A list of <a>ValidationMessage</a>.
        ///  
        /// </summary>
        public List<ValidationMessage> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }
        /// <summary>
        /// Adds elements to the Messages collection
        /// </summary>
        /// <param name="messages">The values to add to the Messages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ValidateConfigurationSettingsResult WithMessages(params ValidationMessage[] messages)
        {
            foreach (ValidationMessage element in messages)
            {
                this.messages.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Messages collection
        /// </summary>
        /// <param name="messages">The values to add to the Messages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ValidateConfigurationSettingsResult WithMessages(IEnumerable<ValidationMessage> messages)
        {
            foreach (ValidationMessage element in messages)
            {
                this.messages.Add(element);
            }

            return this;
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this.messages.Count > 0;       
        }
    }
}
