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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppBlockBuilderStreamingURL operation.
    /// Creates a URL to start a create app block builder streaming session.
    /// </summary>
    public partial class CreateAppBlockBuilderStreamingURLRequest : AmazonAppStreamRequest
    {
        private string _appBlockBuilderName;
        private long? _validity;

        /// <summary>
        /// Gets and sets the property AppBlockBuilderName. 
        /// <para>
        /// The name of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppBlockBuilderName
        {
            get { return this._appBlockBuilderName; }
            set { this._appBlockBuilderName = value; }
        }

        // Check to see if AppBlockBuilderName property is set
        internal bool IsSetAppBlockBuilderName()
        {
            return this._appBlockBuilderName != null;
        }

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// The time that the streaming URL will be valid, in seconds. Specify a value between
        /// 1 and 604800 seconds. The default is 3600 seconds.
        /// </para>
        /// </summary>
        public long? Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity.HasValue; 
        }

    }
}