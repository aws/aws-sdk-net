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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Specifies the current source of the resource and the destination of where it will
    /// be moved to.
    /// </summary>
    public partial class ResourceMapping
    {
        private ResourceLocation _destination;
        private ResourceLocation _source;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination stack <c>StackName</c> and <c>LogicalResourceId</c> for the resource
        /// being refactored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceLocation Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source stack <c>StackName</c> and <c>LogicalResourceId</c> for the resource being
        /// refactored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceLocation Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}