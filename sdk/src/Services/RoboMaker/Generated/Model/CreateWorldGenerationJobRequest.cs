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
    /// Container for the parameters to the CreateWorldGenerationJob operation.
    /// Creates worlds using the specified template.
    /// </summary>
    public partial class CreateWorldGenerationJobRequest : AmazonRoboMakerRequest
    {
        private string _clientRequestToken;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _template;
        private WorldCount _worldCount;
        private Dictionary<string, string> _worldTags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the world generator
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The Amazon Resource Name (arn) of the world template describing the worlds you want
        /// to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
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

        /// <summary>
        /// Gets and sets the property WorldCount. 
        /// <para>
        /// Information about the world count.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorldCount WorldCount
        {
            get { return this._worldCount; }
            set { this._worldCount = value; }
        }

        // Check to see if WorldCount property is set
        internal bool IsSetWorldCount()
        {
            return this._worldCount != null;
        }

        /// <summary>
        /// Gets and sets the property WorldTags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the generated worlds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> WorldTags
        {
            get { return this._worldTags; }
            set { this._worldTags = value; }
        }

        // Check to see if WorldTags property is set
        internal bool IsSetWorldTags()
        {
            return this._worldTags != null && this._worldTags.Count > 0; 
        }

    }
}