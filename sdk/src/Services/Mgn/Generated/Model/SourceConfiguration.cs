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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Configuration for a migration source environment.
    /// </summary>
    public partial class SourceConfiguration
    {
        private SourceEnvironment _sourceEnvironment;
        private SourceS3Configuration _sources3Configuration;

        /// <summary>
        /// Gets and sets the property SourceEnvironment. 
        /// <para>
        /// The source environment type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceEnvironment SourceEnvironment
        {
            get { return this._sourceEnvironment; }
            set { this._sourceEnvironment = value; }
        }

        // Check to see if SourceEnvironment property is set
        internal bool IsSetSourceEnvironment()
        {
            return this._sourceEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Configuration. 
        /// <para>
        /// The S3 configuration for the source data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceS3Configuration SourceS3Configuration
        {
            get { return this._sources3Configuration; }
            set { this._sources3Configuration = value; }
        }

        // Check to see if SourceS3Configuration property is set
        internal bool IsSetSourceS3Configuration()
        {
            return this._sources3Configuration != null;
        }

    }
}