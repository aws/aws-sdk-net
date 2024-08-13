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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Text transformations eliminate some of the unusual formatting that attackers use in
    /// web requests in an effort to bypass detection.
    /// </summary>
    public partial class TextTransformation
    {
        private int? _priority;
        private TextTransformationType _type;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Sets the relative processing order for multiple transformations. WAF processes all
        /// transformations, from lowest priority to highest, before inspecting the transformed
        /// content. The priorities don't need to be consecutive, but they must all be different.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// For detailed descriptions of each of the transformation types, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-transformation.html">Text
        /// transformations</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TextTransformationType Type
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