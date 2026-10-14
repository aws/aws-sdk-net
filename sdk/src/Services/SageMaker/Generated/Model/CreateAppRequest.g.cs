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
    /// Container for the parameters to the CreateApp operation. Creates a running app for
    /// the specified UserProfile. This operation is automatically invoked by Amazon SageMaker
    /// AI upon access to the associated Domain, and when new kernel configurations are selected
    /// by the user. A user may have multiple Apps active simultaneously.
    /// </summary>
    public partial class CreateAppRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
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
        [AWSProperty(Required = true)]
        public AppType AppType { get; set; }

        /// <summary>
        /// Checks to see if the AppType property is set.
        /// </summary>
        internal bool IsSetAppType() => this.AppType != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

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
        ///  <note> 
        /// <para>
        /// The value of <c>InstanceType</c> passed as part of the <c>ResourceSpec</c> in the
        /// <c>CreateApp</c> call overrides the value passed as part of the <c>ResourceSpec</c>
        /// configured for the user profile or the domain. If <c>InstanceType</c> is not specified
        /// in any of those three <c>ResourceSpec</c> values for a <c>KernelGateway</c> app, the
        /// <c>CreateApp</c> call fails with a request validation error.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name. If this value is not set, then <c>SpaceName</c> must be set.
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
