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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Configuration for forwarding a single AWS service's events from the account's default
    /// event bus.
    /// </summary>
    public partial class AwsServiceEventsSourceConfiguration
    {
        private string _awsService;
        private OnFailureConfiguration _onFailureConfiguration;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property AwsService.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. 
        /// <para>
        /// The destination for events that could not be forwarded.
        /// </para>
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration
        {
            get { return this._onFailureConfiguration; }
            set { this._onFailureConfiguration = value; }
        }

        // Check to see if OnFailureConfiguration property is set
        internal bool IsSetOnFailureConfiguration()
        {
            return this._onFailureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// A filter pattern, as a JSON string, that defines which of the service's events are
        /// forwarded to the event bus. Do not include source, account, or region as top-level
        /// fields. If no pattern is specified, all events from the service are forwarded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=3753)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}