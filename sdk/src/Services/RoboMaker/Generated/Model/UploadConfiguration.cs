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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Provides upload configuration information. Files are uploaded from the simulation
    /// job to a location you specify.
    /// </summary>
    public partial class UploadConfiguration
    {
        private string _name;
        private string _path;
        private UploadBehavior _uploadBehavior;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A prefix that specifies where files will be uploaded in Amazon S3. It is appended
        /// to the simulation output location to determine the final path. 
        /// </para>
        ///  
        /// <para>
        ///  For example, if your simulation output location is <c>s3://amzn-s3-demo-bucket</c>
        /// and your upload configuration name is <c>robot-test</c>, your files will be uploaded
        /// to <c>s3://amzn-s3-demo-bucket/&lt;simid&gt;/&lt;runid&gt;/robot-test</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  Specifies the path of the file(s) to upload. Standard Unix glob matching rules are
        /// accepted, with the addition of <c>**</c> as a <i>super asterisk</i>. For example,
        /// specifying <c>/var/log/**.log</c> causes all .log files in the <c>/var/log</c> directory
        /// tree to be collected. For more examples, see <a href="https://github.com/gobwas/glob">Glob
        /// Library</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property UploadBehavior. 
        /// <para>
        /// Specifies when to upload the files:
        /// </para>
        ///  <dl> <dt>UPLOAD_ON_TERMINATE</dt> <dd> 
        /// <para>
        /// Matching files are uploaded once the simulation enters the <c>TERMINATING</c> state.
        /// Matching files are not uploaded until all of your code (including tools) have stopped.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If there is a problem uploading a file, the upload is retried. If problems persist,
        /// no further upload attempts will be made.
        /// </para>
        ///  </dd> <dt>UPLOAD_ROLLING_AUTO_REMOVE</dt> <dd> 
        /// <para>
        /// Matching files are uploaded as they are created. They are deleted after they are uploaded.
        /// The specified path is checked every 5 seconds. A final check is made when all of your
        /// code (including tools) have stopped. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public UploadBehavior UploadBehavior
        {
            get { return this._uploadBehavior; }
            set { this._uploadBehavior = value; }
        }

        // Check to see if UploadBehavior property is set
        internal bool IsSetUploadBehavior()
        {
            return this._uploadBehavior != null;
        }

    }
}