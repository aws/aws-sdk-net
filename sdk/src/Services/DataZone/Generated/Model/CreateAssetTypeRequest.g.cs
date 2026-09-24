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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateAssetType operation. Creates a custom asset
    /// type. <para> Prerequisites: </para> <ul> <li> <para> The <c>formsInput</c> field is
    /// required, however, can be passed as empty (e.g. <c>-forms-input {})</c>. </para> </li>
    /// <li> <para> You must have <c>CreateAssetType</c> permissions. </para> </li> <li> <para>
    /// The domain-identifier and owning-project-identifier must be valid and active. </para>
    /// </li> <li> <para> The name of the asset type must be unique within the domain — duplicate
    /// names will cause failure. </para> </li> <li> <para> JSON input must be valid — incorrect
    /// formatting causes Invalid JSON errors. </para> </li> </ul>
    /// </summary>
    public partial class CreateAssetTypeRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The descripton of the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The unique identifier of the Amazon DataZone domain where the custom asset type is
        /// being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property FormsInput. 
        /// <para>
        /// The metadata forms that are to be attached to the custom asset type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public Dictionary<string, FormEntryInput> FormsInput { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FormEntryInput>() : null;

        /// <summary>
        /// Checks to see if the FormsInput property is set.
        /// </summary>
        internal bool IsSetFormsInput() => this.FormsInput != null && (this.FormsInput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project that is to own the custom asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;
    }
}
