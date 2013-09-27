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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public class UploadMultipartPartResult  
    {
        
        private string checksum;

        /// <summary>
        /// The SHA256 tree hash that Amazon Glacier computed for the uploaded part.
        ///  
        /// </summary>
        public string Checksum
        {
            get { return this.checksum; }
            set { this.checksum = value; }
        }

        /// <summary>
        /// Sets the Checksum property
        /// </summary>
        /// <param name="checksum">The value to set for the Checksum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadMultipartPartResult WithChecksum(string checksum)
        {
            this.checksum = checksum;
            return this;
        }
            

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this.checksum != null;       
        }
    }
}
