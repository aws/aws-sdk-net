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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about EC2 capacity.
    /// </summary>
    public partial class EC2Capacity
    {
        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        ///  The family of the EC2 capacity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///  The maximum size of the EC2 capacity. 
        /// </para>
        /// </summary>
        public string MaxSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxSize property is set.
        /// </summary>
        internal bool IsSetMaxSize() => this.MaxSize != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        ///  The quantity of the EC2 capacity. 
        /// </para>
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity != null;
    }
}
