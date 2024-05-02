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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEventSourceMapping operation.
    /// Deletes an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-invocation-modes.html">event
    /// source mapping</a>. You can get the identifier of a mapping from the output of <a>ListEventSourceMappings</a>.
    /// 
    ///  
    /// <para>
    /// When you delete an event source mapping, it enters a <c>Deleting</c> state and might
    /// not be completely deleted for several seconds.
    /// </para>
    /// </summary>
    public partial class DeleteEventSourceMappingRequest : AmazonLambdaRequest
    {
        private string _uuid;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The identifier of the event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}