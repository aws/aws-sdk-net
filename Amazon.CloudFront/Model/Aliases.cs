/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> A complex type that contains information about CNAMEs (alternate domain names), if any, for this distribution. </para>
    /// </summary>
    public class Aliases  
    {
        
        private int? quantity;
        private List<string> items = new List<string>();

        /// <summary>
        /// The number of CNAMEs, if any, for this distribution.
        ///  
        /// </summary>
        public int Quantity
        {
            get { return this.quantity ?? default(int); }
            set { this.quantity = value; }
        }

        /// <summary>
        /// Sets the Quantity property
        /// </summary>
        /// <param name="quantity">The value to set for the Quantity property </param>
        /// <returns>this instance</returns>
        public Aliases WithQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }
            

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this.quantity.HasValue;       
        }

        /// <summary>
        /// Optional: A complex type that contains CNAME elements, if any, for this distribution. If Quantity is 0, you can omit Items.
        ///  
        /// </summary>
        public List<string> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        public Aliases WithItems(params string[] items)
        {
            foreach (string element in items)
            {
                this.items.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        public Aliases WithItems(IEnumerable<string> items)
        {
            foreach (string element in items)
            {
                this.items.Add(element);
            }

            return this;
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;       
        }
    }
}
