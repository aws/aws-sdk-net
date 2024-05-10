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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the GetStorageLensGroup operation.
    /// </summary>
    public partial class GetStorageLensGroupResponse : AmazonWebServiceResponse
    {
        private StorageLensGroup _storageLensGroup;

        /// <summary>
        /// Gets and sets the property StorageLensGroup. 
        /// <para>
        ///  The name of the Storage Lens group that you're trying to retrieve the configuration
        /// details for. 
        /// </para>
        /// </summary>
        public StorageLensGroup StorageLensGroup
        {
            get { return this._storageLensGroup; }
            set { this._storageLensGroup = value; }
        }

        // Check to see if StorageLensGroup property is set
        internal bool IsSetStorageLensGroup()
        {
            return this._storageLensGroup != null;
        }

    }
}