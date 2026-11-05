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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The settings in JSON format for the DMS Transfer type source endpoint.
    /// </summary>
    public partial class DmsTransferSettings
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The name of the S3 bucket to use. 
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used by the service access IAM role. The role must
        /// allow the <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;
    }
}
