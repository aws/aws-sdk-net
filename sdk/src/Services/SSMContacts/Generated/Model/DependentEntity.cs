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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about a resource that another resource is related to or depends on.
    /// 
    ///  
    /// <para>
    /// For example, if a contact is a member of a rotation, the rotation is a dependent entity
    /// of the contact.
    /// </para>
    /// </summary>
    public partial class DependentEntity
    {
        private List<string> _dependentResourceIds = new List<string>();
        private string _relationType;

        /// <summary>
        /// Gets and sets the property DependentResourceIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the dependent resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<string> DependentResourceIds
        {
            get { return this._dependentResourceIds; }
            set { this._dependentResourceIds = value; }
        }

        // Check to see if DependentResourceIds property is set
        internal bool IsSetDependentResourceIds()
        {
            return this._dependentResourceIds != null && this._dependentResourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelationType. 
        /// <para>
        /// The type of relationship between one resource and the other resource that it is related
        /// to or depends on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationType
        {
            get { return this._relationType; }
            set { this._relationType = value; }
        }

        // Check to see if RelationType property is set
        internal bool IsSetRelationType()
        {
            return this._relationType != null;
        }

    }
}