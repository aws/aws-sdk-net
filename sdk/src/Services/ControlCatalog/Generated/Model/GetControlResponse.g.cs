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

namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// This is the response object from the GetControl operation.
    /// </summary>
    public partial class GetControlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A list of alternative identifiers for the control. These are human-readable designators,
        /// such as <c>SH.S3.1</c>. Several aliases can refer to the same control across different
        /// Amazon Web Services services or compliance frameworks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Aliases { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Aliases property is set.
        /// </summary>
        internal bool IsSetAliases() => this.Aliases != null && (this.Aliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// A term that identifies the control's functional behavior. One of <c>Preventive</c>,
        /// <c>Detective</c>, <c>Proactive</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ControlBehavior Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp that notes the time when the control was released (start of its life)
        /// as a governance capability in Amazon Web Services.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the control does.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GovernedProviders. 
        /// <para>
        /// A list of providers whose resources are governed by this control. For example, a value
        /// of <c>AWS</c> indicates that the control governs Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GovernedProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GovernedProviders property is set.
        /// </summary>
        internal bool IsSetGovernedProviders() => this.GovernedProviders != null && (this.GovernedProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GovernedResources. 
        /// <para>
        /// A list of resource types that are governed by this control. This information helps
        /// you understand which controls can govern certain types of resources, and conversely,
        /// which resources are affected when the control is implemented. For Amazon Web Services
        /// controls, the resources are represented as CloudFormation resource types. For non-Amazon
        /// Web Services controls, the resources are represented in a provider-specific format.
        /// If <c>GovernedResources</c> cannot be represented by available resource types, it’s
        /// returned as an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GovernedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GovernedResources property is set.
        /// </summary>
        internal bool IsSetGovernedResources() => this.GovernedResources != null && (this.GovernedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Implementation. 
        /// <para>
        /// Returns information about the control, as an <c>ImplementationDetails</c> object that
        /// shows the underlying implementation type for a control.
        /// </para>
        /// </summary>
        public ImplementationDetails Implementation { get; set; }

        /// <summary>
        /// Checks to see if the Implementation property is set.
        /// </summary>
        internal bool IsSetImplementation() => this.Implementation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterRequirementSummary. 
        /// <para>
        /// A summary that indicates whether the control requires parameters, accepts optional
        /// parameters, or does not support parameters. Use this field to determine whether you
        /// need to supply parameter values when you enable the control.
        /// </para>
        /// </summary>
        public ParameterRequirementSummary ParameterRequirementSummary { get; set; }

        /// <summary>
        /// Checks to see if the ParameterRequirementSummary property is set.
        /// </summary>
        internal bool IsSetParameterRequirementSummary() => this.ParameterRequirementSummary != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Returns an array of <c>ControlParameter</c> objects that specify the parameters a
        /// control supports. An empty list is returned for controls that don’t support parameters.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionConfiguration RegionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RegionConfiguration property is set.
        /// </summary>
        internal bool IsSetRegionConfiguration() => this.RegionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// An enumerated type, with the following possible values:
        /// </para>
        /// </summary>
        public ControlSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
