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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains the list of entities to be considered during an authorization request. This
    /// includes all principals, resources, and actions required to successfully evaluate
    /// the request.
    /// 
    ///  
    /// <para>
    /// This data type is used as a field in the response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class EntitiesDefinition
    {
        private List<EntityItem> _entityList = new List<EntityItem>();

        /// <summary>
        /// Gets and sets the property EntityList. 
        /// <para>
        /// An array of entities that are needed to successfully evaluate an authorization request.
        /// Each entity in this array must include an identifier for the entity, the attributes
        /// of the entity, and a list of any parent entities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<EntityItem> EntityList
        {
            get { return this._entityList; }
            set { this._entityList = value; }
        }

        // Check to see if EntityList property is set
        internal bool IsSetEntityList()
        {
            return this._entityList != null && this._entityList.Count > 0; 
        }

    }
}