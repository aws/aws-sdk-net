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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Part of a request to launch Amazon EC2 instances, specifying which license pool to use if a license should be attached to the new
    /// Amazon EC2 instance. </para>
    /// </summary>
    public class InstanceLicenseSpecification
    {
        
        private string pool;


        /// <summary>
        /// The license pool from which to take a license when starting Amazon EC2 instances in the associated <c>RunInstances</c> request.
        ///  
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
