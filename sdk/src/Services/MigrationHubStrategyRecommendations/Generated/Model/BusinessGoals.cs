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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Business goals that you specify.
    /// </summary>
    public partial class BusinessGoals
    {
        private int? _licenseCostReduction;
        private int? _modernizeInfrastructureWithCloudNativeTechnologies;
        private int? _reduceOperationalOverheadWithManagedServices;
        private int? _speedOfMigration;

        /// <summary>
        /// Gets and sets the property LicenseCostReduction. 
        /// <para>
        ///  Business goal to reduce license costs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? LicenseCostReduction
        {
            get { return this._licenseCostReduction; }
            set { this._licenseCostReduction = value; }
        }

        // Check to see if LicenseCostReduction property is set
        internal bool IsSetLicenseCostReduction()
        {
            return this._licenseCostReduction.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModernizeInfrastructureWithCloudNativeTechnologies. 
        /// <para>
        ///  Business goal to modernize infrastructure by moving to cloud native technologies.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? ModernizeInfrastructureWithCloudNativeTechnologies
        {
            get { return this._modernizeInfrastructureWithCloudNativeTechnologies; }
            set { this._modernizeInfrastructureWithCloudNativeTechnologies = value; }
        }

        // Check to see if ModernizeInfrastructureWithCloudNativeTechnologies property is set
        internal bool IsSetModernizeInfrastructureWithCloudNativeTechnologies()
        {
            return this._modernizeInfrastructureWithCloudNativeTechnologies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReduceOperationalOverheadWithManagedServices. 
        /// <para>
        ///  Business goal to reduce the operational overhead on the team by moving into managed
        /// services. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? ReduceOperationalOverheadWithManagedServices
        {
            get { return this._reduceOperationalOverheadWithManagedServices; }
            set { this._reduceOperationalOverheadWithManagedServices = value; }
        }

        // Check to see if ReduceOperationalOverheadWithManagedServices property is set
        internal bool IsSetReduceOperationalOverheadWithManagedServices()
        {
            return this._reduceOperationalOverheadWithManagedServices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpeedOfMigration. 
        /// <para>
        ///  Business goal to achieve migration at a fast pace. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? SpeedOfMigration
        {
            get { return this._speedOfMigration; }
            set { this._speedOfMigration = value; }
        }

        // Check to see if SpeedOfMigration property is set
        internal bool IsSetSpeedOfMigration()
        {
            return this._speedOfMigration.HasValue; 
        }

    }
}