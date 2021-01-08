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

namespace Amazon.EC2.Model
{
    /// <summary>Instance License Specification
    /// </summary>
    public class InstanceLicenseSpecification
    {
        
        private string pool;

        /// <summary>
        /// Gets and sets the Pool property.
        /// </summary>
        public string Pool
        {
            get { return this.pool; }
            set { this.pool = value; }
        }

        // Check to see if Pool property is set
        internal bool IsSetPool()
        {
            return this.pool != null;
        }
    }
}
