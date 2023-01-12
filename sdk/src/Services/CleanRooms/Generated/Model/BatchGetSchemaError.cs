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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// An error describing why a schema could not be fetched.
    /// </summary>
    public partial class BatchGetSchemaError
    {
        private string _code;
        private string _message;
        private string _name;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// An error code for the error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An error message for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An error name for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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

    }
}