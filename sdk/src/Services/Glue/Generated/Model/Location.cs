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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The location of resources.
    /// </summary>
    public partial class Location
    {
        private List<CodeGenNodeArg> _jdbc = new List<CodeGenNodeArg>();
        private List<CodeGenNodeArg> _s3 = new List<CodeGenNodeArg>();

        /// <summary>
        /// Gets and sets the property Jdbc. 
        /// <para>
        /// A JDBC location.
        /// </para>
        /// </summary>
        public List<CodeGenNodeArg> Jdbc
        {
            get { return this._jdbc; }
            set { this._jdbc = value; }
        }

        // Check to see if Jdbc property is set
        internal bool IsSetJdbc()
        {
            return this._jdbc != null && this._jdbc.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// An Amazon S3 location.
        /// </para>
        /// </summary>
        public List<CodeGenNodeArg> S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null && this._s3.Count > 0; 
        }

    }
}