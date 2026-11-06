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
    /// Container for the parameters to the PutAccessGrantsInstanceResourcePolicy operation.
    /// Updates the resource policy of the S3 Access Grants instance. <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3:PutAccessGrantsInstanceResourcePolicy</c> permission
    /// to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class PutAccessGrantsInstanceResourcePolicyRequest : AmazonS3ControlRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The Organization of the resource policy of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 34)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resource policy of the S3 Access Grants instance that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 350000)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
