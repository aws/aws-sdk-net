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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DisassociateWorkspaceApplication operation.
    /// </summary>
    public partial class DisassociateWorkspaceApplicationResponse : AmazonWebServiceResponse
    {
        private WorkspaceResourceAssociation _association;

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        /// Information about the targeted association.
        /// </para>
        /// </summary>
        public WorkspaceResourceAssociation Association
        {
            get { return this._association; }
            set { this._association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this._association != null;
        }

    }
}