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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetMLTransform operation.
    /// Gets an Glue machine learning transform artifact and all its corresponding metadata.
    /// Machine learning transforms are a special type of transform that use machine learning
    /// to learn the details of the transformation to be performed by learning from examples
    /// provided by humans. These transformations are then saved by Glue. You can retrieve
    /// their metadata by calling <c>GetMLTransform</c>.
    /// </summary>
    public partial class GetMLTransformRequest : AmazonGlueRequest
    {
        private string _transformId;

        /// <summary>
        /// Gets and sets the property TransformId. 
        /// <para>
        /// The unique identifier of the transform, generated at the time that the transform was
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TransformId
        {
            get { return this._transformId; }
            set { this._transformId = value; }
        }

        // Check to see if TransformId property is set
        internal bool IsSetTransformId()
        {
            return this._transformId != null;
        }

    }
}