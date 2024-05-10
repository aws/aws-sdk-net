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
    /// The object containing details about heterogeneous database preferences.
    /// </summary>
    public partial class Heterogeneous
    {
        private List<string> _targetDatabaseEngine = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TargetDatabaseEngine. 
        /// <para>
        ///  The target database engine for heterogeneous database migration preference. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> TargetDatabaseEngine
        {
            get { return this._targetDatabaseEngine; }
            set { this._targetDatabaseEngine = value; }
        }

        // Check to see if TargetDatabaseEngine property is set
        internal bool IsSetTargetDatabaseEngine()
        {
            return this._targetDatabaseEngine != null && (this._targetDatabaseEngine.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}