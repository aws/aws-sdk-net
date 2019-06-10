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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSchema operation.
    /// Creates an Amazon Personalize schema from the specified schema string. The schema
    /// you create must be in Avro JSON format.
    /// 
    ///  
    /// <para>
    /// Amazon Personalize recognizes three schema variants. Each schema is associated with
    /// a dataset type and has a set of required field and keywords. You specify a schema
    /// when you call <a>CreateDataset</a>.
    /// </para>
    ///  <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListSchemas</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeSchema</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteSchema</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSchemaRequest : AmazonPersonalizeRequest
    {
        private string _name;
        private string _schema;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property Schema. 
        /// <para>
        /// A schema in Avro JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

    }
}