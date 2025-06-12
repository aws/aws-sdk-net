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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains information about an inference profile.
    /// </summary>
    public partial class InferenceProfileSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private string _inferenceProfileArn;
        private string _inferenceProfileId;
        private string _inferenceProfileName;
        private List<InferenceProfileModel> _models = AWSConfigs.InitializeCollections ? new List<InferenceProfileModel>() : null;
        private InferenceProfileStatus _status;
        private InferenceProfileType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the inference profile was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property InferenceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string InferenceProfileArn
        {
            get { return this._inferenceProfileArn; }
            set { this._inferenceProfileArn = value; }
        }

        // Check to see if InferenceProfileArn property is set
        internal bool IsSetInferenceProfileArn()
        {
            return this._inferenceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceProfileId. 
        /// <para>
        /// The unique identifier of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InferenceProfileId
        {
            get { return this._inferenceProfileId; }
            set { this._inferenceProfileId = value; }
        }

        // Check to see if InferenceProfileId property is set
        internal bool IsSetInferenceProfileId()
        {
            return this._inferenceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceProfileName. 
        /// <para>
        /// The name of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InferenceProfileName
        {
            get { return this._inferenceProfileName; }
            set { this._inferenceProfileName = value; }
        }

        // Check to see if InferenceProfileName property is set
        internal bool IsSetInferenceProfileName()
        {
            return this._inferenceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// A list of information about each model in the inference profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<InferenceProfileModel> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the inference profile. <c>ACTIVE</c> means that the inference profile
        /// is ready to be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the inference profile. The following types are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYSTEM_DEFINED</c> – The inference profile is defined by Amazon Bedrock. You can
        /// route inference requests across regions with these inference profiles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLICATION</c> – The inference profile was created by a user. This type of inference
        /// profile can track metrics and costs when invoking the model in it. The inference profile
        /// may route requests to one or multiple regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceProfileType Type
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the inference profile was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}