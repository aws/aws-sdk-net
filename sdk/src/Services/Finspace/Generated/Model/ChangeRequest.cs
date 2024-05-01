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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A list of change request objects.
    /// </summary>
    public partial class ChangeRequest
    {
        private ChangeType _changeType;
        private string _dbPath;
        private string _s3Path;

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Defines the type of change request. A <c>changeType</c> can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT – Adds or updates files in a database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE – Deletes files in a database.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property DbPath. 
        /// <para>
        /// Defines the path within the database directory. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1025)]
        public string DbPath
        {
            get { return this._dbPath; }
            set { this._dbPath = value; }
        }

        // Check to see if DbPath property is set
        internal bool IsSetDbPath()
        {
            return this._dbPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3Path. 
        /// <para>
        /// Defines the S3 path of the source file that is required to add or update files in
        /// a database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=1093)]
        public string S3Path
        {
            get { return this._s3Path; }
            set { this._s3Path = value; }
        }

        // Check to see if S3Path property is set
        internal bool IsSetS3Path()
        {
            return this._s3Path != null;
        }

    }
}