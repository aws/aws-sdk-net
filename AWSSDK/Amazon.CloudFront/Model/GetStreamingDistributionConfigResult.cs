/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class GetStreamingDistributionConfigResult  
    {
        
        private StreamingDistributionConfig streamingDistributionConfig;
        private string eTag;

        /// <summary>
        /// The streaming distribution's configuration information.
        ///  
        /// </summary>
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this.streamingDistributionConfig; }
            set { this.streamingDistributionConfig = value; }
        }

        /// <summary>
        /// Sets the StreamingDistributionConfig property
        /// </summary>
        /// <param name="streamingDistributionConfig">The value to set for the StreamingDistributionConfig property </param>
        /// <returns>this instance</returns>
        public GetStreamingDistributionConfigResult WithStreamingDistributionConfig(StreamingDistributionConfig streamingDistributionConfig)
        {
            this.streamingDistributionConfig = streamingDistributionConfig;
            return this;
        }
            

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this.streamingDistributionConfig != null;       
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
        public GetStreamingDistributionConfigResult WithETag(string eTag)
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
