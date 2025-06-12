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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Configuration for enabling external data filtering for third-party applications to
    /// access data managed by Lake Formation .
    /// </summary>
    public partial class ExternalFilteringConfiguration
    {
        private List<string> _authorizedTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EnableStatus _status;

        /// <summary>
        /// Gets and sets the property AuthorizedTargets. 
        /// <para>
        /// List of third-party application <c>ARNs</c> integrated with Lake Formation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AuthorizedTargets
        {
            get { return this._authorizedTargets; }
            set { this._authorizedTargets = value; }
        }

        // Check to see if AuthorizedTargets property is set
        internal bool IsSetAuthorizedTargets()
        {
            return this._authorizedTargets != null && (this._authorizedTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Allows to enable or disable the third-party applications that are allowed to access
        /// data managed by Lake Formation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}