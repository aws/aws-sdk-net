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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StartAutomationExecution operation. Initiates
    /// execution of an Automation runbook.
    /// </summary>
    public partial class StartAutomationExecutionRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The CloudWatch alarm you want to apply to your automation.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token. The token must be unique, is case insensitive, enforces
        /// the UUID format, and can't be reused.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the SSM document to run. This can be a public document or a custom document.
        /// To run a shared document belonging to another account, specify the document ARN. For
        /// more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-ssm-sharing.html">Sharing
        /// SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the Automation runbook to use for this execution.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of targets allowed to run this task in parallel. You can specify
        /// a number, such as 10, or a percentage, such as 10%. The default value is <c>10</c>.
        /// </para>
        ///  
        /// <para>
        /// If both this parameter and the <c>TargetLocation:TargetsMaxConcurrency</c> are supplied,
        /// <c>TargetLocation:TargetsMaxConcurrency</c> takes precedence.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The number of errors that are allowed before the system stops running the automation
        /// on additional targets. You can specify either an absolute number of errors, for example
        /// 10, or a percentage of the target set, for example 10%. If you specify 3, for example,
        /// the system stops running the automation when the fourth error is received. If you
        /// specify 0, then the system stops running the automation on additional targets after
        /// the first error result is returned. If you run an automation on 50 resources and set
        /// max-errors to 10%, then the system stops running the automation on additional targets
        /// when the sixth error is received.
        /// </para>
        ///  
        /// <para>
        /// Executions that are already running an automation when max-errors is reached are allowed
        /// to complete, but some of these executions may fail as well. If you need to ensure
        /// that there won't be more than max-errors failed executions, set max-concurrency to
        /// 1 so the executions proceed one at a time.
        /// </para>
        ///  
        /// <para>
        /// If this parameter and the <c>TargetLocation:TargetsMaxErrors</c> parameter are both
        /// supplied, <c>TargetLocation:TargetsMaxErrors</c> takes precedence.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The execution mode of the automation. Valid modes include the following: Auto and
        /// Interactive. The default mode is Auto.
        /// </para>
        /// </summary>
        public ExecutionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map of execution parameters, which match the declared parameters in the
        /// Automation runbook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. You can specify a maximum of five
        /// tags for an automation. Tags enable you to categorize a resource in different ways,
        /// such as by purpose, owner, or environment. For example, you might want to tag an automation
        /// to identify an environment or operating system. In this case, you could specify the
        /// following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=environment,Value=test</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=OS,Value=Windows</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Array Members</c> maximum value is reported as 1000. This number includes capacity
        /// reserved for internal operations. When calling the <c>StartAutomationExecution</c>
        /// action, you can specify a maximum of 5 tags. You can, however, use the <a>AddTagsToResource</a>
        /// action to add up to a total of 50 tags to an existing automation configuration.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// A location is a combination of Amazon Web Services Regions and/or Amazon Web Services
        /// accounts where you want to run the automation. Use this operation to start an automation
        /// in multiple Amazon Web Services Regions and multiple Amazon Web Services accounts.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-automation-multiple-accounts-and-regions.html">Running
        /// automations in multiple Amazon Web Services Regions and accounts</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<TargetLocation> TargetLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetLocation>() : null;

        /// <summary>
        /// Checks to see if the TargetLocations property is set.
        /// </summary>
        internal bool IsSetTargetLocations() => this.TargetLocations != null && (this.TargetLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetLocationsURL. 
        /// <para>
        /// Specify a publicly accessible URL for a file that contains the <c>TargetLocations</c>
        /// body. Currently, only files in presigned Amazon S3 buckets are supported. 
        /// </para>
        /// </summary>
        public string TargetLocationsURL { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocationsURL property is set.
        /// </summary>
        internal bool IsSetTargetLocationsURL() => this.TargetLocationsURL != null;

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// A key-value mapping of document parameters to target resources. Both Targets and TargetMaps
        /// can't be specified together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public List<Dictionary<string, List<string>>> TargetMaps { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, List<string>>>() : null;

        /// <summary>
        /// Checks to see if the TargetMaps property is set.
        /// </summary>
        internal bool IsSetTargetMaps() => this.TargetMaps != null && (this.TargetMaps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The name of the parameter used as the target resource for the rate-controlled execution.
        /// Required if you specify targets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string TargetParameterName { get; set; }

        /// <summary>
        /// Checks to see if the TargetParameterName property is set.
        /// </summary>
        internal bool IsSetTargetParameterName() => this.TargetParameterName != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A key-value mapping to target resources. Required if you specify TargetParameterName.
        /// </para>
        ///  
        /// <para>
        /// If both this parameter and the <c>TargetLocation:Targets</c> parameter are supplied,
        /// <c>TargetLocation:Targets</c> takes precedence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
