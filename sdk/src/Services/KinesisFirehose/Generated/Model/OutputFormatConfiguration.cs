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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies the serializer that you want Firehose to use to convert the format of your
    /// data before it writes it to Amazon S3. This parameter is required if <c>Enabled</c>
    /// is set to true.
    /// </summary>
    public partial class OutputFormatConfiguration
    {
        private Serializer _serializer;

        /// <summary>
        /// Gets and sets the property Serializer. 
        /// <para>
        /// Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet
        /// SerDe. If both are non-null, the server rejects the request.
        /// </para>
        /// </summary>
        public Serializer Serializer
        {
            get { return this._serializer; }
            set { this._serializer = value; }
        }

        // Check to see if Serializer property is set
        internal bool IsSetSerializer()
        {
            return this._serializer != null;
        }

    }
}