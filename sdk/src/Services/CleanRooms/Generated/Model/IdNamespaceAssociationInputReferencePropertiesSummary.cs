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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Detailed information about the ID namespace association input reference properties.
    /// </summary>
    public partial class IdNamespaceAssociationInputReferencePropertiesSummary
    {
        private IdNamespaceType _idNamespaceType;

        /// <summary>
        /// Gets and sets the property IdNamespaceType. 
        /// <para>
        /// The ID namespace type for this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdNamespaceType IdNamespaceType
        {
            get { return this._idNamespaceType; }
            set { this._idNamespaceType = value; }
        }

        // Check to see if IdNamespaceType property is set
        internal bool IsSetIdNamespaceType()
        {
            return this._idNamespaceType != null;
        }

    }
}