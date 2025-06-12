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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Information to define the hierarchy for which documents users should have access
    /// to.
    /// </summary>
    public partial class HierarchicalPrincipal
    {
        private List<Principal> _principalList = AWSConfigs.InitializeCollections ? new List<Principal>() : null;

        /// <summary>
        /// Gets and sets the property PrincipalList. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Principal.html">principal</a>
        /// lists that define the hierarchy for which documents users should have access to. Each
        /// hierarchical list specifies which user or group has allow or deny access for each
        /// document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Principal> PrincipalList
        {
            get { return this._principalList; }
            set { this._principalList = value; }
        }

        // Check to see if PrincipalList property is set
        internal bool IsSetPrincipalList()
        {
            return this._principalList != null && (this._principalList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}