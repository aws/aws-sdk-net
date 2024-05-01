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
    /// Preferences for migrating an application to AWS.
    /// </summary>
    public partial class ManagementPreference
    {
        private AwsManagedResources _awsManagedResources;
        private NoManagementPreference _noPreference;
        private SelfManageResources _selfManageResources;

        /// <summary>
        /// Gets and sets the property AwsManagedResources. 
        /// <para>
        ///  Indicates interest in solutions that are managed by AWS. 
        /// </para>
        /// </summary>
        public AwsManagedResources AwsManagedResources
        {
            get { return this._awsManagedResources; }
            set { this._awsManagedResources = value; }
        }

        // Check to see if AwsManagedResources property is set
        internal bool IsSetAwsManagedResources()
        {
            return this._awsManagedResources != null;
        }

        /// <summary>
        /// Gets and sets the property NoPreference. 
        /// <para>
        ///  No specific preference. 
        /// </para>
        /// </summary>
        public NoManagementPreference NoPreference
        {
            get { return this._noPreference; }
            set { this._noPreference = value; }
        }

        // Check to see if NoPreference property is set
        internal bool IsSetNoPreference()
        {
            return this._noPreference != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManageResources. 
        /// <para>
        ///  Indicates interest in managing your own resources on AWS. 
        /// </para>
        /// </summary>
        public SelfManageResources SelfManageResources
        {
            get { return this._selfManageResources; }
            set { this._selfManageResources = value; }
        }

        // Check to see if SelfManageResources property is set
        internal bool IsSetSelfManageResources()
        {
            return this._selfManageResources != null;
        }

    }
}