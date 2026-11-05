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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a recommendation of a target engine on Amazon
    /// RDS.
    /// </summary>
    public partial class RdsRecommendation
    {
        /// <summary>
        /// Gets and sets the property RequirementsToTarget. 
        /// <para>
        /// Supplemental information about the requirements to the recommended target database
        /// on Amazon RDS.
        /// </para>
        /// </summary>
        public RdsRequirements RequirementsToTarget { get; set; }

        /// <summary>
        /// Checks to see if the RequirementsToTarget property is set.
        /// </summary>
        internal bool IsSetRequirementsToTarget() => this.RequirementsToTarget != null;

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Supplemental information about the configuration of the recommended target database
        /// on Amazon RDS.
        /// </para>
        /// </summary>
        public RdsConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;
    }
}
