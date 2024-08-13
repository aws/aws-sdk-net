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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the CreateApiDestination operation.
    /// </summary>
    public partial class CreateApiDestinationResponse : AmazonWebServiceResponse
    {
        private string _apiDestinationArn;
        private ApiDestinationState _apiDestinationState;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property ApiDestinationArn. 
        /// <para>
        /// The ARN of the API destination that was created by the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ApiDestinationArn
        {
            get { return this._apiDestinationArn; }
            set { this._apiDestinationArn = value; }
        }

        // Check to see if ApiDestinationArn property is set
        internal bool IsSetApiDestinationArn()
        {
            return this._apiDestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApiDestinationState. 
        /// <para>
        /// The state of the API destination that was created by the request.
        /// </para>
        /// </summary>
        public ApiDestinationState ApiDestinationState
        {
            get { return this._apiDestinationState; }
            set { this._apiDestinationState = value; }
        }

        // Check to see if ApiDestinationState property is set
        internal bool IsSetApiDestinationState()
        {
            return this._apiDestinationState != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating the time that the API destination was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A time stamp indicating the time that the API destination was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}