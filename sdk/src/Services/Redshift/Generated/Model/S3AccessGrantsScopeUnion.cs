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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A list of scopes set up for S3 Access Grants integration.
    /// </summary>
    public partial class S3AccessGrantsScopeUnion
    {
        private ReadWriteAccess _readWriteAccess;

        /// <summary>
        /// Gets and sets the property ReadWriteAccess. 
        /// <para>
        /// The S3 Access Grants scope.
        /// </para>
        /// </summary>
        public ReadWriteAccess ReadWriteAccess
        {
            get { return this._readWriteAccess; }
            set { this._readWriteAccess = value; }
        }

        // Check to see if ReadWriteAccess property is set
        internal bool IsSetReadWriteAccess()
        {
            return this._readWriteAccess != null;
        }

    }
}