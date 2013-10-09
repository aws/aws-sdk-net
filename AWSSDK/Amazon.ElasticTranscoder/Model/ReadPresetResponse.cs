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

using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the  ReadPresetResult response and response metadata.
    /// </summary>
    public class ReadPresetResponse : AmazonWebServiceResponse
    {
        private ReadPresetResult readPresetResult;

        /// <summary>
        /// Gets and sets the ReadPresetResult property.
        /// The ReadPresetResponse structure.
        /// </summary>
        public ReadPresetResult ReadPresetResult
        {
            get
            {
                if(this.readPresetResult == null)
                {
                    this.readPresetResult = new ReadPresetResult();
                }

                return this.readPresetResult;
            }
            set { this.readPresetResult = value; }
        }
    }
}
    
