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
    /// Contains configuration information and metadata about a CloudFront function.
    /// </summary>
    public partial class FunctionSummary
    {
        private FunctionConfig _functionConfig;
        private FunctionMetadata _functionMetadata;
        private string _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property FunctionConfig. 
        /// <para>
        /// Contains configuration information about a CloudFront function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionConfig FunctionConfig
        {
            get { return this._functionConfig; }
            set { this._functionConfig = value; }
        }

        // Check to see if FunctionConfig property is set
        internal bool IsSetFunctionConfig()
        {
            return this._functionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionMetadata. 
        /// <para>
        /// Contains metadata about a CloudFront function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionMetadata FunctionMetadata
        {
            get { return this._functionMetadata; }
            set { this._functionMetadata = value; }
        }

        // Check to see if FunctionMetadata property is set
        internal bool IsSetFunctionMetadata()
        {
            return this._functionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the CloudFront function.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the CloudFront function.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}