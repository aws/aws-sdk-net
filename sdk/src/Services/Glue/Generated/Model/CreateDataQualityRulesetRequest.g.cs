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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataQualityRuleset operation. Creates a
    /// data quality ruleset with DQDL rules applied to a specified Glue table. <para> You
    /// create the ruleset using the Data Quality Definition Language (DQDL). For more information,
    /// see the Glue developer guide. </para>
    /// </summary>
    public partial class CreateDataQualityRulesetRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for idempotency and is recommended to be set to a random ID (such as a UUID)
        /// to avoid creating or starting multiple instances of the same resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataQualitySecurityConfiguration. 
        /// <para>
        /// The name of the security configuration created with the data quality encryption option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DataQualitySecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataQualitySecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetDataQualitySecurityConfiguration() => this.DataQualitySecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// A Data Quality Definition Language (DQDL) ruleset. For more information, see the Glue
        /// developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string Ruleset { get; set; }

        /// <summary>
        /// Checks to see if the Ruleset property is set.
        /// </summary>
        internal bool IsSetRuleset() => this.Ruleset != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags applied to the data quality ruleset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// A target table associated with the data quality ruleset.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;
    }
}
