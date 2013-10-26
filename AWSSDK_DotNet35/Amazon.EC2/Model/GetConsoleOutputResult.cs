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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of the GetConsoleOutput operation. </para>
    /// </summary>
    public partial class GetConsoleOutputResult : AmazonWebServiceResponse
    {
        
        private string instanceId;
        private DateTime? timestamp;
        private string output;


        /// <summary>
        /// The ID of the instance whose console output was requested.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The time the output was last updated.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;
        }

        /// <summary>
        /// The console output, Base64 encoded.
        ///  
        /// </summary>
        public string Output
        {
            get { return this.output; }
            set { this.output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this.output != null;
        }
    }
}
