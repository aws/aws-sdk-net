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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A container for information about the user pool domain associated with the hosted
    /// UI and OAuth endpoints.
    /// </summary>
    public partial class DomainDescriptionType
    {
        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The Amazon Web Services account that you created the user pool in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string AWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AWSAccountId property is set.
        /// </summary>
        internal bool IsSetAWSAccountId() => this.AWSAccountId != null;

        /// <summary>
        /// Gets and sets the property CloudFrontDistribution. 
        /// <para>
        /// The Amazon CloudFront endpoint that hosts your custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string CloudFrontDistribution { get; set; }

        /// <summary>
        /// Checks to see if the CloudFrontDistribution property is set.
        /// </summary>
        internal bool IsSetCloudFrontDistribution() => this.CloudFrontDistribution != null;

        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain that hosts the sign-up and sign-in webpages
        /// for your application.
        /// </para>
        /// </summary>
        public CustomDomainConfigType CustomDomainConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainConfig property is set.
        /// </summary>
        internal bool IsSetCustomDomainConfig() => this.CustomDomainConfig != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain string. For custom domains, this is the fully-qualified domain name, such
        /// as <c>auth.example.com</c>. For Amazon Cognito prefix domains, this is the prefix
        /// alone, such as <c>auth</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ManagedLoginVersion. 
        /// <para>
        /// The version of managed login branding that you want to apply to your domain. A value
        /// of <c>1</c> indicates hosted UI (classic) branding and a version of <c>2</c> indicates
        /// managed login branding.
        /// </para>
        ///  
        /// <para>
        /// Managed login requires that your user pool be configured for any <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-sign-in-feature-plans.html">feature
        /// plan</a> other than <c>Lite</c>.
        /// </para>
        /// </summary>
        public int? ManagedLoginVersion { get; set; }

        /// <summary>
        /// Checks to see if the ManagedLoginVersion property is set.
        /// </summary>
        internal bool IsSetManagedLoginVersion() => this.ManagedLoginVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Routing. 
        /// <para>
        /// The routing configuration for the domain, including failover settings for multi-region
        /// deployments. Currently only <c>Failover</c> configurations are allowed.
        /// </para>
        /// </summary>
        public RoutingType Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket where the static files for this domain are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 1024)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The domain status.
        /// </para>
        /// </summary>
        public DomainStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that the domain is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The app version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
