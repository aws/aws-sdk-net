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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The configuration options of the S3 Access Grants location. It contains the <code>S3SubPrefix</code>
    /// field. The grant scope, the data to which you are granting access, is the result of
    /// appending the <code>Subprefix</code> field to the scope of the registered location.
    /// </summary>
    public partial class AccessGrantsLocationConfiguration
    {
        private string _s3SubPrefix;

        /// <summary>
        /// Gets and sets the property S3SubPrefix. 
        /// <para>
        /// The <code>S3SubPrefix</code> is appended to the location scope creating the grant
        /// scope. Use this field to narrow the scope of the grant to a subset of the location
        /// scope. This field is required if the location scope is the default location <code>s3://</code>
        /// because you cannot create a grant for all of your S3 data in the Region and must narrow
        /// the scope. For example, if the location scope is the default location <code>s3://</code>,
        /// the <code>S3SubPrefx</code> can be a &lt;bucket-name&gt;/*, so the full grant scope
        /// path would be <code>s3://&lt;bucket-name&gt;/*</code>. Or the <code>S3SubPrefx</code>
        /// can be <code>&lt;bucket-name&gt;/&lt;prefix-name&gt;*</code>, so the full grant scope
        /// path would be or <code>s3://&lt;bucket-name&gt;/&lt;prefix-name&gt;*</code>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>S3SubPrefix</code> includes a prefix, append the wildcard character <code>*</code>
        /// after the prefix to indicate that you want to include all object key names in the
        /// bucket that start with that prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string S3SubPrefix
        {
            get { return this._s3SubPrefix; }
            set { this._s3SubPrefix = value; }
        }

        // Check to see if S3SubPrefix property is set
        internal bool IsSetS3SubPrefix()
        {
            return this._s3SubPrefix != null;
        }

    }
}