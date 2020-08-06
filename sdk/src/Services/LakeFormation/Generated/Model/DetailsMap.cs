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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure containing the additional details to be returned in the <code>AdditionalDetails</code>
    /// attribute of <code>PrincipalResourcePermissions</code>.
    /// 
    ///  
    /// <para>
    /// If a catalog resource is shared through AWS Resource Access Manager (AWS RAM), then
    /// there will exist a corresponding RAM share resource ARN.
    /// </para>
    /// </summary>
    public partial class DetailsMap
    {
        private List<string> _resourceShare = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceShare. 
        /// <para>
        /// A share resource ARN for a catalog resource shared through AWS Resource Access Manager
        /// (AWS RAM).
        /// </para>
        /// </summary>
        public List<string> ResourceShare
        {
            get { return this._resourceShare; }
            set { this._resourceShare = value; }
        }

        // Check to see if ResourceShare property is set
        internal bool IsSetResourceShare()
        {
            return this._resourceShare != null && this._resourceShare.Count > 0; 
        }

    }
}