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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// A dimension is a name/value pair that is part of the identity of a metric. Because
    /// dimensions are part of the unique identifier for a metric, whenever you add a unique
    /// name/value pair to one of your metrics, you are creating a new variation of that metric.
    /// For example, many Amazon EC2 metrics publish <code>InstanceId</code> as a dimension
    /// name, and the actual instance ID as the value for that dimension.
    /// 
    ///  
    /// <para>
    /// You can assign up to 30 dimensions to a metric.
    /// </para>
    /// </summary>
    public partial class Dimension
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dimension. Dimension names must contain only ASCII characters, must
        /// include at least one non-whitespace character, and cannot start with a colon (<code>:</code>).
        /// ASCII control characters are not supported as part of dimension names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the dimension. Dimension values must contain only ASCII characters and
        /// must include at least one non-whitespace character. ASCII control characters are not
        /// supported as part of dimension values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}