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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public class AddCommunicationToCaseResult
    {
        
        private bool? result;

        /// <summary>
        /// Returns true if the <a href="API_AddCommunicationToCase.html" title="AddCommunicationToCase">AddCommunicationToCase</a> succeeds. Returns an
        /// error otherwise.
        ///  
        /// </summary>
        public bool Result
        {
            get { return this.result ?? default(bool); }
            set { this.result = value; }
        }

        /// <summary>
        /// Sets the Result property
        /// </summary>
        /// <param name="result">The value to set for the Result property </param>
        /// <returns>this instance</returns>
        public AddCommunicationToCaseResult WithResult(bool result)
        {
            this.result = result;
            return this;
        }
            

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this.result.HasValue;
        }
    }
}
