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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Identifies the entity or change set that was assessed.
    /// </summary>
    public partial class AssessmentTargetSummary
    {
        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The unique ID of the change set that was assessed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique ID of the entity that was assessed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;
    }
}
