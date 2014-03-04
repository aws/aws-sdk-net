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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <para>Represents the output of a <c>DescribeStream</c> operation.</para>
    /// </summary>
    public partial class DescribeStreamResult
    {
        
        private StreamDescription streamDescription;

        /// <summary>
        /// Contains the current status of the stream, the stream ARN, an array of shard objects that comprise the stream, and states whether there are
        /// more shards available.
        ///  
        /// </summary>
        public StreamDescription StreamDescription
        {
            get { return this.streamDescription; }
            set { this.streamDescription = value; }
        }

        /// <summary>
        /// Sets the StreamDescription property
        /// </summary>
        /// <param name="streamDescription">The value to set for the StreamDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStreamResult WithStreamDescription(StreamDescription streamDescription)
        {
            this.streamDescription = streamDescription;
            return this;
        }
            

        // Check to see if StreamDescription property is set
        internal bool IsSetStreamDescription()
        {
            return this.streamDescription != null;
        }
    }
}
