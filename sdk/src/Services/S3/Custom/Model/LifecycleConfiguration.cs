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
    /// <para>
    /// Container for lifecycle rules. You can add as many as 1000 rules.
    /// </para>
    /// <para>
    /// For more information see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public class LifecycleConfiguration
    {
        
        private List<LifecycleRule> rules = new List<LifecycleRule>();

        /// <summary>
        /// Gets and sets the Rules property. These rules defined the lifecycle configuration.
        /// </summary>
        public List<LifecycleRule> Rules
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
