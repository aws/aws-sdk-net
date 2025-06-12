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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Describes a launch template and overrides for a mixed instances policy.
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateDetails
    {
        private AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification _launchTemplateSpecification;
        private List<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetails> _overrides = AWSConfigs.InitializeCollections ? new List<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetails>() : null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateSpecification. 
        /// <para>
        /// The launch template to use for a mixed instances policy.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get { return this._launchTemplateSpecification; }
            set { this._launchTemplateSpecification = value; }
        }

        // Check to see if LaunchTemplateSpecification property is set
        internal bool IsSetLaunchTemplateSpecification()
        {
            return this._launchTemplateSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Property values to use to override the values in the launch template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyLaunchTemplateOverridesListDetails> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && (this._overrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}