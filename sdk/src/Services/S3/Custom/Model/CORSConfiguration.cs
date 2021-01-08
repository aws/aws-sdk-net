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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A collection of up to 100 cross-origin resource sharing (CORS) rules.
    /// </summary>
    public class CORSConfiguration
    {
        
        private List<CORSRule> rules = new List<CORSRule>();

        /// <summary>
        /// The collection of rules in this configuration.
        /// </summary>
        public List<CORSRule> Rules
        {
            get { return this.rules; }
            set { this.rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this.rules.Count > 0;
        }
    }
}
