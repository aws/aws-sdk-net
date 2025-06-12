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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// This is the response object from the UpdateConfigurationProfile operation.
    /// </summary>
    public partial class UpdateConfigurationProfileResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private string _description;
        private string _id;
        private string _kmsKeyArn;
        private string _kmsKeyIdentifier;
        private string _locationUri;
        private string _name;
        private string _retrievalRoleArn;
        private string _type;
        private List<Validator> _validators = AWSConfigs.InitializeCollections ? new List<Validator>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The configuration profile description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The configuration profile ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name of the Key Management Service key to encrypt new configuration
        /// data versions in the AppConfig hosted configuration store. This attribute is only
        /// used for <c>hosted</c> configuration types. To encrypt data managed in other configuration
        /// stores, see the documentation for how to specify an KMS key for that particular service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Key Management Service key identifier (key ID, key alias, or key ARN) provided
        /// when the resource was created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI location of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RetrievalRoleArn. 
        /// <para>
        /// The ARN of an IAM role with permission to access the configuration at the specified
        /// <c>LocationUri</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RetrievalRoleArn
        {
            get { return this._retrievalRoleArn; }
            set { this._retrievalRoleArn = value; }
        }

        // Check to see if RetrievalRoleArn property is set
        internal bool IsSetRetrievalRoleArn()
        {
            return this._retrievalRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of configurations contained in the profile. AppConfig supports <c>feature
        /// flags</c> and <c>freeform</c> configurations. We recommend you create feature flag
        /// configurations to enable or disable new features and freeform configurations to distribute
        /// configurations to an application. When calling this API, enter one of the following
        /// values for <c>Type</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS.AppConfig.FeatureFlags</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS.Freeform</c> 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Validators. 
        /// <para>
        /// A list of methods for validating the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Validator> Validators
        {
            get { return this._validators; }
            set { this._validators = value; }
        }

        // Check to see if Validators property is set
        internal bool IsSetValidators()
        {
            return this._validators != null && (this._validators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}