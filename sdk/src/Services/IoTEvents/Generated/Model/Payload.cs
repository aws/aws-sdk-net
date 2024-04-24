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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information needed to configure the payload.
    /// 
    ///  
    /// <para>
    /// By default, AWS IoT Events generates a standard payload in JSON for any action. This
    /// action payload contains all attribute-value pairs that have the information about
    /// the detector model instance and the event triggered the action. To configure the action
    /// payload, you can use <c>contentExpression</c>.
    /// </para>
    /// </summary>
    public partial class Payload
    {
        private string _contentExpression;
        private PayloadType _type;

        /// <summary>
        /// Gets and sets the property ContentExpression. 
        /// <para>
        /// The content of the payload. You can use a string expression that includes quoted strings
        /// (<c>'&lt;string&gt;'</c>), variables (<c>$variable.&lt;variable-name&gt;</c>), input
        /// values (<c>$input.&lt;input-name&gt;.&lt;path-to-datum&gt;</c>), string concatenations,
        /// and quoted strings that contain <c>${}</c> as the content. The recommended maximum
        /// size of a content expression is 1 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ContentExpression
        {
            get { return this._contentExpression; }
            set { this._contentExpression = value; }
        }

        // Check to see if ContentExpression property is set
        internal bool IsSetContentExpression()
        {
            return this._contentExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The value of the payload type can be either <c>STRING</c> or <c>JSON</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PayloadType Type
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