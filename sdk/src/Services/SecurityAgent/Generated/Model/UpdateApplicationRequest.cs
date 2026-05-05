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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the configuration of an existing application, including the IAM role and default
    /// KMS key.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonSecurityAgentRequest
    {
        private string _applicationId;
        private string _defaultKmsKeyId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultKmsKeyId. 
        /// <para>
        /// The updated identifier of the default AWS KMS key for the application.
        /// </para>
        /// </summary>
        public string DefaultKmsKeyId
        {
            get { return this._defaultKmsKeyId; }
            set { this._defaultKmsKeyId = value; }
        }

        // Check to see if DefaultKmsKeyId property is set
        internal bool IsSetDefaultKmsKeyId()
        {
            return this._defaultKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the IAM role for the application.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}