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
    /// Provides metadata for a security control, including its unique standard-agnostic
    /// identifier, title, description, severity, availability in Amazon Web Services Regions,
    /// and a link to remediation steps.
    /// </summary>
    public partial class SecurityControlDefinition
    {
        private RegionAvailabilityStatus _currentRegionAvailability;
        private List<string> _customizableProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private Dictionary<string, ParameterDefinition> _parameterDefinitions = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterDefinition>() : null;
        private string _remediationUrl;
        private string _securityControlId;
        private SeverityRating _severityRating;
        private string _title;

        /// <summary>
        /// Gets and sets the property CurrentRegionAvailability. 
        /// <para>
        ///  Specifies whether a security control is available in the current Amazon Web Services
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionAvailabilityStatus CurrentRegionAvailability
        {
            get { return this._currentRegionAvailability; }
            set { this._currentRegionAvailability = value; }
        }

        // Check to see if CurrentRegionAvailability property is set
        internal bool IsSetCurrentRegionAvailability()
        {
            return this._currentRegionAvailability != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizableProperties. 
        /// <para>
        ///  Security control properties that you can customize. Currently, only parameter customization
        /// is supported for select controls. An empty array is returned for controls that don’t
        /// support custom properties. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomizableProperties
        {
            get { return this._customizableProperties; }
            set { this._customizableProperties = value; }
        }

        // Check to see if CustomizableProperties property is set
        internal bool IsSetCustomizableProperties()
        {
            return this._customizableProperties != null && (this._customizableProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of a security control across standards. This typically summarizes
        /// how Security Hub evaluates the control and the conditions under which it produces
        /// a failed finding. This parameter doesn't reference a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterDefinitions. 
        /// <para>
        ///  An object that provides a security control parameter name, description, and the options
        /// for customizing it. This object is excluded for a control that doesn't support custom
        /// parameters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ParameterDefinition> ParameterDefinitions
        {
            get { return this._parameterDefinitions; }
            set { this._parameterDefinitions = value; }
        }

        // Check to see if ParameterDefinitions property is set
        internal bool IsSetParameterDefinitions()
        {
            return this._parameterDefinitions != null && (this._parameterDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemediationUrl. 
        /// <para>
        ///  A link to Security Hub documentation that explains how to remediate a failed finding
        /// for a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RemediationUrl
        {
            get { return this._remediationUrl; }
            set { this._remediationUrl = value; }
        }

        // Check to see if RemediationUrl property is set
        internal bool IsSetRemediationUrl()
        {
            return this._remediationUrl != null;
        }

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
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityRating. 
        /// <para>
        ///  The severity of a security control. For more information about how Security Hub determines
        /// control severity, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/controls-findings-create-update.html#control-findings-severity">Assigning
        /// severity to control findings</a> in the <i>Security Hub User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SeverityRating SeverityRating
        {
            get { return this._severityRating; }
            set { this._severityRating = value; }
        }

        // Check to see if SeverityRating property is set
        internal bool IsSetSeverityRating()
        {
            return this._severityRating != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}