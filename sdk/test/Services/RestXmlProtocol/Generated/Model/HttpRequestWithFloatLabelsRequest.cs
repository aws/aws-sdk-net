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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the HttpRequestWithFloatLabels operation.
    /// 
    /// </summary>
    public partial class HttpRequestWithFloatLabelsRequest : AmazonRestXmlProtocolRequest
    {
        private double? _double;
        private float? _float;

        /// <summary>
        /// Gets and sets the property Double.
        /// </summary>
        [AWSProperty(Required=true)]
        public double Double
        {
            get { return this._double.GetValueOrDefault(); }
            set { this._double = value; }
        }

        // Check to see if Double property is set
        internal bool IsSetDouble()
        {
            return this._double.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Float.
        /// </summary>
        [AWSProperty(Required=true)]
        public float Float
        {
            get { return this._float.GetValueOrDefault(); }
            set { this._float = value; }
        }

        // Check to see if Float property is set
        internal bool IsSetFloat()
        {
            return this._float.HasValue; 
        }

    }
}