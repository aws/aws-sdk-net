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

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>TestRoleResponse</code> structure.
    /// </summary>
    public partial class TestRoleResponse : AmazonWebServiceResponse
    {
        private List<string> _messages = new List<string>();
        private string _success;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// If the <code>Success</code> element contains <code>false</code>, this value is an
        /// array of one or more error messages that were generated during the test process.
        /// </para>
        /// </summary>
        public List<string> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && this._messages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// If the operation is successful, this value is <code>true</code>; otherwise, the value
        /// is <code>false</code>.
        /// </para>
        /// </summary>
        public string Success
        {
            get { return this._success; }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success != null;
        }

    }
}