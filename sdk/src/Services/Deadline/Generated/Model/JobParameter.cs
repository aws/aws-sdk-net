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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of job parameters.
    /// </summary>
    public partial class JobParameter
    {
        private string _float;
        private string _int;
        private string _path;
        private string _string;

        /// <summary>
        /// Gets and sets the property Float. 
        /// <para>
        /// A double precision IEEE-754 floating point number represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string Float
        {
            get { return this._float; }
            set { this._float = value; }
        }

        // Check to see if Float property is set
        internal bool IsSetFloat()
        {
            return this._float != null;
        }

        /// <summary>
        /// Gets and sets the property Int. 
        /// <para>
        /// A signed integer represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Int
        {
            get { return this._int; }
            set { this._int = value; }
        }

        // Check to see if Int property is set
        internal bool IsSetInt()
        {
            return this._int != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A file system path represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// A UTF-8 string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

    }
}