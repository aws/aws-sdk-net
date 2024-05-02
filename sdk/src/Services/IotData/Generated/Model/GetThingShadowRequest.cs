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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
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
namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the GetThingShadow operation.
    /// Gets the shadow for the specified thing.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetThingShadow</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_GetThingShadow.html">GetThingShadow</a>
    /// in the IoT Developer Guide.
    /// </para>
    /// </summary>
    public partial class GetThingShadowRequest : AmazonIotDataRequest
    {
        private string _shadowName;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ShadowName. 
        /// <para>
        /// The name of the shadow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ShadowName
        {
            get { return this._shadowName; }
            set { this._shadowName = value; }
        }

        // Check to see if ShadowName property is set
        internal bool IsSetShadowName()
        {
            return this._shadowName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}