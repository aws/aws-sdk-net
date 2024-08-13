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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// A sample configuration for profile jobs only, which determines the number of rows
    /// on which the profile job is run. If a <c>JobSample</c> value isn't provided, the default
    /// is used. The default value is CUSTOM_ROWS for the mode parameter and 20,000 for the
    /// size parameter.
    /// </summary>
    public partial class JobSample
    {
        private SampleMode _mode;
        private long? _size;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// A value that determines whether the profile job is run on the entire dataset or a
        /// specified number of rows. This value must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FULL_DATASET - The profile job is run on the entire dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUSTOM_ROWS - The profile job is run on the number of rows specified in the <c>Size</c>
        /// parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SampleMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The <c>Size</c> parameter is only required when the mode is CUSTOM_ROWS. The profile
        /// job is run on the specified number of rows. The maximum value for size is Long.MAX_VALUE.
        /// </para>
        ///  
        /// <para>
        /// Long.MAX_VALUE = 9223372036854775807
        /// </para>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}