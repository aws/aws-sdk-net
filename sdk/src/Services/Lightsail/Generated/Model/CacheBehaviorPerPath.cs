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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the per-path cache behavior of an Amazon Lightsail content delivery network
    /// (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// A per-path cache behavior is used to override, or add an exception to, the default
    /// cache behavior of a distribution. For example, if the <c>cacheBehavior</c> is set
    /// to <c>cache</c>, then a per-path cache behavior can be used to specify a directory,
    /// file, or file type that your distribution will cache. Alternately, if the distribution's
    /// <c>cacheBehavior</c> is <c>dont-cache</c>, then a per-path cache behavior can be used
    /// to specify a directory, file, or file type that your distribution will not cache.
    /// </para>
    /// </summary>
    public partial class CacheBehaviorPerPath
    {
        private BehaviorEnum _behavior;
        private string _path;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The cache behavior for the specified path.
        /// </para>
        ///  
        /// <para>
        /// You can specify one of the following per-path cache behaviors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>cache</c> </b> - This behavior caches the specified path. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>dont-cache</c> </b> - This behavior doesn't cache the specified path. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BehaviorEnum Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to
        /// specify wildcard directories (<c>path/to/assets/*</c>), and file types (<c>*.html,
        /// *jpg, *js</c>). Directories and file paths are case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the following to cache all files in the document root of an Apache web server
        /// running on a Lightsail instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the following file to cache only the index page in the document root of an
        /// Apache web server.
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/index.html</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the following to cache only the .html files in the document root of an Apache
        /// web server.
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/*.html</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the following to cache only the .jpg, .png, and .gif files in the images sub-directory
        /// of the document root of an Apache web server.
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/images/*.jpg</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/images/*.png</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/images/*.gif</c> 
        /// </para>
        ///  
        /// <para>
        /// Specify the following to cache all files in the images sub-directory of the document
        /// root of an Apache web server.
        /// </para>
        ///  
        /// <para>
        ///  <c>var/www/html/images/</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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