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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Schema configuration that controls how Apache Kafka record values are validated.
    /// </summary>
    public partial class RecordSchema
    {
        private string _gsrArn;

        /// <summary>
        /// Gets and sets the property GsrArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Glue Schema Registry schema (not registry)
        /// used to validate records for the destination Apache Iceberg table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GsrArn
        {
            get { return this._gsrArn; }
            set { this._gsrArn = value; }
        }

        // Check to see if GsrArn property is set
        internal bool IsSetGsrArn()
        {
            return this._gsrArn != null;
        }

    }
}