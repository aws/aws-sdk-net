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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Custom libraries to be loaded into a development endpoint.
    /// </summary>
    public partial class DevEndpointCustomLibraries
    {
        private string _extraJarsS3Path;
        private string _extraPythonLibsS3Path;

        /// <summary>
        /// Gets and sets the property ExtraJarsS3Path. 
        /// <para>
        /// The path to one or more Java <c>.jar</c> files in an S3 bucket that should be loaded
        /// in your <c>DevEndpoint</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use pure Java/Scala libraries with a <c>DevEndpoint</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExtraJarsS3Path
        {
            get { return this._extraJarsS3Path; }
            set { this._extraJarsS3Path = value; }
        }

        // Check to see if ExtraJarsS3Path property is set
        internal bool IsSetExtraJarsS3Path()
        {
            return this._extraJarsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraPythonLibsS3Path. 
        /// <para>
        /// The paths to one or more Python libraries in an Amazon Simple Storage Service (Amazon
        /// S3) bucket that should be loaded in your <c>DevEndpoint</c>. Multiple values must
        /// be complete paths separated by a comma.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use pure Python libraries with a <c>DevEndpoint</c>. Libraries that rely
        /// on C extensions, such as the <a href="http://pandas.pydata.org/">pandas</a> Python
        /// data analysis library, are not currently supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExtraPythonLibsS3Path
        {
            get { return this._extraPythonLibsS3Path; }
            set { this._extraPythonLibsS3Path = value; }
        }

        // Check to see if ExtraPythonLibsS3Path property is set
        internal bool IsSetExtraPythonLibsS3Path()
        {
            return this._extraPythonLibsS3Path != null;
        }

    }
}