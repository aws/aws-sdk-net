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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStudioLifecycleConfig operation.
    /// Creates a new Amazon SageMaker AI Studio Lifecycle Configuration.
    /// </summary>
    public partial class CreateStudioLifecycleConfigRequest : AmazonSageMakerRequest
    {
        private StudioLifecycleConfigAppType _studioLifecycleConfigAppType;
        private string _studioLifecycleConfigContent;
        private string _studioLifecycleConfigName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigAppType. 
        /// <para>
        /// The App type that the Lifecycle Configuration is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StudioLifecycleConfigAppType StudioLifecycleConfigAppType
        {
            get { return this._studioLifecycleConfigAppType; }
            set { this._studioLifecycleConfigAppType = value; }
        }

        // Check to see if StudioLifecycleConfigAppType property is set
        internal bool IsSetStudioLifecycleConfigAppType()
        {
            return this._studioLifecycleConfigAppType != null;
        }

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigContent. 
        /// <para>
        /// The content of your Amazon SageMaker AI Studio Lifecycle Configuration script. This
        /// content must be base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
        public string StudioLifecycleConfigContent
        {
            get { return this._studioLifecycleConfigContent; }
            set { this._studioLifecycleConfigContent = value; }
        }

        // Check to see if StudioLifecycleConfigContent property is set
        internal bool IsSetStudioLifecycleConfigContent()
        {
            return this._studioLifecycleConfigContent != null;
        }

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigName. 
        /// <para>
        /// The name of the Amazon SageMaker AI Studio Lifecycle Configuration to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string StudioLifecycleConfigName
        {
            get { return this._studioLifecycleConfigName; }
            set { this._studioLifecycleConfigName = value; }
        }

        // Check to see if StudioLifecycleConfigName property is set
        internal bool IsSetStudioLifecycleConfigName()
        {
            return this._studioLifecycleConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be associated with the Lifecycle Configuration. Each tag consists of a key
        /// and an optional value. Tag keys must be unique per resource. Tags are searchable using
        /// the Search API. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}