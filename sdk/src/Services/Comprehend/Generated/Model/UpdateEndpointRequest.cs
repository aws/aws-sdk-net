/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEndpoint operation.
    /// Updates information about the specified endpoint.
    /// </summary>
    public partial class UpdateEndpointRequest : AmazonComprehendRequest
    {
        private int? _desiredInferenceUnits;
        private string _endpointArn;

        /// <summary>
        /// Gets and sets the property DesiredInferenceUnits. 
        /// <para>
        ///  The desired number of inference units to be used by the model using this endpoint.
        /// Each inference unit represents of a throughput of 100 characters per second.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int DesiredInferenceUnits
        {
            get { return this._desiredInferenceUnits.GetValueOrDefault(); }
            set { this._desiredInferenceUnits = value; }
        }

        // Check to see if DesiredInferenceUnits property is set
        internal bool IsSetDesiredInferenceUnits()
        {
            return this._desiredInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the endpoint being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

    }
}