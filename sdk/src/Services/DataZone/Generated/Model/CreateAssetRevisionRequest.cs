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
    /// Container for the parameters to the CreateAssetRevision operation.
    /// Creates a revision of the asset.
    /// 
    ///  
    /// <para>
    /// Asset revisions represent new versions of existing assets, capturing changes to either
    /// the underlying data or its metadata. They maintain a historical record of how assets
    /// evolve over time, who made changes, and when those changes occurred. This versioning
    /// capability is crucial for governance and compliance, allowing organizations to track
    /// changes, understand their impact, and roll back if necessary.
    /// </para>
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Asset must already exist in the domain with identifier. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The form type with correct revision must be registered in the same domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The form content must include all required fields (e.g., <c>bucketArn</c> for <c>S3ObjectCollectionForm</c>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The owning project of the original asset must still exist and be active.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User must have write access to the project and domain.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateAssetRevisionRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _description;
        private string _domainIdentifier;
        private List<FormInput> _formsInput = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;
        private string _name;
        private PredictionConfiguration _predictionConfiguration;
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
        /// The revised description of the asset.
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
        /// The unique identifier of the domain where the asset is being revised.
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
        /// The metadata forms to be attached to the asset as part of asset revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The glossary terms to be attached to the asset as part of asset revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Te revised name of the asset.
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
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision type of the asset.
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