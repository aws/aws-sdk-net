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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessControlApplication operation.
    /// </summary>
    public partial class CreateAccessControlApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessControlApplicationStatus. 
        /// <para>
        /// The status of the access control application. A new application is always <c>ENABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessControlApplicationStatus AccessControlApplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlApplicationStatus property is set.
        /// </summary>
        internal bool IsSetAccessControlApplicationStatus() => this.AccessControlApplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the access control application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// The ARN of the Amazon Web Services IAM Identity Center application that Quick Sight
        /// manages for this access control application. This value is present when the <c>IdpAuthorizingType</c>
        /// is <c>IDC_AUTH_CODE</c>, or when a trusted token issuer is configured.
        /// </para>
        /// </summary>
        public string IdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdcApplicationArn() => this.IdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property QuickAuthenticationConfiguration. 
        /// <para>
        /// The generated Quick Sight authentication configuration. It contains the generated
        /// client ID.
        /// </para>
        /// </summary>
        public QuickAuthenticationConfigCreateOutput QuickAuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuickAuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetQuickAuthenticationConfiguration() => this.QuickAuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property TenantUrl. 
        /// <para>
        /// The tenant URL of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TenantUrl { get; set; }

        /// <summary>
        /// Checks to see if the TenantUrl property is set.
        /// </summary>
        internal bool IsSetTenantUrl() => this.TenantUrl != null;
    }
}
