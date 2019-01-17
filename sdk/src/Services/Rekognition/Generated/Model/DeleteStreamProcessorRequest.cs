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

/*
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStreamProcessor operation.
    /// Deletes the stream processor identified by <code>Name</code>. You assign the value
    /// for <code>Name</code> when you create the stream processor with <a>CreateStreamProcessor</a>.
    /// You might not be able to use the same name for a stream processor for a few seconds
    /// after calling <code>DeleteStreamProcessor</code>.
    /// </summary>
    public partial class DeleteStreamProcessorRequest : AmazonRekognitionRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stream processor you want to delete.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}