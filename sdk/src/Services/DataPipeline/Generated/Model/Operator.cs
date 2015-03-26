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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains a logical operation for comparing the value of a field with a specified value.
    /// </summary>
    public partial class Operator
    {
        private OperatorType _type;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The logical operation to be performed: equal (<code>EQ</code>), equal reference (<code>REF_EQ</code>),
        /// less than or equal (<code>LE</code>), greater than or equal (<code>GE</code>), or
        /// between (<code>BETWEEN</code>). Equal reference (<code>REF_EQ</code>) can be used
        /// only with reference fields. The other comparison types can be used only with String
        /// fields. The comparison types you can use apply only to certain object fields, as detailed
        /// below. 
        /// </para>
        ///  
        /// <para>
        ///  The comparison operators EQ and REF_EQ act on the following fields: 
        /// </para>
        ///  <ul> <li>name</li> <li>@sphere</li> <li>parent</li> <li>@componentParent</li> <li>@instanceParent</li>
        /// <li>@status</li> <li>@scheduledStartTime</li> <li>@scheduledEndTime</li> <li>@actualStartTime</li>
        /// <li>@actualEndTime</li> </ul> 
        /// <para>
        ///  The comparison operators <code>GE</code>, <code>LE</code>, and <code>BETWEEN</code>
        /// act on the following fields: 
        /// </para>
        ///  <ul> <li>@scheduledStartTime</li> <li>@scheduledEndTime</li> <li>@actualStartTime</li>
        /// <li>@actualEndTime</li> </ul> 
        /// <para>
        /// Note that fields beginning with the at sign (@) are read-only and set by the web service.
        /// When you name fields, you should choose names containing only alpha-numeric values,
        /// as symbols may be reserved by AWS Data Pipeline. User-defined fields that you add
        /// to a pipeline should prefix their name with the string "my".
        /// </para>
        /// </summary>
        public OperatorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value that the actual field value will be compared with.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}