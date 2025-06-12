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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-traffic-shifting-using-aliases.html">traffic-shifting</a>
    /// configuration of a Lambda function alias.
    /// </summary>
    public partial class AliasRoutingConfiguration
    {
        private Dictionary<string, double> _additionalVersionWeights = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalVersionWeights. 
        /// <para>
        /// The second version, and the percentage of traffic that's routed to it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> AdditionalVersionWeights
        {
            get { return this._additionalVersionWeights; }
            set { this._additionalVersionWeights = value; }
        }

        // Check to see if AdditionalVersionWeights property is set
        internal bool IsSetAdditionalVersionWeights()
        {
            return this._additionalVersionWeights != null && (this._additionalVersionWeights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}