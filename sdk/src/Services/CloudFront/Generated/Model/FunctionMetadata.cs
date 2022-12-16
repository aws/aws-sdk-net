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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains metadata about a CloudFront function.
    /// </summary>
    public partial class FunctionMetadata
    {
        private DateTime? _createdTime;
        private string _functionARN;
        private DateTime? _lastModifiedTime;
        private FunctionStage _stage;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time when the function was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FunctionARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function. The ARN uniquely identifies the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionARN
        {
            get { return this._functionARN; }
            set { this._functionARN = value; }
        }

        // Check to see if FunctionARN property is set
        internal bool IsSetFunctionARN()
        {
            return this._functionARN != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the function was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage that the function is in, either <code>DEVELOPMENT</code> or <code>LIVE</code>.
        /// </para>
        ///  
        /// <para>
        /// When a function is in the <code>DEVELOPMENT</code> stage, you can test the function
        /// with <code>TestFunction</code>, and update it with <code>UpdateFunction</code>.
        /// </para>
        ///  
        /// <para>
        /// When a function is in the <code>LIVE</code> stage, you can attach the function to
        /// a distribution's cache behavior, using the function's ARN.
        /// </para>
        /// </summary>
        public FunctionStage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}