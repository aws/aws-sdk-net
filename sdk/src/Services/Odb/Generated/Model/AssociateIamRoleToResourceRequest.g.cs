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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateIamRoleToResource operation. Associates
    /// an Amazon Web Services Identity and Access Management (IAM) service role with a specified
    /// resource to enable Amazon Web Services service integration.
    /// </summary>
    public partial class AssociateIamRoleToResourceRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AwsIntegration. 
        /// <para>
        /// The Amazon Web Services integration configuration settings for the Amazon Web Services
        /// Identity and Access Management (IAM) service role association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupportedAwsIntegration AwsIntegration { get; set; }

        /// <summary>
        /// Checks to see if the AwsIntegration property is set.
        /// </summary>
        internal bool IsSetAwsIntegration() => this.AwsIntegration != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) service role to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target resource to associate with the Amazon
        /// Web Services Identity and Access Management (IAM) service role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
