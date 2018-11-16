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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the cache for the build project.
    /// </summary>
    public partial class ProjectCache
    {
        private string _location;
        private CacheType _type;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the cache location: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NO_CACHE</code>: This value is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code>: This is the S3 bucket name/prefix.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cache used by the build project. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NO_CACHE</code>: The build project does not use any cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code>: The build project reads and writes from and to S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CacheType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}