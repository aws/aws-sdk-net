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
    /// Transformer configuration for a subscriber.
    /// </summary>
    public partial class Transformer
    {
        private JsonataConfiguration _jsonataConfiguration;
        private TransformerType _type;

        /// <summary>
        /// Gets and sets the property JsonataConfiguration. 
        /// <para>
        /// JSONata expression configuration. Required when Type is JSONATA.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public JsonataConfiguration JsonataConfiguration
        {
            get { return this._jsonataConfiguration; }
            set { this._jsonataConfiguration = value; }
        }

        // Check to see if JsonataConfiguration property is set
        internal bool IsSetJsonataConfiguration()
        {
            return this._jsonataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Transform type.
        /// </para>
        /// </summary>
        public TransformerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}