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
    /// Container for the parameters to the CreateHubContentReference operation.
    /// Create a hub content reference in order to add a model in the JumpStart public hub
    /// to a private hub.
    /// </summary>
    public partial class CreateHubContentReferenceRequest : AmazonSageMakerRequest
    {
        private string _hubContentName;
        private string _hubName;
        private string _minVersion;
        private string _sageMakerPublicHubContentArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string HubContentName
        {
            get { return this._hubContentName; }
            set { this._hubContentName = value; }
        }

        // Check to see if HubContentName property is set
        internal bool IsSetHubContentName()
        {
            return this._hubContentName != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub to add the hub content reference to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }

        // Check to see if HubName property is set
        internal bool IsSetHubName()
        {
            return this._hubName != null;
        }

        /// <summary>
        /// Gets and sets the property MinVersion. 
        /// <para>
        /// The minimum version of the hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=14)]
        public string MinVersion
        {
            get { return this._minVersion; }
            set { this._minVersion = value; }
        }

        // Check to see if MinVersion property is set
        internal bool IsSetMinVersion()
        {
            return this._minVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerPublicHubContentArn. 
        /// <para>
        /// The ARN of the public hub content to reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string SageMakerPublicHubContentArn
        {
            get { return this._sageMakerPublicHubContentArn; }
            set { this._sageMakerPublicHubContentArn = value; }
        }

        // Check to see if SageMakerPublicHubContentArn property is set
        internal bool IsSetSageMakerPublicHubContentArn()
        {
            return this._sageMakerPublicHubContentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the hub content to reference.
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