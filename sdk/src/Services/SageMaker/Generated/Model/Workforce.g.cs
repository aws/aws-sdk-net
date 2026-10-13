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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A single private workforce, which is automatically created when you create your first
    /// private work team. You can create one private work force in each Amazon Web Services
    /// Region. By default, any workforce-related API operation used in a specific region
    /// will apply to the workforce created in that region. To learn how to create a private
    /// workforce, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">Create
    /// a Private Workforce</a>.
    /// </summary>
    public partial class Workforce
    {
        /// <summary>
        /// Gets and sets the property CognitoConfig. 
        /// <para>
        /// The configuration of an Amazon Cognito workforce. A single Cognito workforce is created
        /// using and corresponds to a single <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">
        /// Amazon Cognito user pool</a>.
        /// </para>
        /// </summary>
        public CognitoConfig CognitoConfig { get; set; }

        /// <summary>
        /// Checks to see if the CognitoConfig property is set.
        /// </summary>
        internal bool IsSetCognitoConfig() => this.CognitoConfig != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date that the workforce is created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason your workforce failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type you specify - either <c>IPv4</c> only or <c>dualstack</c> (<c>IPv4</c>
        /// and <c>IPv6</c>) - to support your labeling workforce.
        /// </para>
        /// </summary>
        public WorkforceIpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The most recent date that <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateWorkforce.html">UpdateWorkforce</a>
        /// was used to successfully add one or more IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>)
        /// to a private workforce's allow list.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property OidcConfig. 
        /// <para>
        /// The configuration of an OIDC Identity Provider (IdP) private workforce.
        /// </para>
        /// </summary>
        public OidcConfigForResponse OidcConfig { get; set; }

        /// <summary>
        /// Checks to see if the OidcConfig property is set.
        /// </summary>
        internal bool IsSetOidcConfig() => this.OidcConfig != null;

        /// <summary>
        /// Gets and sets the property SourceIpConfig. 
        /// <para>
        /// A list of one to ten IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>)
        /// to be added to the workforce allow list. By default, a workforce isn't restricted
        /// to specific IP addresses.
        /// </para>
        /// </summary>
        public SourceIpConfig SourceIpConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpConfig property is set.
        /// </summary>
        internal bool IsSetSourceIpConfig() => this.SourceIpConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your workforce.
        /// </para>
        /// </summary>
        public WorkforceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubDomain. 
        /// <para>
        /// The subdomain for your OIDC Identity Provider.
        /// </para>
        /// </summary>
        public string SubDomain { get; set; }

        /// <summary>
        /// Checks to see if the SubDomain property is set.
        /// </summary>
        internal bool IsSetSubDomain() => this.SubDomain != null;

        /// <summary>
        /// Gets and sets the property WorkforceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string WorkforceArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkforceArn property is set.
        /// </summary>
        internal bool IsSetWorkforceArn() => this.WorkforceArn != null;

        /// <summary>
        /// Gets and sets the property WorkforceName. 
        /// <para>
        /// The name of the private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string WorkforceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkforceName property is set.
        /// </summary>
        internal bool IsSetWorkforceName() => this.WorkforceName != null;

        /// <summary>
        /// Gets and sets the property WorkforceVpcConfig. 
        /// <para>
        /// The configuration of a VPC workforce.
        /// </para>
        /// </summary>
        public WorkforceVpcConfigResponse WorkforceVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the WorkforceVpcConfig property is set.
        /// </summary>
        internal bool IsSetWorkforceVpcConfig() => this.WorkforceVpcConfig != null;
    }
}
