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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
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
namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// This is the response object from the GetResourceRequestStatus operation.
    /// </summary>
    public partial class GetResourceRequestStatusResponse : AmazonWebServiceResponse
    {
        private List<HookProgressEvent> _hooksProgressEvent = AWSConfigs.InitializeCollections ? new List<HookProgressEvent>() : null;
        private ProgressEvent _progressEvent;

        /// <summary>
        /// Gets and sets the property HooksProgressEvent. 
        /// <para>
        /// Lists Hook invocations for the specified target in the request. This is a list since
        /// the same target can invoke multiple Hooks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HookProgressEvent> HooksProgressEvent
        {
            get { return this._hooksProgressEvent; }
            set { this._hooksProgressEvent = value; }
        }

        // Check to see if HooksProgressEvent property is set
        internal bool IsSetHooksProgressEvent()
        {
            return this._hooksProgressEvent != null && (this._hooksProgressEvent.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProgressEvent. 
        /// <para>
        /// Represents the current status of the resource operation request.
        /// </para>
        /// </summary>
        public ProgressEvent ProgressEvent
        {
            get { return this._progressEvent; }
            set { this._progressEvent = value; }
        }

        // Check to see if ProgressEvent property is set
        internal bool IsSetProgressEvent()
        {
            return this._progressEvent != null;
        }

    }
}