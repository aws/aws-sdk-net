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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// API stage name of the associated API stage in a usage plan.
    /// </summary>
    public partial class ApiStage
    {
        private string _apiId;
        private string _stage;
        private Dictionary<string, ThrottleSettings> _throttle = AWSConfigs.InitializeCollections ? new Dictionary<string, ThrottleSettings>() : null;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// API Id of the associated API stage in a usage plan.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// API stage name of the associated API stage in a usage plan.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property Throttle. 
        /// <para>
        /// Map containing method level throttling information for API stage in a usage plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ThrottleSettings> Throttle
        {
            get { return this._throttle; }
            set { this._throttle = value; }
        }

        // Check to see if Throttle property is set
        internal bool IsSetThrottle()
        {
            return this._throttle != null && (this._throttle.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}