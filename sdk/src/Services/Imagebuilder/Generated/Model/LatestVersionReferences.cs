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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The resource ARNs with different wildcard variations of semantic versioning.
    /// </summary>
    public partial class LatestVersionReferences
    {
        private string _latestMajorVersionArn;
        private string _latestMinorVersionArn;
        private string _latestPatchVersionArn;
        private string _latestVersionArn;

        /// <summary>
        /// Gets and sets the property LatestMajorVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>major</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestMajorVersionArn
        {
            get { return this._latestMajorVersionArn; }
            set { this._latestMajorVersionArn = value; }
        }

        // Check to see if LatestMajorVersionArn property is set
        internal bool IsSetLatestMajorVersionArn()
        {
            return this._latestMajorVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LatestMinorVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>minor</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestMinorVersionArn
        {
            get { return this._latestMinorVersionArn; }
            set { this._latestMinorVersionArn = value; }
        }

        // Check to see if LatestMinorVersionArn property is set
        internal bool IsSetLatestMinorVersionArn()
        {
            return this._latestMinorVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LatestPatchVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>patch</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestPatchVersionArn
        {
            get { return this._latestPatchVersionArn; }
            set { this._latestPatchVersionArn = value; }
        }

        // Check to see if LatestPatchVersionArn property is set
        internal bool IsSetLatestPatchVersionArn()
        {
            return this._latestPatchVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) of the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestVersionArn
        {
            get { return this._latestVersionArn; }
            set { this._latestVersionArn = value; }
        }

        // Check to see if LatestVersionArn property is set
        internal bool IsSetLatestVersionArn()
        {
            return this._latestVersionArn != null;
        }

    }
}