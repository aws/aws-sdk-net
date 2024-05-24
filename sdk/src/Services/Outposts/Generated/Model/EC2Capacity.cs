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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private string _family;
        private string _maxSize;
        private string _quantity;

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        ///  The family of the EC2 capacity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }

        // Check to see if Family property is set
        internal bool IsSetFamily()
        {
            return this._family != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///  The maximum size of the EC2 capacity. 
        /// </para>
        /// </summary>
        public string MaxSize
        {
            get { return this._maxSize; }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        ///  The quantity of the EC2 capacity. 
        /// </para>
        /// </summary>
        public string Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity != null;
        }

    }
}