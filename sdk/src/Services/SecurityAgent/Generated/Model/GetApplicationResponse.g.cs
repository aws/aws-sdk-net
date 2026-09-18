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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the GetApplication operation.
    /// </summary>
    public partial class GetApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property DefaultKmsKeyId. 
        /// <para>
        /// The identifier of the default AWS KMS key used to encrypt data for the application.
        /// </para>
        /// </summary>
        public string DefaultKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultKmsKeyId property is set.
        /// </summary>
        internal bool IsSetDefaultKmsKeyId() => this.DefaultKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property IdcConfiguration. 
        /// <para>
        /// The IAM Identity Center configuration for the application.
        /// </para>
        /// </summary>
        public IdCConfiguration IdcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdcConfiguration property is set.
        /// </summary>
        internal bool IsSetIdcConfiguration() => this.IdcConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the application.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
