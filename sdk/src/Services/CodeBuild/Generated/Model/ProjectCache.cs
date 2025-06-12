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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the cache for the build project.
    /// </summary>
    public partial class ProjectCache
    {
        private string _cacheNamespace;
        private string _location;
        private List<string> _modes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CacheType _type;

        /// <summary>
        /// Gets and sets the property CacheNamespace. 
        /// <para>
        /// Defines the scope of the cache. You can use this namespace to share a cache across
        /// multiple projects. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/caching-s3.html#caching-s3-sharing">Cache
        /// sharing between projects</a> in the <i>CodeBuild User Guide</i>.
        /// </para>
        /// </summary>
        public string CacheNamespace
        {
            get { return this._cacheNamespace; }
            set { this._cacheNamespace = value; }
        }

        // Check to see if CacheNamespace property is set
        internal bool IsSetCacheNamespace()
        {
            return this._cacheNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the cache location: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NO_CACHE</c> or <c>LOCAL</c>: This value is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c>: This is the S3 bucket name/prefix.
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
        /// An array of strings that specify the local cache modes. You can use one or more local
        /// cache modes at the same time. This is only used for <c>LOCAL</c> cache types.
        /// </para>
        ///  
        /// <para>
        /// Possible values are:
        /// </para>
        ///  <dl> <dt>LOCAL_SOURCE_CACHE</dt> <dd> 
        /// <para>
        /// Caches Git metadata for primary and secondary sources. After the cache is created,
        /// subsequent builds pull only the change between commits. This mode is a good choice
        /// for projects with a clean working directory and a source that is a large Git repository.
        /// If you choose this option and your project does not use a Git repository (GitHub,
        /// GitHub Enterprise, or Bitbucket), the option is ignored. 
        /// </para>
        ///  </dd> <dt>LOCAL_DOCKER_LAYER_CACHE</dt> <dd> 
        /// <para>
        /// Caches existing Docker layers. This mode is a good choice for projects that build
        /// or pull large Docker images. It can prevent the performance issues caused by pulling
        /// large Docker images down from the network. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You can use a Docker layer cache in the Linux environment only. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>privileged</c> flag must be set so that your project has the required Docker
        /// permissions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You should consider the security implications before you use a Docker layer cache.
        /// 
        /// </para>
        ///  </li> </ul> </note> </dd> <dt>LOCAL_CUSTOM_CACHE</dt> <dd> 
        /// <para>
        /// Caches directories you specify in the buildspec file. This mode is a good choice if
        /// your build scenario is not suited to one of the other three local cache modes. If
        /// you use a custom cache: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only directories can be specified for caching. You cannot specify individual files.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Symlinks are used to reference cached directories. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cached directories are linked to your build before it downloads its project sources.
        /// Cached items are overridden if a source item has the same name. Directories are specified
        /// using cache paths in the buildspec file. 
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Modes
        {
            get { return this._modes; }
            set { this._modes = value; }
        }

        // Check to see if Modes property is set
        internal bool IsSetModes()
        {
            return this._modes != null && (this._modes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cache used by the build project. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NO_CACHE</c>: The build project does not use any cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c>: The build project reads and writes from and to S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCAL</c>: The build project stores a cache locally on a build host that is only
        /// available to that build host.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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