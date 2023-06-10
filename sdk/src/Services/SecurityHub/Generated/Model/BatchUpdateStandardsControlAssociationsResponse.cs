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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateStandardsControlAssociations operation.
    /// </summary>
    public partial class BatchUpdateStandardsControlAssociationsResponse : AmazonWebServiceResponse
    {
        private List<UnprocessedStandardsControlAssociationUpdate> _unprocessedAssociationUpdates = new List<UnprocessedStandardsControlAssociationUpdate>();

        /// <summary>
        /// Gets and sets the property UnprocessedAssociationUpdates. 
        /// <para>
        ///  A security control (identified with <code>SecurityControlId</code>, <code>SecurityControlArn</code>,
        /// or a mix of both parameters) whose enablement status in a specified standard couldn't
        /// be updated. 
        /// </para>
        /// </summary>
        public List<UnprocessedStandardsControlAssociationUpdate> UnprocessedAssociationUpdates
        {
            get { return this._unprocessedAssociationUpdates; }
            set { this._unprocessedAssociationUpdates = value; }
        }

        // Check to see if UnprocessedAssociationUpdates property is set
        internal bool IsSetUnprocessedAssociationUpdates()
        {
            return this._unprocessedAssociationUpdates != null && this._unprocessedAssociationUpdates.Count > 0; 
        }

    }
}