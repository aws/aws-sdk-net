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
    /// The serializer that you want Firehose to use to convert data to the target format
    /// before writing it to Amazon S3. Firehose supports two types of serializers: the ORC
    /// SerDe and the Parquet SerDe.
    /// </summary>
    public partial class Serializer
    {
        private OrcSerDe _orcSerDe;
        private ParquetSerDe _parquetSerDe;

        /// <summary>
        /// Gets and sets the property OrcSerDe. 
        /// <para>
        /// A serializer to use for converting data to the ORC format before storing it in Amazon
        /// S3. For more information, see <a href="https://orc.apache.org/docs/">Apache ORC</a>.
        /// </para>
        /// </summary>
        public OrcSerDe OrcSerDe
        {
            get { return this._orcSerDe; }
            set { this._orcSerDe = value; }
        }

        // Check to see if OrcSerDe property is set
        internal bool IsSetOrcSerDe()
        {
            return this._orcSerDe != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetSerDe. 
        /// <para>
        /// A serializer to use for converting data to the Parquet format before storing it in
        /// Amazon S3. For more information, see <a href="https://parquet.apache.org/docs/contribution-guidelines/">Apache
        /// Parquet</a>.
        /// </para>
        /// </summary>
        public ParquetSerDe ParquetSerDe
        {
            get { return this._parquetSerDe; }
            set { this._parquetSerDe = value; }
        }

        // Check to see if ParquetSerDe property is set
        internal bool IsSetParquetSerDe()
        {
            return this._parquetSerDe != null;
        }

    }
}