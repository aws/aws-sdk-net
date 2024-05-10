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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The import source for the key value store.
    /// </summary>
    public partial class ImportSource
    {
        private string _sourceARN;
        private ImportSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property SourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the import source for the key value store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceARN
        {
            get { return this._sourceARN; }
            set { this._sourceARN = value; }
        }

        // Check to see if SourceARN property is set
        internal bool IsSetSourceARN()
        {
            return this._sourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the import source for the key value store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}