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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// User accounts whose documents should be indexed.
    /// </summary>
    public partial class OneDriveUsers
    {
        private List<string> _oneDriveUserList = new List<string>();
        private S3Path _oneDriveUserS3Path;

        /// <summary>
        /// Gets and sets the property OneDriveUserList. 
        /// <para>
        /// A list of users whose documents should be indexed. Specify the user names in email
        /// format, for example, <code>username@tenantdomain</code>. If you need to index the
        /// documents of more than 100 users, use the <code>OneDriveUserS3Path</code> field to
        /// specify the location of a file containing a list of users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> OneDriveUserList
        {
            get { return this._oneDriveUserList; }
            set { this._oneDriveUserList = value; }
        }

        // Check to see if OneDriveUserList property is set
        internal bool IsSetOneDriveUserList()
        {
            return this._oneDriveUserList != null && this._oneDriveUserList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OneDriveUserS3Path. 
        /// <para>
        /// The S3 bucket location of a file containing a list of users whose documents should
        /// be indexed.
        /// </para>
        /// </summary>
        public S3Path OneDriveUserS3Path
        {
            get { return this._oneDriveUserS3Path; }
            set { this._oneDriveUserS3Path = value; }
        }

        // Check to see if OneDriveUserS3Path property is set
        internal bool IsSetOneDriveUserS3Path()
        {
            return this._oneDriveUserS3Path != null;
        }

    }
}