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
        private List<string> _modes = new List<string>();
        private CacheType _type;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the cache location: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NO_CACHE</code> or <code>LOCAL</code>: This value is ignored.
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
        /// Gets and sets the property Modes. 
        /// <para>
        ///  If you use a <code>LOCAL</code> cache, the local cache mode. You can use one or more
        /// local cache modes at the same time. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LOCAL_SOURCE_CACHE</code> mode caches Git metadata for primary and secondary
        /// sources. After the cache is created, subsequent builds pull only the change between
        /// commits. This mode is a good choice for projects with a clean working directory and
        /// a source that is a large Git repository. If your project does not use a Git repository
        /// (GitHub, GitHub Enterprise, or Bitbucket) and you choose this option, then it is ignored.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCAL_DOCKER_LAYER_CACHE</code> mode caches existing Docker layers. This mode
        /// is a good choice for projects that build or pull large Docker images. It can prevent
        /// the performance hit that would be caused by pulling large Docker images down from
        /// the network. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  You can only use a Docker layer cache in the Linux enviornment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The <code>privileged</code> flag must be set so that your project has the necessary
        /// Docker privileges. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  You should consider the security implications before using a Docker layer cache.
        /// 
        /// </para>
        ///  </li> </ul> </note> </li> </ul> <ul> <li> 
        /// <para>
        ///  <code>LOCAL_CUSTOM_CACHE</code> mode caches directories you specify in the buildspec
        /// file. This mode is a good choice if your build scenario does not match one that works
        /// well with one of the other three local cache modes. If you use a custom cache: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Only directories can be specified for caching. You cannot specify individual files.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Symlinks are used to reference cached directories. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Cached directories are linked to your build before it downloads its project sources.
        /// Cached items are overriden if a source item has the same name. Directories are specified
        /// using cache paths in the buildspec file. 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public List<string> Modes
        {
            get { return this._modes; }
            set { this._modes = value; }
        }

        // Check to see if Modes property is set
        internal bool IsSetModes()
        {
            return this._modes != null && this._modes.Count > 0; 
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
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCAL</code>: The build project stores a cache locally on a build host that
        /// is only available to that build host.
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