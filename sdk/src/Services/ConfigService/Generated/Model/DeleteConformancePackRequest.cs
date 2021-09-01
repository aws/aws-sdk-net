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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConformancePack operation.
    /// Deletes the specified conformance pack and all the Config rules, remediation actions,
    /// and all evaluation results within that conformance pack.
    /// 
    ///  
    /// <para>
    /// Config sets the conformance pack to <code>DELETE_IN_PROGRESS</code> until the deletion
    /// is complete. You cannot update a conformance pack while it is in this state.
    /// </para>
    /// </summary>
    public partial class DeleteConformancePackRequest : AmazonConfigServiceRequest
    {
        private string _conformancePackName;

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

    }
}