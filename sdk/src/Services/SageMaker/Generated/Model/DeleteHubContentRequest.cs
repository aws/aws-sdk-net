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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHubContent operation.
    /// Delete the contents of a hub.
    /// 
    ///  <note> 
    /// <para>
    /// Hub APIs are only callable through SageMaker Studio.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteHubContentRequest : AmazonSageMakerRequest
    {
        private string _hubContentName;
        private HubContentType _hubContentType;
        private string _hubContentVersion;
        private string _hubName;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the content that you want to delete from a hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// The type of content that you want to delete from a hub.
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
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The version of the content that you want to delete from a hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=14)]
        public string HubContentVersion
        {
            get { return this._hubContentVersion; }
            set { this._hubContentVersion = value; }
        }

        // Check to see if HubContentVersion property is set
        internal bool IsSetHubContentVersion()
        {
            return this._hubContentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub that you want to delete content in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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

    }
}