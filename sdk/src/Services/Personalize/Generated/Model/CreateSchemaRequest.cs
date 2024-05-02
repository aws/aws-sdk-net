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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
    /// a dataset type and has a set of required field and keywords. If you are creating a
    /// schema for a dataset in a Domain dataset group, you provide the domain of the Domain
    /// dataset group. You specify a schema when you call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSchemas.html">ListSchemas</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSchema.html">DescribeSchema</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteSchema.html">DeleteSchema</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSchemaRequest : AmazonPersonalizeRequest
    {
        private Domain _domain;
        private string _name;
        private string _schema;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain for the schema. If you are creating a schema for a dataset in a Domain
        /// dataset group, specify the domain you chose when you created the Domain dataset group.
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

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
        [AWSProperty(Required=true, Max=20000)]
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