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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Location of the source code for an application version.
    /// </summary>
    public partial class SourceBuildInformation
    {
        private string _sourceLocation;
        private SourceRepository _sourceRepository;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The location of the source code, as a formatted string, depending on the value of
        /// <c>SourceRepository</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>CodeCommit</c>, the format is the repository name and commit ID, separated
        /// by a forward slash. For example, <c>my-git-repo/265cfa0cf6af46153527f55d6503ec030551f57a</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>S3</c>, the format is the S3 bucket name and object key, separated by a forward
        /// slash. For example, <c>my-s3-bucket/Folders/my-source-file</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRepository. 
        /// <para>
        /// Location where the repository is stored.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CodeCommit</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceRepository SourceRepository
        {
            get { return this._sourceRepository; }
            set { this._sourceRepository = value; }
        }

        // Check to see if SourceRepository property is set
        internal bool IsSetSourceRepository()
        {
            return this._sourceRepository != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of repository.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Git</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Zip</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}