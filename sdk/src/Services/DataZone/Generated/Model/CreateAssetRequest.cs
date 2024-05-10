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
    /// Container for the parameters to the CreateAsset operation.
    /// Creates an asset in Amazon DataZone catalog.
    /// </summary>
    public partial class CreateAssetRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _description;
        private string _domainIdentifier;
        private string _externalIdentifier;
        private List<FormInput> _formsInput = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _owningProjectIdentifier;
        private PredictionConfiguration _predictionConfiguration;
        private string _typeIdentifier;
        private string _typeRevision;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Asset description.
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
        /// Amazon DataZone domain where the asset is created.
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
        /// Gets and sets the property ExternalIdentifier. 
        /// <para>
        /// The external identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ExternalIdentifier
        {
            get { return this._externalIdentifier; }
            set { this._externalIdentifier = value; }
        }

        // Check to see if ExternalIdentifier property is set
        internal bool IsSetExternalIdentifier()
        {
            return this._externalIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FormsInput. 
        /// <para>
        /// Metadata forms attached to the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10)]
        public List<FormInput> FormsInput
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
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// Glossary terms attached to the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Asset name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// The unique identifier of the project that owns this asset.
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

        /// <summary>
        /// Gets and sets the property PredictionConfiguration. 
        /// <para>
        /// The configuration of the automatically generated business-friendly metadata for the
        /// asset.
        /// </para>
        /// </summary>
        public PredictionConfiguration PredictionConfiguration
        {
            get { return this._predictionConfiguration; }
            set { this._predictionConfiguration = value; }
        }

        // Check to see if PredictionConfiguration property is set
        internal bool IsSetPredictionConfiguration()
        {
            return this._predictionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The unique identifier of this asset's type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=513)]
        public string TypeIdentifier
        {
            get { return this._typeIdentifier; }
            set { this._typeIdentifier = value; }
        }

        // Check to see if TypeIdentifier property is set
        internal bool IsSetTypeIdentifier()
        {
            return this._typeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision of this asset's type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TypeRevision
        {
            get { return this._typeRevision; }
            set { this._typeRevision = value; }
        }

        // Check to see if TypeRevision property is set
        internal bool IsSetTypeRevision()
        {
            return this._typeRevision != null;
        }

    }
}