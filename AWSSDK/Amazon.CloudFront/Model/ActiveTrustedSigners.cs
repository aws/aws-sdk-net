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
    /// <para> A complex type that lists the AWS accounts, if any, that you included in the TrustedSigners complex type for the default cache
    /// behavior or for any of the other cache behaviors for this distribution. These are accounts that you want to allow to create signed URLs for
    /// private content. </para>
    /// </summary>
    public class ActiveTrustedSigners  
    {
        
        private bool? enabled;
        private int? quantity;
        private List<Signer> items = new List<Signer>();

        /// <summary>
        /// Each active trusted signer.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        public ActiveTrustedSigners WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }
            

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;       
        }

        /// <summary>
        /// The number of unique trusted signers included in all cache behaviors. For example, if three cache behaviors all list the same three AWS
        /// accounts, the value of Quantity for ActiveTrustedSigners will be 3.
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
        public ActiveTrustedSigners WithQuantity(int quantity)
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
        /// A complex type that contains one Signer complex type for each unique trusted signer that is specified in the TrustedSigners complex type,
        /// including trusted signers in the default cache behavior and in all of the other cache behaviors.
        ///  
        /// </summary>
        public List<Signer> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        public ActiveTrustedSigners WithItems(params Signer[] items)
        {
            foreach (Signer element in items)
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
        public ActiveTrustedSigners WithItems(IEnumerable<Signer> items)
        {
            foreach (Signer element in items)
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
