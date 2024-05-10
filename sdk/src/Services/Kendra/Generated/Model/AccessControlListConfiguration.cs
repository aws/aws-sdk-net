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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Access Control List files for the documents in a data source. For the format of the
    /// file, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/s3-acl.html">Access
    /// control for S3 data sources</a>.
    /// </summary>
    public partial class AccessControlListConfiguration
    {
        private string _keyPath;

        /// <summary>
        /// Gets and sets the property KeyPath. 
        /// <para>
        /// Path to the Amazon S3 bucket that contains the ACL files.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KeyPath
        {
            get { return this._keyPath; }
            set { this._keyPath = value; }
        }

        // Check to see if KeyPath property is set
        internal bool IsSetKeyPath()
        {
            return this._keyPath != null;
        }

    }
}