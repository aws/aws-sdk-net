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
    /// This is the response object from the DescribeApp operation.
    /// </summary>
    public partial class DescribeAppResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string AppName { get; set; }

        /// <summary>
        /// Checks to see if the AppName property is set.
        /// </summary>
        internal bool IsSetAppName() => this.AppName != null;

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of app.
        /// </para>
        /// </summary>
        public AppType AppType { get; set; }

        /// <summary>
        /// Checks to see if the AppType property is set.
        /// </summary>
        internal bool IsSetAppType() => this.AppType != null;

        /// <summary>
        /// Gets and sets the property BuiltInLifecycleConfigArn. 
        /// <para>
        /// The lifecycle configuration that runs before the default lifecycle configuration
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BuiltInLifecycleConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the BuiltInLifecycleConfigArn property is set.
        /// </summary>
        internal bool IsSetBuiltInLifecycleConfigArn() => this.BuiltInLifecycleConfigArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the application.
        /// </para>
        ///  <note> 
        /// <para>
        /// After an application has been shut down for 24 hours, SageMaker AI deletes all metadata
        /// for the application. To be considered an update and retain application metadata, applications
        /// must be restarted within 24 hours after the previous application has been shut down.
        /// After this time window, creation of an application is considered a new application
        /// rather than an update of the previous application.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EffectiveTrustedIdentityPropagationStatus. 
        /// <para>
        /// The effective status of Trusted Identity Propagation (TIP) for this application. When
        /// enabled, user identities from IAM Identity Center are being propagated through the
        /// application to TIP enabled Amazon Web Services services. When disabled, standard IAM
        /// role-based access is used. 
        /// </para>
        /// </summary>
        public FeatureStatus EffectiveTrustedIdentityPropagationStatus { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveTrustedIdentityPropagationStatus property is set.
        /// </summary>
        internal bool IsSetEffectiveTrustedIdentityPropagationStatus() => this.EffectiveTrustedIdentityPropagationStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastHealthCheckTimestamp. 
        /// <para>
        /// The timestamp of the last health check.
        /// </para>
        /// </summary>
        public DateTime? LastHealthCheckTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastHealthCheckTimestamp property is set.
        /// </summary>
        internal bool IsSetLastHealthCheckTimestamp() => this.LastHealthCheckTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUserActivityTimestamp. 
        /// <para>
        /// The timestamp of the last user's activity. <c>LastUserActivityTimestamp</c> is also
        /// updated when SageMaker AI performs health checks without user activity. As a result,
        /// this value is set to the same value as <c>LastHealthCheckTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? LastUserActivityTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUserActivityTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUserActivityTimestamp() => this.LastUserActivityTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryMode. 
        /// <para>
        ///  Indicates whether the application is launched in recovery mode. 
        /// </para>
        /// </summary>
        public bool? RecoveryMode { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryMode property is set.
        /// </summary>
        internal bool IsSetRecoveryMode() => this.RecoveryMode.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceSpec. 
        /// <para>
        /// The instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created
        /// on the instance.
        /// </para>
        /// </summary>
        public ResourceSpec ResourceSpec { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpec property is set.
        /// </summary>
        internal bool IsSetResourceSpec() => this.ResourceSpec != null;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space. If this value is not set, then <c>UserProfileName</c> must
        /// be set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public AppStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string UserProfileName { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileName property is set.
        /// </summary>
        internal bool IsSetUserProfileName() => this.UserProfileName != null;
    }
}
