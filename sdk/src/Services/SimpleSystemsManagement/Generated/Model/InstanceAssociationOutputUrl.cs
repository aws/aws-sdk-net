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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The URL of S3 bucket where you want to store the results of this request.
    /// </summary>
    public partial class InstanceAssociationOutputUrl
    {
        private S3OutputUrl _s3OutputUrl;

        /// <summary>
        /// Gets and sets the property S3OutputUrl. 
        /// <para>
        /// The URL of S3 bucket where you want to store the results of this request.
        /// </para>
        /// </summary>
        public S3OutputUrl S3OutputUrl
        {
            get { return this._s3OutputUrl; }
            set { this._s3OutputUrl = value; }
        }

        // Check to see if S3OutputUrl property is set
        internal bool IsSetS3OutputUrl()
        {
            return this._s3OutputUrl != null;
        }

    }
}