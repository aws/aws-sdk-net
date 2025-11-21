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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssetType operation.
    /// Creates a custom asset type.
    /// 
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>formsInput</c> field is required, however, can be passed as empty (e.g. <c>-forms-input
    /// {})</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have <c>CreateAssetType</c> permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The domain-identifier and owning-project-identifier must be valid and active.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The name of the asset type must be unique within the domain — duplicate names will
    /// cause failure.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// JSON input must be valid — incorrect formatting causes Invalid JSON errors.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateAssetTypeRequest : AmazonDataZoneRequest
    {
        private string _description;
        private string _domainIdentifier;
        private Dictionary<string, FormEntryInput> _formsInput = AWSConfigs.InitializeCollections ? new Dictionary<string, FormEntryInput>() : null;
        private string _name;
        private string _owningProjectIdentifier;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The descripton of the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The unique identifier of the Amazon DataZone domain where the custom asset type is
        /// being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FormsInput. 
        /// <para>
        /// The metadata forms that are to be attached to the custom asset type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public Dictionary<string, FormEntryInput> FormsInput
        {
            get { return this._formsInput; }
            set { this._formsInput = value; }
        }

        // Check to see if FormsInput property is set
        internal bool IsSetFormsInput()
        {
            return this._formsInput != null && (this._formsInput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project that is to own the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwningProjectIdentifier
        {
            get { return this._owningProjectIdentifier; }
            set { this._owningProjectIdentifier = value; }
        }

        // Check to see if OwningProjectIdentifier property is set
        internal bool IsSetOwningProjectIdentifier()
        {
            return this._owningProjectIdentifier != null;
        }

    }
}