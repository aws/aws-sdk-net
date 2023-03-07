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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a recommendation of a target engine on Amazon
    /// RDS.
    /// </summary>
    public partial class RdsRecommendation
    {
        private RdsRequirements _requirementsToTarget;
        private RdsConfiguration _targetConfiguration;

        /// <summary>
        /// Gets and sets the property RequirementsToTarget. 
        /// <para>
        /// Supplemental information about the requirements to the recommended target database
        /// on Amazon RDS.
        /// </para>
        /// </summary>
        public RdsRequirements RequirementsToTarget
        {
            get { return this._requirementsToTarget; }
            set { this._requirementsToTarget = value; }
        }

        // Check to see if RequirementsToTarget property is set
        internal bool IsSetRequirementsToTarget()
        {
            return this._requirementsToTarget != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Supplemental information about the configuration of the recommended target database
        /// on Amazon RDS.
        /// </para>
        /// </summary>
        public RdsConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

    }
}