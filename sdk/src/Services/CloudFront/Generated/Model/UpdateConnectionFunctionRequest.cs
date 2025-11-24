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
    /// Container for the parameters to the UpdateConnectionFunction operation.
    /// Updates a connection function.
    /// </summary>
    public partial class UpdateConnectionFunctionRequest : AmazonCloudFrontRequest
    {
        private MemoryStream _connectionFunctionCode;
        private FunctionConfig _connectionFunctionConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionCode. 
        /// <para>
        /// The connection function code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=40960)]
        public MemoryStream ConnectionFunctionCode
        {
            get { return this._connectionFunctionCode; }
            set { this._connectionFunctionCode = value; }
        }

        // Check to see if ConnectionFunctionCode property is set
        internal bool IsSetConnectionFunctionCode()
        {
            return this._connectionFunctionCode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionFunctionConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionConfig ConnectionFunctionConfig
        {
            get { return this._connectionFunctionConfig; }
            set { this._connectionFunctionConfig = value; }
        }

        // Check to see if ConnectionFunctionConfig property is set
        internal bool IsSetConnectionFunctionConfig()
        {
            return this._connectionFunctionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The connection function ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the connection function you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return !string.IsNullOrEmpty(this._ifMatch);
        }

    }
}