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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessGrantsInstanceForPrefix operation. Retrieve
    /// the S3 Access Grants instance that contains a particular prefix. <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3:GetAccessGrantsInstanceForPrefix</c> permission
    /// for the caller account to use this operation. </para> </dd> <dt>Additional Permissions</dt>
    /// <dd> <para> The prefix owner account must grant you the following permissions to their
    /// S3 Access Grants instance: <c>s3:GetAccessGrantsInstanceForPrefix</c>. </para> </dd>
    /// </dl>
    /// </summary>
    public partial class GetAccessGrantsInstanceForPrefixRequest : AmazonS3ControlRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that is making this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 prefix of the access grants that you would like to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;
    }
}
