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

/*
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the UpdateServicePipeline operation.
    /// </summary>
    public partial class UpdateServicePipelineResponse : AmazonWebServiceResponse
    {
        private ServicePipeline _pipeline;

        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// The pipeline details that are returned by Proton.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServicePipeline Pipeline
        {
            get { return this._pipeline; }
            set { this._pipeline = value; }
        }

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this._pipeline != null;
        }

    }
}