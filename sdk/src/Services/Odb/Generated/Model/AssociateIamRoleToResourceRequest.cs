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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
    /// Container for the parameters to the AssociateIamRoleToResource operation.
    /// Associates an Amazon Web Services Identity and Access Management (IAM) service role
    /// with a specified resource to enable Amazon Web Services service integration.
    /// </summary>
    public partial class AssociateIamRoleToResourceRequest : AmazonOdbRequest
    {
        private SupportedAwsIntegration _awsIntegration;
        private string _iamRoleArn;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AwsIntegration. 
        /// <para>
        /// The Amazon Web Services integration configuration settings for the IAM service role
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportedAwsIntegration AwsIntegration
        {
            get { return this._awsIntegration; }
            set { this._awsIntegration = value; }
        }

        // Check to see if AwsIntegration property is set
        internal bool IsSetAwsIntegration()
        {
            return this._awsIntegration != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target resource to associate with the IAM service
        /// role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}