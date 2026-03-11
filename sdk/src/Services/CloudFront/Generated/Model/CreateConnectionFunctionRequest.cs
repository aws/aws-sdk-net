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
    /// Container for the parameters to the CreateConnectionFunction operation.
    /// Creates a connection function.
    /// </summary>
    public partial class CreateConnectionFunctionRequest : AmazonCloudFrontRequest
    {
        private MemoryStream _connectionFunctionCode;
        private FunctionConfig _connectionFunctionConfig;
        private string _name;
        private Tags _tags;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionCode. 
        /// <para>
        /// The code for the connection function.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the connection function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}