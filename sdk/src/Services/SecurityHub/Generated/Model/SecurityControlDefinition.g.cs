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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides metadata for a security control, including its unique standard-agnostic
    /// identifier, title, description, severity, availability in Amazon Web Services Regions,
    /// and a link to remediation steps.
    /// </summary>
    public partial class SecurityControlDefinition
    {
        /// <summary>
        /// Gets and sets the property CurrentRegionAvailability. 
        /// <para>
        ///  Specifies whether a security control is available in the current Amazon Web Services
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionAvailabilityStatus CurrentRegionAvailability { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRegionAvailability property is set.
        /// </summary>
        internal bool IsSetCurrentRegionAvailability() => this.CurrentRegionAvailability != null;

        /// <summary>
        /// Gets and sets the property CustomizableProperties. 
        /// <para>
        ///  Security control properties that you can customize. Currently, only parameter customization
        /// is supported for select controls. An empty array is returned for controls that don’t
        /// support custom properties. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomizableProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomizableProperties property is set.
        /// </summary>
        internal bool IsSetCustomizableProperties() => this.CustomizableProperties != null && (this.CustomizableProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of a security control across standards. This typically summarizes
        /// how Security Hub CSPM evaluates the control and the conditions under which it produces
        /// a failed finding. This parameter doesn't reference a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ParameterDefinitions. 
        /// <para>
        ///  An object that provides a security control parameter name, description, and the options
        /// for customizing it. This object is excluded for a control that doesn't support custom
        /// parameters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ParameterDefinition> ParameterDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterDefinition>() : null;

        /// <summary>
        /// Checks to see if the ParameterDefinitions property is set.
        /// </summary>
        internal bool IsSetParameterDefinitions() => this.ParameterDefinitions != null && (this.ParameterDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider whose resources the security control evaluates. For example, <c>AWS</c>
        /// or <c>Azure</c>.
        /// </para>
        /// </summary>
        public SecurityControlsProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property RemediationUrl. 
        /// <para>
        ///  A link to Security Hub CSPM documentation that explains how to remediate a failed
        /// finding for a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RemediationUrl { get; set; }

        /// <summary>
        /// Checks to see if the RemediationUrl property is set.
        /// </summary>
        internal bool IsSetRemediationUrl() => this.RemediationUrl != null;

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier of a security control across standards. Values for this field
        /// typically consist of an Amazon Web Services service name and a number (for example,
        /// APIGateway.3). This parameter differs from <c>SecurityControlArn</c>, which is a unique
        /// Amazon Resource Name (ARN) assigned to a control. The ARN references the security
        /// control ID (for example, arn:aws:securityhub:eu-central-1:123456789012:security-control/APIGateway.3).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityControlId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityControlId property is set.
        /// </summary>
        internal bool IsSetSecurityControlId() => this.SecurityControlId != null;

        /// <summary>
        /// Gets and sets the property SeverityRating. 
        /// <para>
        ///  The severity of a security control. For more information about how Security Hub CSPM
        /// determines control severity, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/controls-findings-create-update.html#control-findings-severity">Assigning
        /// severity to control findings</a> in the <i>Security Hub CSPM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SeverityRating SeverityRating { get; set; }

        /// <summary>
        /// Checks to see if the SeverityRating property is set.
        /// </summary>
        internal bool IsSetSeverityRating() => this.SeverityRating != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
