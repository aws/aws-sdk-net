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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeObject operation.
    /// Gets the headers for an object at the specified path.
    /// </summary>
    public partial class DescribeObjectRequest : AmazonMediaStoreDataRequest
    {
        private string _path;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path (including the file name) where the object is stored in the container. Format:
        /// &lt;folder name&gt;/&lt;folder name&gt;/&lt;file name&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=900)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}