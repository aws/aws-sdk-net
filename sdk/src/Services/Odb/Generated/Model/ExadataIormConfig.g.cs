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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The IORM settings of the Exadata DB system.
    /// </summary>
    public partial class ExadataIormConfig
    {
        /// <summary>
        /// Gets and sets the property DbPlans. 
        /// <para>
        /// An array of IORM settings for all the database in the Exadata DB system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DbIormConfig> DbPlans { get; set; } = AWSConfigs.InitializeCollections ? new List<DbIormConfig>() : null;

        /// <summary>
        /// Checks to see if the DbPlans property is set.
        /// </summary>
        internal bool IsSetDbPlans() => this.DbPlans != null && (this.DbPlans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LifecycleDetails. 
        /// <para>
        /// Additional information about the current lifecycleState.
        /// </para>
        /// </summary>
        public string LifecycleDetails { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleDetails property is set.
        /// </summary>
        internal bool IsSetLifecycleDetails() => this.LifecycleDetails != null;

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The current state of IORM configuration for the Exadata DB system.
        /// </para>
        /// </summary>
        public IormLifecycleState LifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleState property is set.
        /// </summary>
        internal bool IsSetLifecycleState() => this.LifecycleState != null;

        /// <summary>
        /// Gets and sets the property Objective. 
        /// <para>
        /// The current value for the IORM objective. The default is AUTO.
        /// </para>
        /// </summary>
        public Objective Objective { get; set; }

        /// <summary>
        /// Checks to see if the Objective property is set.
        /// </summary>
        internal bool IsSetObjective() => this.Objective != null;
    }
}
