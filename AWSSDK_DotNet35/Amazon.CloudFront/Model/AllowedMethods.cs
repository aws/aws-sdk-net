/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.
    /// There are two options: - CloudFront forwards only GET and HEAD requests. - CloudFront forwards DELETE, GET, HEAD, OPTIONS, PATCH, POST, and
    /// PUT requests. If you choose the second option, you may need to restrict access to your Amazon S3 bucket or to your custom origin so users
    /// can't perform operations that you don't want them to. For example, you may not want users to have permission to delete objects from your
    /// origin. </para>
    /// </summary>
    public class AllowedMethods
    {
        
        private int? quantity;
        private List<string> items = new List<string>();

        /// <summary>
        /// The number of HTTP methods that you want CloudFront to forward to your origin. Valid values are 2 (for GET and HEAD requests) and 7 (for
        /// DELETE, GET, HEAD, OPTIONS, PATCH, POST, and PUT requests).
        ///  
        /// </summary>
        public int Quantity
        {
            get { return this.quantity ?? default(int); }
            set { this.quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this.quantity.HasValue;
        }

        /// <summary>
        /// A complex type that contains the HTTP methods that you want CloudFront to process and forward to your origin.
        ///  
        /// </summary>
        public List<string> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;
        }
    }
}
