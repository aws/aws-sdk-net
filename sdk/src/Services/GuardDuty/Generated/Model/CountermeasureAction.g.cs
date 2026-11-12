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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains an action that you can take to respond to a threat.
    /// </summary>
    public partial class CountermeasureAction
    {
        /// <summary>
        /// Gets and sets the property AffectedResources. 
        /// <para>
        /// The resources that the action applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<AffectedResource> AffectedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<AffectedResource>() : null;

        /// <summary>
        /// Checks to see if the AffectedResources property is set.
        /// </summary>
        internal bool IsSetAffectedResources() => this.AffectedResources != null && (this.AffectedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CliCommands. 
        /// <para>
        /// CLI commands that you can run to carry out the action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> CliCommands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CliCommands property is set.
        /// </summary>
        internal bool IsSetCliCommands() => this.CliCommands != null && (this.CliCommands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefenseTechnique. 
        /// <para>
        /// The defensive technique that the action applies.
        /// </para>
        /// </summary>
        public string DefenseTechnique { get; set; }

        /// <summary>
        /// Checks to see if the DefenseTechnique property is set.
        /// </summary>
        internal bool IsSetDefenseTechnique() => this.DefenseTechnique != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the action.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Disposition. 
        /// <para>
        /// The outcome of the action. Possible values are <c>Isolated</c>, <c>Blocked</c>, <c>Deleted</c>,
        /// <c>Access Revoked</c>, and <c>Logged</c>.
        /// </para>
        /// </summary>
        public Disposition Disposition { get; set; }

        /// <summary>
        /// Checks to see if the Disposition property is set.
        /// </summary>
        internal bool IsSetDisposition() => this.Disposition != null;

        /// <summary>
        /// Gets and sets the property DispositionId. 
        /// <para>
        /// The numeric identifier of the action's disposition.
        /// </para>
        /// </summary>
        public int? DispositionId { get; set; }

        /// <summary>
        /// Checks to see if the DispositionId property is set.
        /// </summary>
        internal bool IsSetDispositionId() => this.DispositionId.HasValue;

        /// <summary>
        /// Gets and sets the property Mitigates. 
        /// <para>
        /// The MITRE ATT&amp;CK technique IDs that the action mitigates, such as <c>T1059.004</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> Mitigates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Mitigates property is set.
        /// </summary>
        internal bool IsSetMitigates() => this.Mitigates != null && (this.Mitigates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the action. Possible values are <c>IMMEDIATE</c>, <c>SHORT_TERM</c>,
        /// and <c>STRATEGIC</c>.
        /// </para>
        /// </summary>
        public ActionPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title for the action.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
