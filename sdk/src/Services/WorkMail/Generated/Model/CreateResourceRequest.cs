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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResource operation.
    /// Creates a new WorkMail resource.
    /// </summary>
    public partial class CreateResourceRequest : AmazonWorkMailRequest
    {
        private string _description;
        private bool? _hiddenFromGlobalAddressList;
        private string _name;
        private string _organizationId;
        private ResourceType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Resource description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If this parameter is enabled, the resource will be hidden from the address book.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList
        {
            get { return this._hiddenFromGlobalAddressList; }
            set { this._hiddenFromGlobalAddressList = value; }
        }

        // Check to see if HiddenFromGlobalAddressList property is set
        internal bool IsSetHiddenFromGlobalAddressList()
        {
            return this._hiddenFromGlobalAddressList.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier associated with the organization for which the resource is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the new resource. The available types are <c>equipment</c> and <c>room</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}