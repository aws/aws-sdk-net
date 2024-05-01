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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Optional. Have MediaConvert automatically apply Amazon S3 access control for the outputs
    /// in this output group. When you don't use this setting, S3 automatically applies the
    /// default access control list PRIVATE.
    /// </summary>
    public partial class S3DestinationAccessControl
    {
        private S3ObjectCannedAcl _cannedAcl;

        /// <summary>
        /// Gets and sets the property CannedAcl. Choose an Amazon S3 canned ACL for MediaConvert
        /// to apply to this output.
        /// </summary>
        public S3ObjectCannedAcl CannedAcl
        {
            get { return this._cannedAcl; }
            set { this._cannedAcl = value; }
        }

        // Check to see if CannedAcl property is set
        internal bool IsSetCannedAcl()
        {
            return this._cannedAcl != null;
        }

    }
}