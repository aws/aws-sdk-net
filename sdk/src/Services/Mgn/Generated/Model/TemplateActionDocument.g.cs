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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// </summary>
    public partial class TemplateActionDocument
    {
        /// <summary>
        /// Gets and sets the property ActionID. 
        /// <para>
        /// Template post migration custom action ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ActionID { get; set; }

        /// <summary>
        /// Checks to see if the ActionID property is set.
        /// </summary>
        internal bool IsSetActionID() => this.ActionID != null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// Template post migration custom action name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Template post migration custom action active status.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Template post migration custom action category.
        /// </para>
        /// </summary>
        public ActionCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Template post migration custom action description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentIdentifier. 
        /// <para>
        /// Template post migration custom action document identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DocumentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DocumentIdentifier property is set.
        /// </summary>
        internal bool IsSetDocumentIdentifier() => this.DocumentIdentifier != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// Template post migration custom action document version.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property ExternalParameters. 
        /// <para>
        /// Template post migration custom action external parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public Dictionary<string, SsmExternalParameter> ExternalParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SsmExternalParameter>() : null;

        /// <summary>
        /// Checks to see if the ExternalParameters property is set.
        /// </summary>
        internal bool IsSetExternalParameters() => this.ExternalParameters != null && (this.ExternalParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MustSucceedForCutover. 
        /// <para>
        /// Template post migration custom action must succeed for cutover.
        /// </para>
        /// </summary>
        public bool? MustSucceedForCutover { get; set; }

        /// <summary>
        /// Checks to see if the MustSucceedForCutover property is set.
        /// </summary>
        internal bool IsSetMustSucceedForCutover() => this.MustSucceedForCutover.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Operating system eligible for this template post migration custom action.
        /// </para>
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Template post migration custom action order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1001, Max = 10000)]
        public int? Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Template post migration custom action parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public Dictionary<string, List<SsmParameterStoreParameter>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<SsmParameterStoreParameter>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// Template post migration custom action timeout in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;
    }
}
