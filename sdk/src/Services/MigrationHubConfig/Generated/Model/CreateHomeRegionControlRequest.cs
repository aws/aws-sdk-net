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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
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
namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHomeRegionControl operation.
    /// This API sets up the home region for the calling account only.
    /// </summary>
    public partial class CreateHomeRegionControlRequest : AmazonMigrationHubConfigRequest
    {
        private bool? _dryRun;
        private string _homeRegion;
        private Target _target;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional Boolean flag to indicate whether any effect should take place. It tests whether
        /// the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The name of the home region of the calling account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The account for which this command sets up a home region control. The <c>Target</c>
        /// is always of type <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Target Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}