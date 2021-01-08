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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains details regarding all the supported <code>FieldTypes</code> and their corresponding
    /// <code>filterOperators</code> and <code>supportedValues</code>.
    /// </summary>
    public partial class SupportedFieldTypeDetails
    {
        private FieldTypeDetails _v1;

        /// <summary>
        /// Gets and sets the property V1. 
        /// <para>
        ///  The initial supported version for <code>fieldType</code>. If this is later changed
        /// to a different version, v2 will be introduced. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldTypeDetails V1
        {
            get { return this._v1; }
            set { this._v1 = value; }
        }

        // Check to see if V1 property is set
        internal bool IsSetV1()
        {
            return this._v1 != null;
        }

    }
}