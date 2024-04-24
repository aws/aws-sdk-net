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
    /// Container for the parameters to the DeleteHomeRegionControl operation.
    /// This operation deletes the home region configuration for the calling account. The
    /// operation does not delete discovery or migration tracking data in the home region.
    /// </summary>
    public partial class DeleteHomeRegionControlRequest : AmazonMigrationHubConfigRequest
    {
        private string _controlId;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// A unique identifier that's generated for each home region control. It's always a string
        /// that begins with "hrc-" followed by 12 lowercase letters and numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

    }
}