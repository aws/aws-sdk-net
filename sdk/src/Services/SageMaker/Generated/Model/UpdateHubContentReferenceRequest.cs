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
    /// Container for the parameters to the UpdateHubContentReference operation.
    /// Updates the contents of a SageMaker hub for a <c>ModelReference</c> resource. A <c>ModelReference</c>
    /// allows you to access public SageMaker JumpStart models from within your private hub.
    /// 
    ///  
    /// <para>
    /// When using this API, you can update the <c>MinVersion</c> field for additional flexibility
    /// in the model version. You shouldn't update any additional fields when using this API,
    /// because the metadata in your private hub should match the public JumpStart model's
    /// metadata.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you want to update a <c>Model</c> or <c>Notebook</c> resource in your hub, use
    /// the <c>UpdateHubContent</c> API instead.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about adding model references to your hub, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs-admin-guide-add-models.html">
    /// Add models to a private hub</a>.
    /// </para>
    /// </summary>
    public partial class UpdateHubContentReferenceRequest : AmazonSageMakerRequest
    {
        private string _hubContentName;
        private HubContentType _hubContentType;
        private string _hubName;
        private string _minVersion;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content resource that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The content type of the resource that you want to update. Only specify a <c>ModelReference</c>
        /// resource for this API. To update a <c>Model</c> or <c>Notebook</c> resource, use the
        /// <c>UpdateHubContent</c> API instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HubContentType HubContentType
        {
            get { return this._hubContentType; }
            set { this._hubContentType = value; }
        }

        // Check to see if HubContentType property is set
        internal bool IsSetHubContentType()
        {
            return this._hubContentType != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the SageMaker hub that contains the hub content you want to update. You
        /// can optionally use the hub ARN instead.
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
        /// The minimum hub content version of the referenced model that you want to use. The
        /// minimum version must be older than the latest available version of the referenced
        /// model. To support all versions of a model, set the value to <c>1.0.0</c>.
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

    }
}