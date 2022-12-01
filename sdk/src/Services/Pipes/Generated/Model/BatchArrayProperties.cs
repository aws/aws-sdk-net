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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The array properties for the submitted job, such as the size of the array. The array
    /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
    /// an array job. This parameter is used only if the target is an Batch job.
    /// </summary>
    public partial class BatchArrayProperties
    {
        private int? _size;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the array, if this is an array batch job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10000)]
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}