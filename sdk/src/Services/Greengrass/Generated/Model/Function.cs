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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a Lambda function.
    /// </summary>
    public partial class Function
    {
        private string _functionArn;
        private FunctionConfiguration _functionConfiguration;
        private string _id;

        /// <summary>
        /// Gets and sets the property FunctionArn. The ARN of the Lambda function.
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionConfiguration. The configuration of the Lambda
        /// function.
        /// </summary>
        public FunctionConfiguration FunctionConfiguration
        {
            get { return this._functionConfiguration; }
            set { this._functionConfiguration = value; }
        }

        // Check to see if FunctionConfiguration property is set
        internal bool IsSetFunctionConfiguration()
        {
            return this._functionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Id. A descriptive or arbitrary ID for the function. This
        /// value must be unique within the function definition version. Max length is 128 characters
        /// with pattern ''[a-zA-Z0-9:_-]+''.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}