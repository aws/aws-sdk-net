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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the CreateAndAttachS3AccessPoint operation.
    /// </summary>
    public partial class CreateAndAttachS3AccessPointResponse : AmazonWebServiceResponse
    {
        private S3AccessPointAttachment _s3AccessPointAttachment;

        /// <summary>
        /// Gets and sets the property S3AccessPointAttachment. 
        /// <para>
        /// Describes the configuration of the S3 access point created.
        /// </para>
        /// </summary>
        public S3AccessPointAttachment S3AccessPointAttachment
        {
            get { return this._s3AccessPointAttachment; }
            set { this._s3AccessPointAttachment = value; }
        }

        // Check to see if S3AccessPointAttachment property is set
        internal bool IsSetS3AccessPointAttachment()
        {
            return this._s3AccessPointAttachment != null;
        }

    }
}