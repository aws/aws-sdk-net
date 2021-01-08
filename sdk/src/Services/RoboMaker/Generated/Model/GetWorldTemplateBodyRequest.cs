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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorldTemplateBody operation.
    /// Gets the world template body.
    /// </summary>
    public partial class GetWorldTemplateBodyRequest : AmazonRoboMakerRequest
    {
        private string _generationJob;
        private string _template;

        /// <summary>
        /// Gets and sets the property GenerationJob. 
        /// <para>
        /// The Amazon Resource Name (arn) of the world generator job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string GenerationJob
        {
            get { return this._generationJob; }
            set { this._generationJob = value; }
        }

        // Check to see if GenerationJob property is set
        internal bool IsSetGenerationJob()
        {
            return this._generationJob != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The Amazon Resource Name (arn) of the world template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}