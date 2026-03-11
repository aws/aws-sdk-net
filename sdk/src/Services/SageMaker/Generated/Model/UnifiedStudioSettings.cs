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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The settings that apply to an Amazon SageMaker AI domain when you use it in Amazon
    /// SageMaker Unified Studio.
    /// </summary>
    public partial class UnifiedStudioSettings
    {
        private string _domainAccountId;
        private string _domainId;
        private string _domainRegion;
        private string _environmentId;
        private string _projectId;
        private string _projectS3Path;
        private string _singleSignOnApplicationArn;
        private FeatureStatus _studioWebPortalAccess;

        /// <summary>
        /// Gets and sets the property DomainAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that has the Amazon SageMaker Unified Studio
        /// domain. The default value, if you don't specify an ID, is the ID of the account that
        /// has the Amazon SageMaker AI domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainAccountId
        {
            get { return this._domainAccountId; }
            set { this._domainAccountId = value; }
        }

        // Check to see if DomainAccountId property is set
        internal bool IsSetDomainAccountId()
        {
            return this._domainAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon SageMaker Unified Studio domain associated with this domain.
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainRegion. 
        /// <para>
        /// The Amazon Web Services Region where the domain is located in Amazon SageMaker Unified
        /// Studio. The default value, if you don't specify a Region, is the Region where the
        /// Amazon SageMaker AI domain is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public string DomainRegion
        {
            get { return this._domainRegion; }
            set { this._domainRegion = value; }
        }

        // Check to see if DomainRegion property is set
        internal bool IsSetDomainRegion()
        {
            return this._domainRegion != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that Amazon SageMaker Unified Studio associates with the
        /// domain.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the Amazon SageMaker Unified Studio project that corresponds to the domain.
        /// </para>
        /// </summary>
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectS3Path. 
        /// <para>
        /// The location where Amazon S3 stores temporary execution data and other artifacts for
        /// the project that corresponds to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ProjectS3Path
        {
            get { return this._projectS3Path; }
            set { this._projectS3Path = value; }
        }

        // Check to see if ProjectS3Path property is set
        internal bool IsSetProjectS3Path()
        {
            return this._projectS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnApplicationArn. 
        /// <para>
        /// The ARN of the Amazon DataZone application managed by Amazon SageMaker Unified Studio
        /// in the Amazon Web Services IAM Identity Center.
        /// </para>
        /// </summary>
        public string SingleSignOnApplicationArn
        {
            get { return this._singleSignOnApplicationArn; }
            set { this._singleSignOnApplicationArn = value; }
        }

        // Check to see if SingleSignOnApplicationArn property is set
        internal bool IsSetSingleSignOnApplicationArn()
        {
            return this._singleSignOnApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property StudioWebPortalAccess. 
        /// <para>
        /// Sets whether you can access the domain in Amazon SageMaker Studio:
        /// </para>
        ///  <dl> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// You can access the domain in Amazon SageMaker Studio. If you migrate the domain to
        /// Amazon SageMaker Unified Studio, you can access it in both studio interfaces.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// You can't access the domain in Amazon SageMaker Studio. If you migrate the domain
        /// to Amazon SageMaker Unified Studio, you can access it only in that studio interface.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// To migrate a domain to Amazon SageMaker Unified Studio, you specify the UnifiedStudioSettings
        /// data type when you use the UpdateDomain action.
        /// </para>
        /// </summary>
        public FeatureStatus StudioWebPortalAccess
        {
            get { return this._studioWebPortalAccess; }
            set { this._studioWebPortalAccess = value; }
        }

        // Check to see if StudioWebPortalAccess property is set
        internal bool IsSetStudioWebPortalAccess()
        {
            return this._studioWebPortalAccess != null;
        }

    }
}