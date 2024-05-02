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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for InventoryPrefixPredicate
    /// <para>The prefix that an object must have to be included in the inventory results.</para>
    /// </summary>
    public sealed class InventoryPrefixPredicate : InventoryFilterPredicate
    {
        private readonly string prefix;

        /// <summary>
        /// Construct an instance of InventoryPrefixPredicate
        /// </summary>
        /// <param name="prefix"></param>
        public InventoryPrefixPredicate(string prefix)
        {
            this.prefix = prefix;
        }

        /// <summary>
        /// The prefix for the predicate.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
        }

        internal override void Accept(IInventoryPredicateVisitor inventoryPredicateVisitor)
        {
            inventoryPredicateVisitor.Visit(this);
        }
    }
}
