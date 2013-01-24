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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The returned result of the corresponding request. </para>
    /// </summary>
    public class UpdateStreamingDistributionResult  
    {
        
        private StreamingDistribution streamingDistribution;
        private string eTag;

        /// <summary>
        /// The streaming distribution's information.
        ///  
        /// </summary>
        public StreamingDistribution StreamingDistribution
        {
            get { return this.streamingDistribution; }
            set { this.streamingDistribution = value; }
        }

        /// <summary>
        /// Sets the StreamingDistribution property
        /// </summary>
        /// <param name="streamingDistribution">The value to set for the StreamingDistribution property </param>
        /// <returns>this instance</returns>
        public UpdateStreamingDistributionResult WithStreamingDistribution(StreamingDistribution streamingDistribution)
        {
            this.streamingDistribution = streamingDistribution;
            return this;
        }
            

        // Check to see if StreamingDistribution property is set
        internal bool IsSetStreamingDistribution()
        {
            return this.streamingDistribution != null;       
        }

        /// <summary>
        /// The current version of the configuration. For example: E2QWRUHAPOMQZL.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Sets the ETag property
        /// </summary>
        /// <param name="eTag">The value to set for the ETag property </param>
        /// <returns>this instance</returns>
        public UpdateStreamingDistributionResult WithETag(string eTag)
        {
            this.eTag = eTag;
            return this;
        }
            

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;       
        }
    }
}
