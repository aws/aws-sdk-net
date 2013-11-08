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

namespace Amazon.S3.Model
{
    /// <summary>C O R S Rule
    /// </summary>
    public class CORSRule
    {
        private string id;
        private List<string> allowedMethods = new List<string>();
        private List<string> allowedOrigins = new List<string>();
        private List<string> exposeHeaders = new List<string>();
        private List<string> allowedHeaders = new List<string>();
        private int? maxAgeSeconds;

        /// <summary>
        /// Identifies HTTP methods that the domain/origin specified in the rule is allowed to execute.
        ///  
        /// </summary>
        public List<string> AllowedMethods
        {
            get { return this.allowedMethods; }
            set { this.allowedMethods = value; }
        }

        // Check to see if AllowedMethods property is set
        internal bool IsSetAllowedMethods()
        {
            return this.allowedMethods.Count > 0;
        }

        /// <summary>
        /// One or more origins you want customers to be able to access the bucket from.
        ///  
        /// </summary>
        public List<string> AllowedOrigins
        {
            get { return this.allowedOrigins; }
            set { this.allowedOrigins = value; }
        }

        // Check to see if AllowedOrigins property is set
        internal bool IsSetAllowedOrigins()
        {
            return this.allowedOrigins.Count > 0;
        }

        /// <summary>
        /// An optional unique identifier for the rule.
        /// </summary>
        /// <remarks>
        /// The ID value can be up to 255 characters long. The IDs help you find a rule in the configuration.
        /// </remarks>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// One or more headers in the response that you want customers to be able to access from their applications (for example, from a JavaScript
        /// XMLHttpRequest object).
        ///  
        /// </summary>
        public List<string> ExposeHeaders
        {
            get { return this.exposeHeaders; }
            set { this.exposeHeaders = value; }
        }

        // Check to see if ExposeHeaders property is set
        internal bool IsSetExposeHeaders()
        {
            return this.exposeHeaders.Count > 0;
        }

        /// <summary>
        /// The time in seconds that your browser is to cache the preflight response for the specified resource.
        ///  
        /// </summary>
        public int MaxAgeSeconds
        {
            get { return this.maxAgeSeconds ?? default(int); }
            set { this.maxAgeSeconds = value; }
        }

        // Check to see if MaxAgeSeconds property is set
        internal bool IsSetMaxAgeSeconds()
        {
            return this.maxAgeSeconds.HasValue;
        }

        /// <summary>
        /// Specifies which headers are allowed in a pre-flight OPTIONS request through the 
        /// Access-Control-Request-Headers header. 
        /// </summary>
        /// <remarks>
        /// Each header name specified in the Access-Control-Request-Headers must have a corresponding 
        /// entry in the rule. Only the headers that were requested will be sent back. 
        /// This element can contain at most one * wildcard character.
        /// </remarks>
        public List<string> AllowedHeaders
        {
            get { return this.allowedHeaders; }
            set { this.allowedHeaders = value; }
        }

        /// <summary>
        /// Checks if AllowedHeaders property is set.
        /// </summary>
        /// <returns>true if AllowedHeaders property is set.</returns>
        internal bool IsSetAllowedHeaders()
        {
            return (this.AllowedHeaders.Count > 0);
        }


    }
}
