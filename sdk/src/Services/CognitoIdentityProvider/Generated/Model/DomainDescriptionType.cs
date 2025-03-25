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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
        private string _awsAccountId;
        private string _cloudFrontDistribution;
        private CustomDomainConfigType _customDomainConfig;
        private string _domain;
        private int? _managedLoginVersion;
        private string _s3Bucket;
        private DomainStatusType _status;
        private string _userPoolId;
        private string _version;

        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The Amazon Web Services account that you created the user pool in.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string AWSAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudFrontDistribution. 
        /// <para>
        /// The Amazon CloudFront endpoint that hosts your custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string CloudFrontDistribution
        {
            get { return this._cloudFrontDistribution; }
            set { this._cloudFrontDistribution = value; }
        }

        // Check to see if CloudFrontDistribution property is set
        internal bool IsSetCloudFrontDistribution()
        {
            return this._cloudFrontDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain that hosts the sign-up and sign-in webpages
        /// for your application.
        /// </para>
        /// </summary>
        public CustomDomainConfigType CustomDomainConfig
        {
            get { return this._customDomainConfig; }
            set { this._customDomainConfig = value; }
        }

        // Check to see if CustomDomainConfig property is set
        internal bool IsSetCustomDomainConfig()
        {
            return this._customDomainConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain string. For custom domains, this is the fully-qualified domain name, such
        /// as <c>auth.example.com</c>. For Amazon Cognito prefix domains, this is the prefix
        /// alone, such as <c>auth</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

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
        public int? ManagedLoginVersion
        {
            get { return this._managedLoginVersion; }
            set { this._managedLoginVersion = value; }
        }

        // Check to see if ManagedLoginVersion property is set
        internal bool IsSetManagedLoginVersion()
        {
            return this._managedLoginVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket where the static files for this domain are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=1024)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The domain status.
        /// </para>
        /// </summary>
        public DomainStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that the domain is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The app version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}