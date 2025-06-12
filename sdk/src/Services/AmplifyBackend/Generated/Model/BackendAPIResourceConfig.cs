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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The resource config for the data model, configured as a part of the Amplify project.
    /// </summary>
    public partial class BackendAPIResourceConfig
    {
        private List<BackendAPIAuthType> _additionalAuthTypes = AWSConfigs.InitializeCollections ? new List<BackendAPIAuthType>() : null;
        private string _apiName;
        private BackendAPIConflictResolution _conflictResolution;
        private BackendAPIAuthType _defaultAuthType;
        private string _service;
        private string _transformSchema;

        /// <summary>
        /// Gets and sets the property AdditionalAuthTypes. 
        /// <para>
        /// Additional authentication methods used to interact with your data models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BackendAPIAuthType> AdditionalAuthTypes
        {
            get { return this._additionalAuthTypes; }
            set { this._additionalAuthTypes = value; }
        }

        // Check to see if AdditionalAuthTypes property is set
        internal bool IsSetAdditionalAuthTypes()
        {
            return this._additionalAuthTypes != null && (this._additionalAuthTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApiName. 
        /// <para>
        /// The API name used to interact with the data model, configured as a part of your Amplify
        /// project.
        /// </para>
        /// </summary>
        public string ApiName
        {
            get { return this._apiName; }
            set { this._apiName = value; }
        }

        // Check to see if ApiName property is set
        internal bool IsSetApiName()
        {
            return this._apiName != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// The conflict resolution strategy for your data stored in the data models.
        /// </para>
        /// </summary>
        public BackendAPIConflictResolution ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAuthType. 
        /// <para>
        /// The default authentication type for interacting with the configured data models in
        /// your Amplify project.
        /// </para>
        /// </summary>
        public BackendAPIAuthType DefaultAuthType
        {
            get { return this._defaultAuthType; }
            set { this._defaultAuthType = value; }
        }

        // Check to see if DefaultAuthType property is set
        internal bool IsSetDefaultAuthType()
        {
            return this._defaultAuthType != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service used to provision and interact with the data model.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property TransformSchema. 
        /// <para>
        /// The definition of the data model in the annotated transform of the GraphQL schema.
        /// </para>
        /// </summary>
        public string TransformSchema
        {
            get { return this._transformSchema; }
            set { this._transformSchema = value; }
        }

        // Check to see if TransformSchema property is set
        internal bool IsSetTransformSchema()
        {
            return this._transformSchema != null;
        }

    }
}