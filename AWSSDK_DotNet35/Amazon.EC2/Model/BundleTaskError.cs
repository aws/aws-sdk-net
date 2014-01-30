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
    /// <para>Describes an error for BundleInstance.</para>
    /// </summary>
    public class BundleTaskError
    {
        
        private string code;
        private string message;


        /// <summary>
        /// The error code.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// The error message.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
