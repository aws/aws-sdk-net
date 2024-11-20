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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// This is the response object from the ApplyPendingMaintenanceAction operation.
    /// </summary>
    public partial class ApplyPendingMaintenanceActionResponse : AmazonWebServiceResponse
    {
        private ResourcePendingMaintenanceAction _resourcePendingMaintenanceAction;

        /// <summary>
        /// Gets and sets the property ResourcePendingMaintenanceAction. 
        /// <para>
        /// The output of the pending maintenance action being applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourcePendingMaintenanceAction ResourcePendingMaintenanceAction
        {
            get { return this._resourcePendingMaintenanceAction; }
            set { this._resourcePendingMaintenanceAction = value; }
        }

        // Check to see if ResourcePendingMaintenanceAction property is set
        internal bool IsSetResourcePendingMaintenanceAction()
        {
            return this._resourcePendingMaintenanceAction != null;
        }

    }
}