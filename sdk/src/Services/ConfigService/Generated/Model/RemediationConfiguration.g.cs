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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An object that represents the details about the remediation configuration that includes
    /// the remediation action, parameters, and data to execute the action.
    /// </summary>
    public partial class RemediationConfiguration
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) of remediation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Automatic. 
        /// <para>
        /// The remediation is triggered automatically.
        /// </para>
        /// </summary>
        public bool? Automatic { get; set; }

        /// <summary>
        /// Checks to see if the Automatic property is set.
        /// </summary>
        internal bool IsSetAutomatic() => this.Automatic.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property CreatedByService. 
        /// <para>
        /// Name of the service that owns the service-linked rule, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CreatedByService { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByService property is set.
        /// </summary>
        internal bool IsSetCreatedByService() => this.CreatedByService != null;

        /// <summary>
        /// Gets and sets the property ExecutionControls. 
        /// <para>
        /// An ExecutionControls object.
        /// </para>
        /// </summary>
        public ExecutionControls ExecutionControls { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionControls property is set.
        /// </summary>
        internal bool IsSetExecutionControls() => this.ExecutionControls != null;

        /// <summary>
        /// Gets and sets the property MaximumAutomaticAttempts. 
        /// <para>
        /// The maximum number of failed attempts for auto-remediation. If you do not select a
        /// number, the default is 5.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify MaximumAutomaticAttempts as 5 with RetryAttemptSeconds
        /// as 50 seconds, Config will put a RemediationException on your behalf for the failing
        /// resource after the 5th failed attempt within 50 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaximumAutomaticAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaximumAutomaticAttempts property is set.
        /// </summary>
        internal bool IsSetMaximumAutomaticAttempts() => this.MaximumAutomaticAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An object of the RemediationParameterValue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public Dictionary<string, RemediationParameterValue> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RemediationParameterValue>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of a resource. 
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RetryAttemptSeconds. 
        /// <para>
        /// Time window to determine whether or not to add a remediation exception to prevent
        /// infinite remediation attempts. If <c>MaximumAutomaticAttempts</c> remediation attempts
        /// have been made under <c>RetryAttemptSeconds</c>, a remediation exception will be added
        /// to the resource. If you do not select a number, the default is 60 seconds. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>RetryAttemptSeconds</c> as 50 seconds and <c>MaximumAutomaticAttempts</c>
        /// as 5, Config will run auto-remediations 5 times within 50 seconds before adding a
        /// remediation exception to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2678000)]
        public long? RetryAttemptSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RetryAttemptSeconds property is set.
        /// </summary>
        internal bool IsSetRetryAttemptSeconds() => this.RetryAttemptSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// Target ID is the name of the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target. Target executes remediation. For example, SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// Version of the target. For example, version of the SSM document.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you make backward incompatible changes to the SSM document, you must call PutRemediationConfiguration
        /// API again to ensure the remediations can run.
        /// </para>
        ///  </note>
        /// </summary>
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;
    }
}
