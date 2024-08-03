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
    /// Provides the information for the ID namespace association input reference configuration.
    /// </summary>
    public partial class IdNamespaceAssociationInputReferenceConfig
    {
        private string _inputReferenceArn;
        private bool? _manageResourcePolicies;

        /// <summary>
        /// Gets and sets the property InputReferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Entity Resolution resource that is being associated
        /// to the collaboration. Valid resource ARNs are from the ID namespaces that you own.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string InputReferenceArn
        {
            get { return this._inputReferenceArn; }
            set { this._inputReferenceArn = value; }
        }

        // Check to see if InputReferenceArn property is set
        internal bool IsSetInputReferenceArn()
        {
            return this._inputReferenceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManageResourcePolicies. 
        /// <para>
        /// When <c>TRUE</c>, Clean Rooms manages permissions for the ID namespace association
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// When <c>FALSE</c>, the resource owner manages permissions for the ID namespace association
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ManageResourcePolicies
        {
            get { return this._manageResourcePolicies; }
            set { this._manageResourcePolicies = value; }
        }

        // Check to see if ManageResourcePolicies property is set
        internal bool IsSetManageResourcePolicies()
        {
            return this._manageResourcePolicies.HasValue; 
        }

    }
}