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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the details of a service-specific credential.
    /// </summary>
    public partial class ServiceSpecificCredential
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the service-specific credential were created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date and time when the service specific credential expires. This field is only
        /// present for Bedrock API keys and CloudWatch Logs API keys that were created with an
        /// expiration period.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceCredentialAlias. 
        /// <para>
        /// For Bedrock API keys and CloudWatch Logs API keys, this is the public portion of the
        /// credential that includes the IAM user name and a suffix containing version and creation
        /// information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ServiceCredentialAlias { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCredentialAlias property is set.
        /// </summary>
        internal bool IsSetServiceCredentialAlias() => this.ServiceCredentialAlias != null;

        /// <summary>
        /// Gets and sets the property ServiceCredentialSecret. 
        /// <para>
        /// For Bedrock API keys and CloudWatch Logs API keys, this is the secret portion of the
        /// credential that should be used to authenticate API calls. This value is returned only
        /// when the credential is created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ServiceCredentialSecret { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCredentialSecret property is set.
        /// </summary>
        internal bool IsSetServiceCredentialSecret() => this.ServiceCredentialSecret != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service associated with the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServicePassword. 
        /// <para>
        /// The generated password for the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ServicePassword { get; set; }

        /// <summary>
        /// Checks to see if the ServicePassword property is set.
        /// </summary>
        internal bool IsSetServicePassword() => this.ServicePassword != null;

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredentialId. 
        /// <para>
        /// The unique identifier for the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 128)]
        public string ServiceSpecificCredentialId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpecificCredentialId property is set.
        /// </summary>
        internal bool IsSetServiceSpecificCredentialId() => this.ServiceSpecificCredentialId != null;

        /// <summary>
        /// Gets and sets the property ServiceUserName. 
        /// <para>
        /// The generated user name for the service-specific credential. This value is generated
        /// by combining the IAM user's name combined with the ID number of the Amazon Web Services
        /// account, as in <c>jane-at-123456789012</c>, for example. This value cannot be configured
        /// by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ServiceUserName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUserName property is set.
        /// </summary>
        internal bool IsSetServiceUserName() => this.ServiceUserName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service-specific credential. <c>Active</c> means that the key is
        /// valid for API calls, while <c>Inactive</c> means it is not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
