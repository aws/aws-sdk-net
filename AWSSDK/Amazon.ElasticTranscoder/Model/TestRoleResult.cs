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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TestRoleResult
    {
        
        private string success;
        private List<string> messages = new List<string>();

        /// <summary>
        /// If the operation is successful, this value is <c>true</c>; otherwise, the value is <c>false</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^true$)|(^false$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Success
        {
            get { return this.success; }
            set { this.success = value; }
        }

        /// <summary>
        /// Sets the Success property
        /// </summary>
        /// <param name="success">The value to set for the Success property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TestRoleResult WithSuccess(string success)
        {
            this.success = success;
            return this;
        }
            

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this.success != null;
        }

        /// <summary>
        /// If the <c>Success</c> element contains <c>false</c>, this value is an array of one or more error messages that were generated during the
        /// test process.
        ///  
        /// </summary>
        public List<string> Messages
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
        public TestRoleResult WithMessages(params string[] messages)
        {
            foreach (string element in messages)
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
        public TestRoleResult WithMessages(IEnumerable<string> messages)
        {
            foreach (string element in messages)
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
