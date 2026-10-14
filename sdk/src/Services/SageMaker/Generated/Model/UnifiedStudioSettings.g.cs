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
    /// The settings that apply to an Amazon SageMaker AI domain when you use it in Amazon
    /// SageMaker Unified Studio.
    /// </summary>
    public partial class UnifiedStudioSettings
    {
        /// <summary>
        /// Gets and sets the property DomainAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that has the Amazon SageMaker Unified Studio
        /// domain. The default value, if you don't specify an ID, is the ID of the account that
        /// has the Amazon SageMaker AI domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainAccountId { get; set; }

        /// <summary>
        /// Checks to see if the DomainAccountId property is set.
        /// </summary>
        internal bool IsSetDomainAccountId() => this.DomainAccountId != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon SageMaker Unified Studio domain associated with this domain.
        /// </para>
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property DomainRegion. 
        /// <para>
        /// The Amazon Web Services Region where the domain is located in Amazon SageMaker Unified
        /// Studio. The default value, if you don't specify a Region, is the Region where the
        /// Amazon SageMaker AI domain is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public string DomainRegion { get; set; }

        /// <summary>
        /// Checks to see if the DomainRegion property is set.
        /// </summary>
        internal bool IsSetDomainRegion() => this.DomainRegion != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that Amazon SageMaker Unified Studio associates with the
        /// domain.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the Amazon SageMaker Unified Studio project that corresponds to the domain.
        /// </para>
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property ProjectS3Path. 
        /// <para>
        /// The location where Amazon S3 stores temporary execution data and other artifacts for
        /// the project that corresponds to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProjectS3Path { get; set; }

        /// <summary>
        /// Checks to see if the ProjectS3Path property is set.
        /// </summary>
        internal bool IsSetProjectS3Path() => this.ProjectS3Path != null;

        /// <summary>
        /// Gets and sets the property SingleSignOnApplicationArn. 
        /// <para>
        /// The ARN of the Amazon DataZone application managed by Amazon SageMaker Unified Studio
        /// in the Amazon Web Services IAM Identity Center.
        /// </para>
        /// </summary>
        public string SingleSignOnApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOnApplicationArn property is set.
        /// </summary>
        internal bool IsSetSingleSignOnApplicationArn() => this.SingleSignOnApplicationArn != null;

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
        public FeatureStatus StudioWebPortalAccess { get; set; }

        /// <summary>
        /// Checks to see if the StudioWebPortalAccess property is set.
        /// </summary>
        internal bool IsSetStudioWebPortalAccess() => this.StudioWebPortalAccess != null;
    }
}
