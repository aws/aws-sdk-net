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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>The <c>TestRoleResponse</c> structure.</para>
    /// </summary>
    public partial class TestRoleResult : AmazonWebServiceResponse
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

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this.messages.Count > 0;
        }
    }
}
